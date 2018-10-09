using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Cartoon
    {
        public const string BoingLongUrl = "soundbank://soundlibrary/cartoon/amzn_sfx_boing_long_1x_01";
        public const string BoingMediumUrl = "soundbank://soundlibrary/cartoon/amzn_sfx_boing_med_1x_02";
        public const string BoingShortUrl = "soundbank://soundlibrary/cartoon/amzn_sfx_boing_short_1x_01";

        public static Audio BoingLong => new Audio(BoingLongUrl);
        public static Audio BoingMedium => new Audio(BoingMediumUrl);
        public static Audio BoingShort => new Audio(BoingShortUrl);
    }
}
