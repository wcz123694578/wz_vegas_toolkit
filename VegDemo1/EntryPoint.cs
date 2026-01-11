using ScriptPortal.Vegas;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Wz.VegasToolkit.Core;
using Wz.VegasToolkit.Core.Extensions;
using Wz.VegasToolkit.Core.Factories;

namespace VegDemo1
{
    public class EntryPoint : ScriptBase
    {
        public void FromVegas(Vegas vegas)
        {
            VegasContext vegasContext = new VegasContext(vegas);
            VideoTrack videoTrack = vegas.GetSelectedTracks<VideoTrack>()
                                         .FirstOrDefault();
            VideoEvent videoEvent = videoTrack.AddVideoEvent();

            IEffectFactory<SpecialEffectType> effectFactory = new SpecialEffectFactory(vegasContext);
            PlugInNode plugInNode = effectFactory.Get(SpecialEffectType.TitlesAndText);

            Media media = new Media(plugInNode);

            videoEvent.AddTake(media.GetVideoStreamByIndex(0));

            OFXEffect oFXEffect = media.Generator.OFXEffect;

            OFXStringParameter textParameter = oFXEffect["Text"] as OFXStringParameter;

            using (RichTextBox richTextBox = new RichTextBox())
            {
                richTextBox.Width = 1920;
                richTextBox.Height = 1080;

                richTextBox.Rtf = textParameter.Value;

                Point point = richTextBox.GetPositionFromCharIndex(1);
            }
        }
    }
}
