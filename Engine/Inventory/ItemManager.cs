using System;
using System.Collections.Generic;
using System.Text;
using Engine;

namespace Engine.Inventory {
    //all possible items are stored the the list "ItemList". from here the items get added in the inventory
    public static class ItemManager {
        private static List<Item> ItemList = new List<Item>();

        public static Item GetItemByID(int id) {
            for (int i = 0; i < ItemList.Count; i++) {
                if (ItemList[i].GetID().Equals(id)) {
                    return ItemList[i];
                }
            }
            return null;
        }
        public static Item GetItemByName(string name) {
            for (int i = 0; i < ItemList.Capacity; i++) {
                if (ItemList[i].GetName().Equals(name)) {
                    return ItemList[i];
                }
            }
            return null;
        }
        public static void AddStandardItemToItemList(int id, string name, int value) {
            ItemList.Add(new Item(id, name, value));
        }
        public static void AddWeaponItemToItemList(int id, string name, int value, int damage, int durability) {
            ItemList.Add(new Item(id, name, value, damage, durability));
        }
        public static void AddDrinkItemToItemList(int id, string name, int value, int durability, Effect effect) {
            ItemList.Add(new Item(id, name, value, durability, effect));
        }
        public static void AddTalismanItemToItemList(int id, string name, int value, int durability, Buff buff) {
            ItemList.Add(new Item(id, name, value, durability, buff));
        }
        public static void AddStoneItemToItemList(int id, string name, int value, Buff buff) {
            ItemList.Add(new Item(id, name, value, buff));
        }
        public static void AddStoryRelatedItemToItemList(int id, string name, int value, string content) {
            ItemList.Add(new Item(id, name, value, content));
        }
        public static void AddBookItemToItemList(int id, string name, int value, Book book) {
            ItemList.Add(new Item(id, name, value, book));
        }
        public static void AddPaperItemToItemList(int id, string name, int value, Paper paper) {
            ItemList.Add(new Item(id, name, value, paper));
        }
        public static void AddPoisonItemToItemList(int id, string name, int value, Effect effect, int durability, int damage) {
            ItemList.Add(new Item(id, name, value, effect, durability, damage));
        }
        public static void AddMapItemToItemList(int id, string name, int value, Map map) {
            ItemList.Add(new Item(id, name, value, map));
        }
        
    }
    //is added to chars
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
