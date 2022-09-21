using HarmonyLib;
using Vintagestory.API.Common;

namespace TemporalStabiliser
{
    internal class HarmonyPatcher : ModSystem
    {
        public static bool patched = false;
        public Harmony harmony;
        public override void Start(ICoreAPI api)
        {
            Patcher(api);
        }

        public void Patcher(ICoreAPI api)
        {
            if (patched) return;
            harmony = new Harmony("gravytemporalstabiliser");
            harmony.PatchAll();
            patched = true;
        }

        public override void Dispose()
        {
            harmony?.UnpatchAll("gravytemporalstabiliser");
            patched = false;
        }
    }
}
