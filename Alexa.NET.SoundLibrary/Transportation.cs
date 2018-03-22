using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Transportation
    {
        private const string AirplaneTakeoffWhooshUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_airplane_takeoff_whoosh_01.mp3";
        private const string BicycleBellRingUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_bicycle_bell_ring_01.mp3";
        private const string BusDrivePastUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_bus_drive_past_01.mp3";
        private const string CarAccelerate01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_accelerate_01.mp3";
        private const string CarAccelerate02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_accelerate_02.mp3";
        private const string CarAccelerateNoisyUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_accelerate_noisy_01.mp3";
        private const string CarClickSeatbelt01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_click_seatbelt_01.mp3";
        private const string CarClickSeatbelt02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_click_seatbelt_02.mp3";
        private const string CarCloseDoor01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_close_door_1x_01.mp3";
        private const string CarCloseDoor02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_close_door_1x_02.mp3";
        private const string CarDrivePastUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_drive_past_01.mp3";
        private const string CarHonk01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_honk_1x_01.mp3";
        private const string Car2HonksUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_honk_2x_01.mp3";
        private const string Car3Honks01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_honk_3x_01.mp3";
        private const string Car3Honks02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_honk_3x_02.mp3";
        private const string CarHonkLong01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_honk_long_1x_01.mp3";
        private const string CarHonkLong02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_honk_long_1x_02.mp3";
        private const string CarIntoDrivewayUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_into_driveway_01.mp3";
        private const string CarIntoDrivewayFastUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_into_driveway_fast_01.mp3";
        private const string CarSlamDoorUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_slam_door_1x_01.mp3";
        private const string CarUndoSeatbelt01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_undo_seatbelt_01.mp3";
        private const string CarUndoSeatbelt02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_car_undo_seatbelt_02.mp3";
        private const string MotorcycleAccelerate01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_motorcycle_accelerate_01.mp3";
        private const string MotorcycleAccelerate02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_motorcycle_accelerate_02.mp3";
        private const string MotorcycleEngineIdleUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_motorcycle_engine_idle_01.mp3";
        private const string MotorcycleEngineRev01Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_motorcycle_engine_rev_01.mp3";
        private const string MotorcycleEngineRev02Url = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_motorcycle_engine_rev_01.mp3";
        private const string SubwayLeavingUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_subway_leaving_01.mp3";
        private const string SubwayPassingUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_subway_passing_01.mp3";
        private const string SubwayStoppingUrl = "https://s3.amazonaws.com/ask-soundlibrary/transportation/amzn_sfx_subway_stopping_01.mp3";

        public static Audio AirplaneTakeoffWhoosh => new Audio(AirplaneTakeoffWhooshUrl);
        public static Audio BicycleBellRing => new Audio(BicycleBellRingUrl);
        public static Audio BusDrivePast => new Audio(BusDrivePastUrl);
        public static Audio CarAccelerate01 => new Audio(CarAccelerate01Url);
        public static Audio CarAccelerate02 => new Audio(CarAccelerate02Url);
        public static Audio CarAccelerateNoisy => new Audio(CarAccelerateNoisyUrl);
        public static Audio CarClickSeatbelt01 => new Audio(CarClickSeatbelt01Url);
        public static Audio CarClickSeatbelt02 => new Audio(CarClickSeatbelt02Url);
        public static Audio CarCloseDoor01 => new Audio(CarCloseDoor01Url);
        public static Audio CarCloseDoor02 => new Audio(CarCloseDoor02Url);
        public static Audio CarDrivePast => new Audio(CarDrivePastUrl);
        public static Audio CarHonk01 => new Audio(CarHonk01Url);
        public static Audio Car2Honks => new Audio(Car2HonksUrl);
        public static Audio Car3Honks01 => new Audio(Car3Honks01Url);
        public static Audio Car3Honks02 => new Audio(Car3Honks02Url);
        public static Audio CarHonkLong01 => new Audio(CarHonkLong01Url);
        public static Audio CarHonkLong02 => new Audio(CarHonkLong02Url);
        public static Audio CarIntoDriveway => new Audio(CarIntoDrivewayUrl);
        public static Audio CarIntoDrivewayFast => new Audio(CarIntoDrivewayFastUrl);
        public static Audio CarSlamDoor => new Audio(CarSlamDoorUrl);
        public static Audio CarUndoSeatbelt01 => new Audio(CarUndoSeatbelt01Url);
        public static Audio CarUndoSeatbelt02 => new Audio(CarUndoSeatbelt02Url);
        public static Audio MotorcycleAccelerate01 => new Audio(MotorcycleAccelerate01Url);
        public static Audio MotorcycleAccelerate02 => new Audio(MotorcycleAccelerate02Url);
        public static Audio MotorcycleEngineIdle => new Audio(MotorcycleEngineIdleUrl);
        public static Audio MotorcycleEngineRev01 => new Audio(MotorcycleEngineRev01Url);
        public static Audio MotorcycleEngineRev02 => new Audio(MotorcycleEngineRev02Url);
        public static Audio SubwayLeaving => new Audio(SubwayLeavingUrl);
        public static Audio SubwayPassing => new Audio(SubwayPassingUrl);
        public static Audio SubwayStopping => new Audio(SubwayStoppingUrl);
    }
}
