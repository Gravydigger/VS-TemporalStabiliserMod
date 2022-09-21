using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace Gravy.TemporalStabiliser
{
    public class TemporalStabiliserMod : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockEntityClass("temporalstabiliser", typeof(TemporalStabiliserBlock));
        }
    }

    public class TemporalStabiliserBlock : BlockEntity
    {

        public override void OnBlockPlaced(ItemStack byItemStack = null)
        {
            base.OnBlockPlaced(byItemStack);

            Api.Logger.Debug("block placed");

            var temporalStabilitySys = Api.ModLoader.GetModSystem<SystemTemporalStability>();

            Api.Logger.Debug("local stability: " + temporalStabilitySys.GetTemporalStability(Pos));
        }

        public override void OnBlockBroken(IPlayer byPlayer = null)
        {
            base.OnBlockBroken(byPlayer);

            Api.Logger.Debug("block destroyed");

            var temporalStabilitySys = Api.ModLoader.GetModSystem<SystemTemporalStability>();

            Api.Logger.Debug("local stability: " + temporalStabilitySys.GetTemporalStability(Pos));
        }
    }
}