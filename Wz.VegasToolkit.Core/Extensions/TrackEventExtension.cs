using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wz.VegasToolkit.Core.Extensions
{
    public static class TrackEventExtension
    {

        public static IEnumerable<VideoEvent> GetSelectedTrackEvents(
            this VideoTrack track)
        {
            return track.Events.Where(e => e.Selected).OfType<VideoEvent>();
        }

        public static IEnumerable<AudioEvent> GetSelectedTrackEvents(
            this AudioTrack track)
        {
            return track.Events.Where(e => e.Selected).OfType<AudioEvent>();
        }
    }
}
