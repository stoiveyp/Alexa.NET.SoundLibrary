using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Ambience
    {
        private static string CrowdBarUrl = "soundbank://soundlibrary/ambience/amzn_sfx_crowd_bar_01";
        private static string CrowdBarRowdyUrl = "soundbank://soundlibrary/ambience/amzn_sfx_crowd_bar_rowdy_01";

        public static Audio CrowdBar => new Audio(CrowdBarUrl);
        public static Audio CrowdBarRowdy => new Audio(CrowdBarRowdyUrl);
    }
}
