using BepInEx;
using HarmonyLib;

namespace NoLava
{
    [BepInPlugin(ModName, ModGUID, ModVersion)]
    public class NoLava : BaseUnityPlugin
    {
        public const string ModName = "NoLava";
        public const string ModAuthor = "niiK0";
        public const string ModGUID = "com.niiko.nolava";
        public const string ModVersion = "1.0.1";
        private readonly Harmony harmony = new Harmony(ModGUID);

        void Awake()
        {
            // Applying patches
            harmony.PatchAll();
            Logger.LogInfo($"{ModName} successfully loaded! Made by {ModAuthor}");
        }
    }
}
