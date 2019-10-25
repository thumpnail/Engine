using System;
using System.Collections.Generic;

namespace Engine.Inventory
{
    //is housing the inventory. if something needs a inventory: add  this one.
    public class InventoryManager {
        public List<Item> Inventory = new List<Item>();
        public int invetorySize { get; set; } //is 0 when invenntory can be any size
        public bool hasNoLimit { get; set; }
        public string ownerName { get; set; }

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