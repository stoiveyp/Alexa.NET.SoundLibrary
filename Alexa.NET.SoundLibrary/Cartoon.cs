using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Cartoon
    {
        public const string BoingLongUrl = "https://s3.amazonaws.com/ask-soundlibrary/cartoon/amzn_sfx_boing_long_1x_01.mp3";
        public const string BoingMediumUrl = "https://s3.amazonaws.com/ask-soundlibrary/cartoon/amzn_sfx_boing_med_1x_02.mp3";
        public const string BoingShortUrl = "https://s3.amazonaws.com/ask-soundlibrary/cartoon/amzn_sfx_boing_short_1x_01.mp3";

        public static Audio BoingLong => new Audio(BoingLongUrl);
        public static Audio BoingMedium => new Audio(BoingMediumUrl);
        public static Audio BoingShort => new Audio(BoingShortUrl);
    }
}
