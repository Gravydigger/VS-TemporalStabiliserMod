using Vintagestory.API.Common;
using Vintagestory.GameContent;
using Vintagestory.API.Util;
using Vintagestory.API.MathTools;

namespace TemporalStabiliser
{
    public class TemporalStabiliserBE : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockEntityClass("temporalstabiliser", typeof(BlockEntityTemporalStabiliser));
        }
    }

    public class BlockEntityTemporalStabiliser : BlockEntity
    {
        const int radius = 8;
        BlockPos[] affectedArea = new BlockPos[] { new BlockPos(0, 0, 0), new BlockPos(0, 0, 0) };
        GuiDialogBlockEntityTemporalStabiliser clientDialog;
        InventoryBase inventory;

        public override void OnBlockPlaced(ItemStack byItemStack = null)
        {
            base.OnBlockPlaced(byItemStack);

            //Api.Logger.Debug("block placed");

            affectedArea[0] = new BlockPos(Pos.X + radius, Pos.Y + radius, Pos.Z + radius);
            affectedArea[1] = new BlockPos(Pos.X - radius, Pos.Y - radius, Pos.Z - radius);

            //Api.Logger.Debug("BlockPos: " + Pos);
            Api.Logger.Debug("affectedArea: " + affectedArea[0] + "; " + affectedArea[1]);
        }

        public override void OnBlockBroken(IPlayer byPlayer = null)
        {
            base.OnBlockBroken(byPlayer);

            //Api.Logger.Debug("block destroyed");
            Api.Logger.Debug("affectedArea: " + affectedArea[0] + "; " + affectedArea[1]);

            affectedArea = new BlockPos[] { new BlockPos(0, 0, 0), new BlockPos(0, 0, 0) };

            //var temporalStabilitySys = Api.ModLoader.GetModSystem<SystemTemporalStability>();

            //Api.Logger.Debug("local stability: " + temporalStabilitySys.GetTemporalStability(Pos));
        }

        //internal void OnPlayerInteract(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel)
        //{
        //    clientDialog = new GuiDialogBlockEntityTemporalStabiliser("Temporal Stabiliser", );
        //    clientDialog.TryOpen();
        //    clientDialog.OnClosed += () => clientDialog = null;
        //}

    }
}