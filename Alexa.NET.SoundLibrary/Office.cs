using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Ssml.SoundLibrary
{
    public static class Office
    {
        private const string CopyMachine01Url = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_copy_machine_01.mp3";
        private const string CopyMachine02Url = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_copy_machine_02.mp3";
        private const string ElevatorBellUrl = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_elevator_bell_1x_01.mp3";
        private const string ElevatorOpenBellUrl = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_elevator_open_bell_01.mp3";
        private const string TypingMedium01Url = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_typing_medium_01.mp3";
        private const string TypingMedium02Url = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_typing_medium_02.mp3";
        private const string TypingShort01Url = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_typing_short_01.mp3";
        private const string TypingShort02Url = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_typing_short_02.mp3";
        private const string TypingTypewriterUrl = "https://s3.amazonaws.com/ask-soundlibrary/office/amzn_sfx_typing_typewriter_01.mp3";

        public static Audio CopyMachine01 => new Audio(CopyMachine01Url);
        public static Audio CopyMachine02 => new Audio(CopyMachine02Url);
        public static Audio ElevatorBell => new Audio(ElevatorBellUrl);
        public static Audio ElevatorOpenBell => new Audio(ElevatorOpenBellUrl);
        public static Audio TypingMedium01 => new Audio(TypingMedium01Url);
        public static Audio TypingMedium02 => new Audio(TypingMedium02Url);
        public static Audio TypingShort01 => new Audio(TypingShort01Url);
        public static Audio TypingShort02 => new Audio(TypingShort02Url);
        public static Audio TypingTypewriter => new Audio(TypingTypewriterUrl);
    }
}
