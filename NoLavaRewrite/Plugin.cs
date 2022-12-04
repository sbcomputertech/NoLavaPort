using BepInEx;
using HarmonyLib;

namespace NoLavaRewrite
{
    [BepInPlugin("com.reddust9.nolavaport", "NoLava", "2.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo("NoLava by niiK0, ported by reddust9 is loaded!");
            var harmony = new Harmony("com.reddust9.nolavaport");
            harmony.PatchAll();
        }
        [HarmonyPatch(typeof(DeathZone), "Start")]
        public class DeathZone_Remove
        {

            [HarmonyPrefix]
            private static bool DisableLava(ref DeathZone __instance)
            {
                __instance.gameObject.SetActive(false);
                return false;
            }
        }
    }
}