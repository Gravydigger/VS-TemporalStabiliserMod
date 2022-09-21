using Vintagestory.API.Common;
using HarmonyLib;

namespace Gravy.TemporalStabiliser
{

    [HarmonyPatch(typeof(Vintagestory.GameContent.SystemTemporalStability), "GetTemporalStability", new[] { typeof(double), typeof(double), typeof(double) })]
    public static class SystemTemporalStabilityPatch
    {
        static void Postfix(double x, double y, double z, ref float __result, ICoreAPI ___api)
        {
            // your code here
        }
    }
}
