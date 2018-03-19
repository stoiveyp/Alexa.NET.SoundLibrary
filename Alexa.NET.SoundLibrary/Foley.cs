using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Ssml.SoundLibrary
{
    public static class Foley
    {
        private static string ClockTickingUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_clock_ticking_01.mp3";
        private static string ClockTickingLongUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_clock_ticking_long_01.mp3";
        private static string GlassOnTableUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_glass_on_table_01.mp3";
        private static string GlassesClick01Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_glasses_clink_01.mp3";
        private static string GlassesClick02Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_glasses_clink_02.mp3";
        private static string GlassesClick03Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_glasses_clink_03.mp3";
        private static string GlassesClick04Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_glasses_clink_04.mp3";
        private static string JarOnTableUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_jar_on_table_1x_01.mp3";
        private static string KitchenAmbienceUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_kitchen_ambience_01.mp3";
        private static string LargeFireCracklingUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_large_fire_crackling_01.mp3";
        private static string TwoObjectsOnTableUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_object_on_table_2x_01.mp3";
        private static string RestaurantAmbience01Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_restaurant_ambience_01.mp3";
        private static string RestaurantAmbience02Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_restaurant_ambience_02.mp3";
        private static string SilverwareClank01Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_silverware_clank_01.mp3";
        private static string SilverwareClank02Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_silverware_clank_02.mp3";
        private static string SilverwareClank03Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_silverware_clank_03.mp3";
        private static string SleighBells01Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_sleigh_bells_01.mp3";
        private static string SleighBells02Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_sleigh_bells_02.mp3";
        private static string SwooshCartoonFast01Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_swoosh_cartoon_fast_01.mp3";
        private static string SwooshCartoonFast02Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_swoosh_cartoon_fast_02.mp3";
        private static string SwooshFastUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_swoosh_fast_1x_01.mp3";
        private static string Swoosh6FastUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_swoosh_fast_6x_01.mp3";
        private static string FourWingsFlapUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wings_flap_4x_01.mp3";
        private static string WingsFlapFastUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wings_flap_fast_01.mp3";
        private static string WoodenDoorUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wooden_door_01.mp3";
        private static string WoodenDoorCreaksLong01Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wooden_door_creaks_long_01.mp3";
        private static string WoodenDoorCreaksLong02Url = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wooden_door_creaks_long_02.mp3";
        private static string WoodenDoorCreaksMultipleUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wooden_door_creaks_multiple_01.mp3";
        private static string WoodenDoorCreaksOpenUrl = "https://s3.amazonaws.com/ask-soundlibrary/foley/amzn_sfx_wooden_door_creaks_open_01.mp3";

        public static Audio ClockTicking => new Audio(ClockTickingUrl);
        public static Audio ClockTickingLong => new Audio(ClockTickingLongUrl);
        public static Audio GlassOnTable => new Audio(GlassOnTableUrl);
        public static Audio GlassesClick01 => new Audio(GlassesClick01Url);
        public static Audio GlassesClick02 => new Audio(GlassesClick02Url);
        public static Audio GlassesClick03 => new Audio(GlassesClick03Url);
        public static Audio GlassesClick04 => new Audio(GlassesClick04Url);
        public static Audio JarOnTable => new Audio(JarOnTableUrl);
        public static Audio KitchenAmbience => new Audio(KitchenAmbienceUrl);
        public static Audio LargeFireCrackling => new Audio(LargeFireCracklingUrl); 
        public static Audio TwoObjectsOnTable => new Audio(TwoObjectsOnTableUrl);
        public static Audio RestaurantAmbience01 => new Audio(RestaurantAmbience01Url);
        public static Audio RestaurantAmbience02 => new Audio(RestaurantAmbience02Url);
        public static Audio SilverwareClank01 => new Audio(SilverwareClank01Url);
        public static Audio SilverwareClank02 => new Audio(SilverwareClank02Url);
        public static Audio SilverwareClank03 => new Audio(SilverwareClank03Url); 
        public static Audio SleighBells01 => new Audio(SleighBells01Url);
        public static Audio SleighBells02 => new Audio(SleighBells02Url);
        public static Audio SwooshCartoonFast01 => new Audio(SwooshCartoonFast01Url);
        public static Audio SwooshCartoonFast02 => new Audio(SwooshCartoonFast02Url);
        public static Audio SwooshFast => new Audio(SwooshFastUrl);
        public static Audio Swoosh6Fast => new Audio(Swoosh6FastUrl);
        public static Audio FourWingsFlap => new Audio(FourWingsFlapUrl);
        public static Audio WingsFlapFast => new Audio(WingsFlapFastUrl);
        public static Audio WoodenDoor => new Audio(WoodenDoorUrl);
        public static Audio WoodenDoorCreaksLong01 => new Audio(WoodenDoorCreaksLong01Url); 
        public static Audio WoodenDoorCreaksLong02 => new Audio(WoodenDoorCreaksLong02Url);
        public static Audio WoodenDoorCreaksMultiple => new Audio(WoodenDoorCreaksMultipleUrl);
        public static Audio WoodenDoorCreaksOpen => new Audio(WoodenDoorCreaksOpenUrl);
    }
}
