using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Impact
    {
        private const string FireworksUrl = "soundbank://soundlibrary/impacts/amzn_sfx_fireworks_01";
        private const string FireworksFirecrackersUrl = "soundbank://soundlibrary/impacts/amzn_sfx_fireworks_firecrackers_01";
        private const string FireworksLaunchUrl = "soundbank://soundlibrary/impacts/amzn_sfx_fireworks_launch_01";
        private const string FireworksWhistles01 = "soundbank://soundlibrary/impacts/amzn_sfx_fireworks_whistles_01";
        private const string FireworksWhistles02 = "soundbank://soundlibrary/impacts/amzn_sfx_fireworks_whistles_02";
        private const string Punch01Url = "soundbank://soundlibrary/impacts/amzn_sfx_punch_01";
        private const string Punch02Url = "soundbank://soundlibrary/impacts/amzn_sfx_punch_02";
        private const string Punch03Url = "soundbank://soundlibrary/impacts/amzn_sfx_punch_03";

        public static Audio Fireworks => new Audio(FireworksUrl);
        public static Audio FireworksFirecrackers => new Audio(FireworksFirecrackersUrl);
        public static Audio FireworksLaunch => new Audio(FireworksLaunchUrl);
        public static Audio FireworksWhistle01 => new Audio(FireworksWhistles01);
        public static Audio FireworksWhistle02 => new Audio(FireworksWhistles02);
        public static Audio Punch01 => new Audio(Punch01Url);
        public static Audio Punch02 => new Audio(Punch02Url);
        public static Audio Punch03 => new Audio(Punch03Url);
    }
}
