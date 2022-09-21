using Vintagestory.API.Common;
using HarmonyLib;

namespace TemporalStabiliser
{
    [HarmonyPatch(typeof(Vintagestory.GameContent.SystemTemporalStability), "GetTemporalStability", new[] { typeof(double), typeof(double), typeof(double) })]
    public static class SystemTemporalStabilityPatch
    {
        public static void Postfix(double x, double y, double z, ref float __result, ICoreAPI ___api)
        {
            if (y < 50) __result = 0.0f;
        }
    }
}
