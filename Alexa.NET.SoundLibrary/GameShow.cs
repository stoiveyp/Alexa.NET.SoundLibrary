﻿using System;
namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class GameShow
    {
		private const string Bridge01Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_bridge_01.mp3";
		private const string Bridge02Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_bridge_02.mp3";
		private const string CountdownLoop32sFullUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_countdown_loop_32s_full_01.mp3";
		private const string CountdownLoop64sFullUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_countdown_loop_64s_full_01.mp3";
		private const string CountdownLoop64sMinimalUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_countdown_loop_64s_minimal_01.mp3";
		private const string IntroUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_intro_01.mp3";
		private const string NegativeResponse01Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_negative_response_01.mp3";
		private const string NegativeResponse02Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_negative_response_02.mp3";
		private const string NegativeResponse03Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_negative_response_03.mp3";
		private const string NeutralResponse01Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_neutral_response_01.mp3";
		private const string NeutralResponse02Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_neutral_response_02.mp3";
		private const string NeutralResponse03Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_neutral_response_03.mp3";
		private const string OutroUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_outro_01.mp3";
		private const string Player1Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_player1_01.mp3";
		private const string Player2Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_player2_01.mp3";
		private const string Player3Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_player3_01.mp3";
		private const string Player4Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_player4_01.mp3";
		private const string PositiveResponse01Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_positive_response_01.mp3";
		private const string PositiveResponse02Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_positive_response_02.mp3";
		private const string PositiveResponse03Url = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_positive_response_03.mp3";
		private const string TallyNegativeUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_tally_negative_01.mp3";
		private const string TallyPositiveUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_tally_positive_01.mp3";
		private const string WaitingLoop30sUrl = "https://s3.amazonaws.com/ask-soundlibrary/ui/gameshow/amzn_ui_sfx_gameshow_waiting_loop_30s_01.mp3";

		public static Audio Bridge01 => new Audio(Bridge01Url);
        public static Audio Bridge02 => new Audio(Bridge02Url);
        public static Audio CountdownLoop32sFull => new Audio(CountdownLoop32sFullUrl);
        public static Audio CountdownLoop64sFull => new Audio(CountdownLoop64sFullUrl);
        public static Audio CountdownLoop64sMinimal => new Audio(CountdownLoop64sMinimalUrl);
        public static Audio Intro => new Audio(IntroUrl);
        public static Audio NegativeResponse01 => new Audio(NegativeResponse01Url);
        public static Audio NegativeResponse02 => new Audio(NegativeResponse02Url);
        public static Audio NegativeResponse03 => new Audio(NegativeResponse03Url);
        public static Audio NeutralResponse01 => new Audio(NeutralResponse01Url);
        public static Audio NeutralResponse02 => new Audio(NeutralResponse02Url);
        public static Audio NeutralResponse03 => new Audio(NeutralResponse03Url);
        public static Audio Outro => new Audio(OutroUrl);
        public static Audio Player1 => new Audio(Player1Url);
        public static Audio Player2 => new Audio(Player2Url);
        public static Audio Player3 => new Audio(Player3Url);
        public static Audio Player4 => new Audio(Player4Url);
        public static Audio PositiveResponse01 => new Audio(PositiveResponse01Url);
        public static Audio PositiveResponse02 => new Audio(PositiveResponse02Url);
        public static Audio PositiveResponse03 => new Audio(PositiveResponse03Url);
        public static Audio TallyNegative => new Audio(TallyNegativeUrl);
        public static Audio TallyPositive => new Audio(TallyPositiveUrl);
        public static Audio WaitingLoop30s => new Audio(WaitingLoop30sUrl);
    }
}
