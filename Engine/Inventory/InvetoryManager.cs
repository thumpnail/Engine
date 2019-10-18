using System;
using System.Collections.Generic;

namespace Engine.Inventory
{
    public class InventoryManager {
        public List<Item> Inventory = new List<Item>();
        private int invetorySize; //is 0 when invenntory can be any size
        private bool hasNoLimit;
        private string ownerName;

        public InventoryManager() {
            this.invetorySize = 0;
            this.hasNoLimit = true;
        } 
        public InventoryManager(int size) {
            this.invetorySize = size - 1;
            this.hasNoLimit = false;
        }
    }
}

}
