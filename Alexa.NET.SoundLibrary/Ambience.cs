using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Ssml.SoundLibrary
{
    public static class Ambience
    {
        private static string CrowdBarUrl = "https://s3.amazonaws.com/ask-soundlibrary/ambience/amzn_sfx_crowd_bar_01.mp3";
        private static string CrowdBarRowdyUrl = "https://s3.amazonaws.com/ask-soundlibrary/ambience/amzn_sfx_crowd_bar_rowdy_01.mp3";

        public static Audio CrowdBar => new Audio(CrowdBarUrl);
        public static Audio CrowdBarRowdy => new Audio(CrowdBarRowdyUrl);
    }
}
