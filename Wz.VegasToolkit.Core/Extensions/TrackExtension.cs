using ScriptPortal.Vegas;
using System.Collections.Generic;
using System.Linq;

namespace Wz.VegasToolkit.Core.Extensions
{
    public static class TrackExtension
    {
        public static IEnumerable<TTrack> GetSelectedTracks<TTrack>(this Vegas vegas) where TTrack : Track
        {
            return vegas.Project.Tracks.Where(t => t.Selected).OfType<TTrack>();
        }
    }
}
