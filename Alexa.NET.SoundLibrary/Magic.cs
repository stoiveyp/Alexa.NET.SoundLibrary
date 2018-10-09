using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Magic
    {
        private const string FairyMelodicChimesUrl = "soundbank://soundlibrary/magic/amzn_sfx_fairy_melodic_chimes_01";
        private const string FairySparkleChimesUrl = "soundbank://soundlibrary/magic/amzn_sfx_fairy_sparkle_chimes_01";
        private const string GhostSpooky01Url = "soundbank://soundlibrary/magic/amzn_sfx_ghost_spooky_01";
        private const string GhostSpooky02Url = "soundbank://soundlibrary/magic/amzn_sfx_ghost_spooky_02";
        private const string GhostSpooky03Url = "soundbank://soundlibrary/magic/amzn_sfx_ghost_spooky_03";
        private const string GhostSpooky04Url = "soundbank://soundlibrary/magic/amzn_sfx_ghost_spooky_04";
        private const string MagicBlastUrl = "soundbank://soundlibrary/magic/amzn_sfx_magic_blast_1x_01";

        public static Audio FairyMelodicChimes => new Audio(FairyMelodicChimesUrl);
        public static Audio FairySparkleChimes => new Audio(FairySparkleChimesUrl);
        public static Audio GhostSpooky01 => new Audio(GhostSpooky01Url);
        public static Audio GhostSpooky02 => new Audio(GhostSpooky02Url);
        public static Audio GhostSpooky03 => new Audio(GhostSpooky03Url);
        public static Audio GhostSpooky04 => new Audio(GhostSpooky04Url);
        public static Audio MagicBlast => new Audio(MagicBlastUrl);
    }
}
