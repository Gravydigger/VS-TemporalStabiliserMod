//using System;
//using Vintagestory.API.Common;
//using Vintagestory.API.Datastructures;

//namespace TemporalStabiliser
//{
//    public class InventoryTemporalStabiliser : InventoryBase, ISlotProvider
//    {

//        ItemSlot[] slots;
//        public ItemSlot[] Slots { get { return slots; } }

//        public InventoryTemporalStabiliser(string inventoryID, ICoreAPI api) : base(inventoryID, api)
//        {
//            // slot 0 = input
//            slots = GenEmptySlots(1);
//        }

//        public InventoryTemporalStabiliser(string className, string instanceID, ICoreAPI api) : base(className, instanceID, api)
//        {
//            slots = GenEmptySlots(1);
//        }

//        public override int Count
//        {
//            get { return 1; }
//        }

//        public override ItemSlot this[int slotId]
//        {
//            get
//            {
//                if (slotId < 0 || slotId >= Count) return null;
//                return slots[slotId];
//            }
//            set
//            {
//                if (slotId < 0 || slotId >= Count) throw new ArgumentOutOfRangeException(nameof(slotId));
//                if (value == null) throw new ArgumentNullException(nameof(value));
//                slots[slotId] = value;
//            }
//        }

//        public override void FromTreeAttributes(ITreeAttribute tree)
//        {
//            slots = SlotsFromTreeAttributes(tree);
//        }

//        public override void ToTreeAttributes(ITreeAttribute tree)
//        {
//            SlotsToTreeAttributes(slots, tree);
//        }
//    }
//}
