using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Economic {
    public class _Store {
        private string storeName;
        private string storeID;
        private int storeMoney;

        public _Store(string storeName, string storeID) {
            this.storeName = storeName;
            this.storeID = storeID;
        }
        //getter and setter
        public void setStoreName(string name) {

        }
        public string getStoreName() {
            return storeName;
        }
        public void setStoreID(string ID) {
            this.storeID = ID;
        }
        public string getStoreID() {
            return storeID;
        }
        public void setStoreMoney(int money) {
            this.storeMoney = money;
        }
        public int getStoreMoney() {
            return storeMoney;
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
