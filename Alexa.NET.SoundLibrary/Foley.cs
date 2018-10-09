using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Foley
    {
        private static string ClockTickingUrl = "soundbank://soundlibrary/foley/amzn_sfx_clock_ticking_01";
        private static string ClockTickingLongUrl = "soundbank://soundlibrary/foley/amzn_sfx_clock_ticking_long_01";
        private static string GlassOnTableUrl = "soundbank://soundlibrary/foley/amzn_sfx_glass_on_table_01";
        private static string GlassesClick01Url = "soundbank://soundlibrary/foley/amzn_sfx_glasses_clink_01";
        private static string GlassesClick02Url = "soundbank://soundlibrary/foley/amzn_sfx_glasses_clink_02";
        private static string GlassesClick03Url = "soundbank://soundlibrary/foley/amzn_sfx_glasses_clink_03";
        private static string GlassesClick04Url = "soundbank://soundlibrary/foley/amzn_sfx_glasses_clink_04";
        private static string JarOnTableUrl = "soundbank://soundlibrary/foley/amzn_sfx_jar_on_table_1x_01";
        private static string KitchenAmbienceUrl = "soundbank://soundlibrary/foley/amzn_sfx_kitchen_ambience_01";
        private static string LargeFireCracklingUrl = "soundbank://soundlibrary/foley/amzn_sfx_large_fire_crackling_01";
        private static string TwoObjectsOnTableUrl = "soundbank://soundlibrary/foley/amzn_sfx_object_on_table_2x_01";
        private static string RestaurantAmbience01Url = "soundbank://soundlibrary/foley/amzn_sfx_restaurant_ambience_01";
        private static string RestaurantAmbience02Url = "soundbank://soundlibrary/foley/amzn_sfx_restaurant_ambience_02";
        private static string SilverwareClank01Url = "soundbank://soundlibrary/foley/amzn_sfx_silverware_clank_01";
        private static string SilverwareClank02Url = "soundbank://soundlibrary/foley/amzn_sfx_silverware_clank_02";
        private static string SilverwareClank03Url = "soundbank://soundlibrary/foley/amzn_sfx_silverware_clank_03";
        private static string SleighBells01Url = "soundbank://soundlibrary/foley/amzn_sfx_sleigh_bells_01";
        private static string SleighBells02Url = "soundbank://soundlibrary/foley/amzn_sfx_sleigh_bells_02";
        private static string SwooshCartoonFast01Url = "soundbank://soundlibrary/foley/amzn_sfx_swoosh_cartoon_fast_01";
        private static string SwooshCartoonFast02Url = "soundbank://soundlibrary/foley/amzn_sfx_swoosh_cartoon_fast_02";
        private static string SwooshFastUrl = "soundbank://soundlibrary/foley/amzn_sfx_swoosh_fast_1x_01";
        private static string Swoosh6FastUrl = "soundbank://soundlibrary/foley/amzn_sfx_swoosh_fast_6x_01";
        private static string FourWingsFlapUrl = "soundbank://soundlibrary/foley/amzn_sfx_wings_flap_4x_01";
        private static string WingsFlapFastUrl = "soundbank://soundlibrary/foley/amzn_sfx_wings_flap_fast_01";
        private static string WoodenDoorUrl = "soundbank://soundlibrary/foley/amzn_sfx_wooden_door_01";
        private static string WoodenDoorCreaksLong01Url = "soundbank://soundlibrary/foley/amzn_sfx_wooden_door_creaks_long_01";
        private static string WoodenDoorCreaksLong02Url = "soundbank://soundlibrary/foley/amzn_sfx_wooden_door_creaks_long_02";
        private static string WoodenDoorCreaksMultipleUrl = "soundbank://soundlibrary/foley/amzn_sfx_wooden_door_creaks_multiple_01";
        private static string WoodenDoorCreaksOpenUrl = "soundbank://soundlibrary/foley/amzn_sfx_wooden_door_creaks_open_01";

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
