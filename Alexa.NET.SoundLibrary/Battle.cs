using Alexa.NET.Response.Ssml;

namespace Alexa.NET.Response.Ssml.SoundLibrary
{
    public static class Battle
    {
        private const string ArmyMarch7ClanksUrl = "soundbank://soundlibrary/battle/amzn_sfx_army_march_clank_7x_01";
        private const string ArmyMarch8LargeUrl = "soundbank://soundlibrary/battle/amzn_sfx_army_march_large_8x_01";
        private const string ArmyMarch8SmallUrl = "soundbank://soundlibrary/battle/amzn_sfx_army_march_small_8x_01";
        private const string BattleGroupClanksUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_group_clanks_01";
        private const string BattleManGruntsUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_man_grunts_01";
        private const string BattleMenGruntsUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_men_grunts_01";
        private const string BattleMenHorsesUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_men_horses_01";
        private const string BattleNoisyClanksUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_noisy_clanks_01";
        private const string BattleYellsMenUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_yells_men_01";
        private const string BattleYellsMenRunUrl = "soundbank://soundlibrary/battle/amzn_sfx_battle_yells_men_run_01";

        public static Audio ArmyMarch7Clanks => new Audio(ArmyMarch7ClanksUrl);
        public static Audio ArmyMarch8Large => new Audio(ArmyMarch8LargeUrl);
        public static Audio ArmyMarch8Small => new Audio(ArmyMarch8SmallUrl);
        public static Audio BattleGroupClanks => new Audio(BattleGroupClanksUrl);
        public static Audio BattleManGrunts => new Audio(BattleManGruntsUrl);
        public static Audio BattleMenGrunts => new Audio(BattleMenGruntsUrl);
        public static Audio BattleMenHorses => new Audio(BattleMenHorsesUrl);
        public static Audio BattleNoisyClanks => new Audio(BattleNoisyClanksUrl);
        public static Audio BattleYellsMen => new Audio(BattleYellsMenUrl);
        public static Audio BattleYellsMenRun => new Audio(BattleYellsMenRunUrl);
    }
}
