using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Home
    {
        private const string DoorOpen01Url = "soundbank://soundlibrary/home/amzn_sfx_door_open_01";
        private const string DoorOpen02Url = "soundbank://soundlibrary/home/amzn_sfx_door_open_02";
        private const string DoorOpen03Url = "soundbank://soundlibrary/home/amzn_sfx_door_open_03";
        private const string DoorShut01Url = "soundbank://soundlibrary/home/amzn_sfx_door_shut_01";
        private const string DoorShut02Url = "soundbank://soundlibrary/home/amzn_sfx_door_shut_02";
        private const string DoorbellUrl = "soundbank://soundlibrary/home/amzn_sfx_doorbell_01";
        private const string DoorbellBuzzUrl = "soundbank://soundlibrary/home/amzn_sfx_doorbell_buzz_01";
        private const string DoorbellChime01Url = "soundbank://soundlibrary/home/amzn_sfx_doorbell_chime_01";
        private const string DoorbellChime02Url = "soundbank://soundlibrary/home/amzn_sfx_doorbell_chime_02";
        private const string FaucetDrip01Url = "soundbank://soundlibrary/home/amzn_sfx_faucet_drip_01";
        private const string FaucetDrip02Url = "soundbank://soundlibrary/home/amzn_sfx_faucet_drip_02";
        private const string FaucetDrip03Url = "soundbank://soundlibrary/home/amzn_sfx_faucet_drip_03";
        private const string FaucetRunning01Url = "soundbank://soundlibrary/home/amzn_sfx_faucet_running_01";
        private const string FaucetRunning02Url = "soundbank://soundlibrary/home/amzn_sfx_faucet_running_02";
        private const string FaucetRunning03Url = "soundbank://soundlibrary/home/amzn_sfx_faucet_running_03";
        private const string FireplaceCrackle01Url = "soundbank://soundlibrary/home/amzn_sfx_fireplace_crackle_01";
        private const string FireplaceCrackle02Url = "soundbank://soundlibrary/home/amzn_sfx_fireplace_crackle_02";
        private const string FireplaceCrackle03Url = "soundbank://soundlibrary/home/amzn_sfx_fireplace_crackle_03";
        private const string FoodFryingUrl = "soundbank://soundlibrary/home/amzn_sfx_food_frying_01";
        private const string FootstepsUrl = "soundbank://soundlibrary/home/amzn_sfx_footsteps_01";
        private const string FootstepsMuffledUrl = "soundbank://soundlibrary/home/amzn_sfx_footsteps_muffled_02";
        private const string ToiletFlush01Url = "soundbank://soundlibrary/home/amzn_sfx_toilet_flush_01";
        private const string ToiletFlush02Url = "soundbank://soundlibrary/home/amzn_sfx_toilet_flush_02";
        private const string VacuumOffUrl = "soundbank://soundlibrary/home/amzn_sfx_vacuum_off_01";
        private const string VacuumOnUrl = "soundbank://soundlibrary/home/amzn_sfx_vacuum_on_01";

        public static Audio DoorOpen01 => new Audio(DoorOpen01Url);
        public static Audio DoorOpen02 => new Audio(DoorOpen02Url);
        public static Audio DoorOpen03 => new Audio(DoorOpen03Url);
        public static Audio DoorShut01 => new Audio(DoorShut01Url);
        public static Audio DoorShut02 => new Audio(DoorShut02Url);
        public static Audio Doorbell => new Audio(DoorbellUrl);
        public static Audio DoorbellBuzz => new Audio(DoorbellBuzzUrl);
        public static Audio DoorbellChime01 => new Audio(DoorbellChime01Url);
        public static Audio DoorbellChime02 => new Audio(DoorbellChime02Url);
        public static Audio FaucetDrip01 => new Audio(FaucetDrip01Url);
        public static Audio FaucetDrip02 => new Audio(FaucetDrip02Url);
        public static Audio FaucetDrip03 => new Audio(FaucetDrip03Url);
        public static Audio FaucetRunning01 => new Audio(FaucetRunning01Url);
        public static Audio FaucetRunning02 => new Audio(FaucetRunning02Url);
        public static Audio FaucetRunning03 => new Audio(FaucetRunning03Url);
        public static Audio FireplaceCrackle01 => new Audio(FireplaceCrackle01Url);
        public static Audio FireplaceCrackle02 => new Audio(FireplaceCrackle02Url);
        public static Audio FireplaceCrackle03 => new Audio(FireplaceCrackle03Url);
        public static Audio FoodFrying => new Audio(FoodFryingUrl);
        public static Audio Footsteps => new Audio(FootstepsUrl);
        public static Audio FootstepsMuffled => new Audio(FootstepsMuffledUrl);
        public static Audio ToiletFlush01 => new Audio(ToiletFlush01Url);
        public static Audio ToiletFlush02 => new Audio(ToiletFlush02Url);
        public static Audio VacuumOff => new Audio(VacuumOffUrl);
        public static Audio VacuumOn => new Audio(VacuumOnUrl);

    }
}
