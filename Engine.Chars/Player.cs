using System;
using Engine;

namespace Engine.Chars {
    public class Player {
        Inventory.InventoryManager charInventory;
        public void addInvetory() {
            charInventory = new Inventory.InventoryManager();
        }
    }
}
