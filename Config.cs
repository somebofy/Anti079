namespace Anti079
{
    class Config
    {
        public static bool IsEnabled = Qurre.Plugin.Config.GetBool("ANTI079_IsEnabled", true);

        public static int ANTI079ChangeFrom = Qurre.Plugin.Config.GetInt("ANTI079ChangeFrom", 7);

        public static int ANTI079ChangeTo = Qurre.Plugin.Config.GetInt("ANTI079ChangeTo", 16);

        public static string ANTI079ChangeHint = Qurre.Plugin.Config.GetString("ANTI079ChangeHint", "Your class have been changed from SCP 079 to SCP 939-53");

        public static int ANTI079ChangeHintTime = Qurre.Plugin.Config.GetInt("ANTI079ChangeHintTime", 10);
    }
}
