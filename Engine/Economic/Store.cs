using System;
using System.Collections.Generic;
using System.Text;
using Engine.Inventory;

namespace Engine.Economic {
    public class _Store {
        public InventoryManager inventory = new InventoryManager();
        public string storeName { get; set; }
        public string storeID { get; set; }
        public int storeMoney { get; set; }

        public _Store(string storeName, string storeID) {
            this.storeName = storeName;
            this.storeID = storeID;
        }
        //----------------------------------------------

        //
        public void AddItemToInvetory(string name, int prize) {

        }
        //
        public void RemItemFromInvetory(string name) {

        }

        //public void StoreUserInterface() {

        //        }
    }
}
