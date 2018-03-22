using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Musical
    {
        private const string BeepUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_beep_1x_01.mp3";
        private const string BellMediumChimeUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_bell_med_chime_02.mp3";
        private const string BellShortChime01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_bell_short_chime_01.mp3";
        private const string BellShortChime02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_bell_short_chime_02.mp3";
        private const string BellShortChime03Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_bell_short_chime_03.mp3";
        private const string BellTimerUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_bell_timer_01.mp3";
        private const string BuzzElectronicUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_buzz_electronic_01.mp3";
        private const string BuzzerLoudAlarmUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_buzzer_loud_alarm_01.mp3";
        private const string BuzzerSmallUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_buzzer_small_01.mp3";
        private const string ChurchBell01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_church_bell_1x_01.mp3";
        private const string ChurchBell02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_church_bell_1x_02.mp3";
        private const string ChurchBell03Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_church_bell_1x_03.mp3";
        private const string ChurchBell04Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_church_bell_1x_04.mp3";
        private const string ChurchBell05Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_church_bell_1x_05.mp3";
        private const string ChurchBellRingingUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_church_bells_ringing_01.mp3";
        private const string DrumAndCymbal01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_drum_and_cymbal_01.mp3";
        private const string DrumAndCymbal02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_drum_and_cymbal_02.mp3";
        private const string DrumComedy01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_drum_comedy_01.mp3";
        private const string DrumComedy02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_drum_comedy_02.mp3";
        private const string DrumComedy03Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_drum_comedy_03.mp3";
        private const string ElectricGuitar01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_electric_guitar_01.mp3";
        private const string ElectricGuitar02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_electric_guitar_02.mp3";
        private const string ElectriconicBeep01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_electronic_beep_01.mp3";
        private const string ElectriconicBeep02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_electronic_beep_02.mp3";
        private const string ElectriconicBeep03Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_electronic_beep_03.mp3";
        private const string ElectronicMajorChordUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_electronic_major_chord_01.mp3";
        private const string MusicalDroneIntro01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_musical_drone_intro_01.mp3";
        private const string MusicalDroneIntro02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_musical_drone_intro_02.mp3";
        private const string PianoNoteUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_piano_note_1x_01.mp3";
        private const string TestToneUrl = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_test_tone_01.mp3";
        private const string TrumpetBugle01Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_trumpet_bugle_01.mp3";
        private const string TrumpetBugle02Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_trumpet_bugle_02.mp3";
        private const string TrumpetBugle03Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_trumpet_bugle_03.mp3";
        private const string TrumpetBugle04Url = "https://s3.amazonaws.com/ask-soundlibrary/musical/amzn_sfx_trumpet_bugle_04.mp3";

        public static Audio Beep => new Audio(BeepUrl);
        public static Audio BellMediumChime => new Audio(BellMediumChimeUrl);
        public static Audio BellShortChime01 => new Audio(BellShortChime01Url);
        public static Audio BellShortChime02 => new Audio(BellShortChime02Url);
        public static Audio BellShortChime03 => new Audio(BellShortChime03Url);
        public static Audio BellTimer => new Audio(BellTimerUrl);
        public static Audio BuzzElectronic => new Audio(BuzzElectronicUrl);
        public static Audio BuzzerLoudAlarm => new Audio(BuzzerLoudAlarmUrl);
        public static Audio BuzzerSmall => new Audio(BuzzerSmallUrl);
        public static Audio ChurchBell01 => new Audio(ChurchBell01Url);
        public static Audio ChurchBell02 => new Audio(ChurchBell02Url);
        public static Audio ChurchBell03 => new Audio(ChurchBell03Url);
        public static Audio ChurchBell04 => new Audio(ChurchBell04Url);
        public static Audio ChurchBell05 => new Audio(ChurchBell05Url);
        public static Audio ChurchBellRinging => new Audio(ChurchBellRingingUrl);
        public static Audio DrumAndCymbal01 => new Audio(DrumAndCymbal01Url);
        public static Audio DrumAndCymbal02 => new Audio(DrumAndCymbal02Url);
        public static Audio DrumComedy01 => new Audio(DrumComedy01Url);
        public static Audio DrumComedy02 => new Audio(DrumComedy02Url);
        public static Audio DrumComedy03 => new Audio(DrumComedy03Url);
        public static Audio ElectricGuitar01 => new Audio(ElectricGuitar01Url);
        public static Audio ElectricGuitar02 => new Audio(ElectricGuitar02Url);
        public static Audio ElectriconicBeep01 => new Audio(ElectriconicBeep01Url);
        public static Audio ElectriconicBeep02 => new Audio(ElectriconicBeep02Url);
        public static Audio ElectriconicBeep03 => new Audio(ElectriconicBeep03Url);
        public static Audio ElectronicMajorChord => new Audio(ElectronicMajorChordUrl);
        public static Audio MusicalDroneIntro01 => new Audio(MusicalDroneIntro01Url);
        public static Audio MusicalDroneIntro02 => new Audio(MusicalDroneIntro02Url);
        public static Audio PianoNote => new Audio(PianoNoteUrl);
        public static Audio TestTone => new Audio(TestToneUrl);
        public static Audio TrumpetBugle01 => new Audio(TrumpetBugle01Url);
        public static Audio TrumpetBugle02 => new Audio(TrumpetBugle02Url);
        public static Audio TrumpetBugle03 => new Audio(TrumpetBugle03Url);
        public static Audio TrumpetBugle04 => new Audio(TrumpetBugle04Url);

    }
}
