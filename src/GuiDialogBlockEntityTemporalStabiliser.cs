using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace TemporalStabiliser
{
    public class GuiDialogBlockEntityTemporalStabiliser : GuiDialogBlockEntity
    {

        public GuiDialogBlockEntityTemporalStabiliser(string DialogTitle, InventoryBase Inventory, BlockPos BlockEntityPosition, ICoreClientAPI capi) : base(DialogTitle, Inventory, BlockEntityPosition, capi)
        {

            SetupDialog();

        }


        private void SetupDialog()
        {
            // Auto-sized dialog at the center of the screen
            ElementBounds dialogBounds = ElementStdBounds.AutosizedMainDialog.WithAlignment(EnumDialogArea.RightMiddle);

            // Just a simple 300x300 pixel box
            ElementBounds textBounds = ElementBounds.Fixed(0, 0, 300, 300);

            SingleComposer = capi.Gui.CreateCompo("myAwesomeDialog", dialogBounds)
                .AddStaticText("This is a piece of text at the center of your screen - Enjoy!", CairoFont.WhiteDetailText(), textBounds)
                .Compose()
            ;
        }

    }
}
