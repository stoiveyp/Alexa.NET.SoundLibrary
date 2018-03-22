using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Ssml.SoundLibrary
{
    public static class Nature
    {
        private const string EarthquakeRumble01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_earthquake_rumble_01.mp3";
        private const string EarthquakeRumble02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_earthquake_rumble_02.mp3";
        private const string LightningStrike01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_lightning_strike_01.mp3";
        private const string LightningStrike02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_lightning_strike_02.mp3";
        private const string OarsSplashingrowboatUrl = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_oars_splashing_rowboat_01.mp3";
        private const string OceanWave01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_ocean_wave_1x_01.mp3";
        private const string OceanWave02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_ocean_wave_1x_02.mp3";
        private const string OceanWaveOnRocks01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_ocean_wave_on_rocks_1x_01.mp3";
        private const string OceanWaveOnRocks02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_ocean_wave_on_rocks_1x_02.mp3";
        private const string OceanWaveSurfUrl = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_ocean_wave_surf_01.mp3";
        private const string Rain01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_rain_01.mp3";
        private const string Rain02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_rain_02.mp3";
        private const string Rain03Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_rain_03.mp3";
        private const string RainOnRoofUrl = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_rain_on_roof_01.mp3";
        private const string RainThunder01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_rain_thunder_01.mp3";
        private const string SmallStream01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_small_stream_01.mp3";
        private const string SmallStream02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_small_stream_02.mp3";
        private const string Stream01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_stream_01.mp3";
        private const string Stream02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_stream_02.mp3";
        private const string Stream03Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_stream_03.mp3";
        private const string StrongWindDesert01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_strong_wind_desert_01.mp3";
        private const string StrongWindWhistling01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_strong_wind_whistling_01.mp3";
        private const string StrongWindWhistling02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_strong_wind_whistling_02.mp3";
        private const string StrongWindWhistling03Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_strong_wind_whistling_03.mp3";
        private const string ThunderRumble01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_thunder_rumble_01.mp3";
        private const string ThunderRumble02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_thunder_rumble_02.mp3";
        private const string WaterDrippingUrl = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_water_dripping_01.mp3";
        private const string WaterDroplets01Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_water_droplets_01.mp3";
        private const string WaterDroplets02Url = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_water_droplets_02.mp3";
        private const string WindStrongGustingUrl = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_wind_strong_gusting_01.mp3";
        private const string WindWhistlingDesertUrl = "https://s3.amazonaws.com/ask-soundlibrary/nature/amzn_sfx_wind_whistling_desert_01.mp3";

        public static Audio EarthquakeRumble01 => new Audio(EarthquakeRumble01Url);
        public static Audio EarthquakeRumble02 => new Audio(EarthquakeRumble02Url);
        public static Audio LightningStrike01 => new Audio(LightningStrike01Url);
        public static Audio LightningStrike02 => new Audio(LightningStrike02Url);
        public static Audio OarsSplashingrowboat => new Audio(OarsSplashingrowboatUrl);
        public static Audio OceanWave01 => new Audio(OceanWave01Url);
        public static Audio OceanWave02 => new Audio(OceanWave02Url);
        public static Audio OceanWaveOnRocks01 => new Audio(OceanWaveOnRocks01Url);
        public static Audio OceanWaveOnRocks02 => new Audio(OceanWaveOnRocks02Url);
        public static Audio OceanWaveSurf => new Audio(OceanWaveSurfUrl);
        public static Audio Rain01 => new Audio(Rain01Url);
        public static Audio Rain02 => new Audio(Rain02Url);
        public static Audio Rain03 => new Audio(Rain03Url);
        public static Audio RainOnRoof => new Audio(RainOnRoofUrl);
        public static Audio RainThunder01 => new Audio(RainThunder01Url);
        public static Audio SmallStream01 => new Audio(SmallStream01Url);
        public static Audio SmallStream02 => new Audio(SmallStream02Url);
        public static Audio Stream01 => new Audio(Stream01Url);
        public static Audio Stream02 => new Audio(Stream02Url);
        public static Audio Stream03 => new Audio(Stream03Url);
        public static Audio StrongWindDesert01 => new Audio(StrongWindDesert01Url);
        public static Audio StrongWindWhistling01 => new Audio(StrongWindWhistling01Url);
        public static Audio StrongWindWhistling02 => new Audio(StrongWindWhistling02Url);
        public static Audio StrongWindWhistling03 => new Audio(StrongWindWhistling03Url);
        public static Audio ThunderRumble01 => new Audio(ThunderRumble01Url);
        public static Audio ThunderRumble02 => new Audio(ThunderRumble02Url);
        public static Audio WaterDripping => new Audio(WaterDrippingUrl);
        public static Audio WaterDroplets01 => new Audio(WaterDroplets01Url);
        public static Audio WaterDroplets02 => new Audio(WaterDroplets02Url);
        public static Audio WindStrongGusting => new Audio(WindStrongGustingUrl);
        public static Audio WindWhistlingDesert => new Audio(WindWhistlingDesertUrl);

    }
}
