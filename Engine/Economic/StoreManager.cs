using System;
using System.Collections.Generic;
using System.Text;

//Money and shops
namespace Engine.Economic {
    public static class StoreManager {
        private static List<_Store> _Stores = new List<_Store>();
        
        //Add store to list
        public static void AddStore(string storeName, string storeLocation) {
            _Stores.Add(new _Store(storeName, storeLocation));
        }
        //tries to get a store with a givin name
        public static _Store GetStoreWithName(string name) {
            try {
                for (int i = 0; i < _Stores.Count; i++) {
                    if (_Stores[i].getStoreName().Equals(name)) {

                    }
                    
                }
                return null;
            } catch (Exception) {
                return null;
            }
        }

        public static _Store GetStoreWithID(int storeID) {
            try {
                return _Stores[storeID];
            } catch (Exception) {
                return null;
            }
        }
        //FindStoreWithItem
        //
    }
}