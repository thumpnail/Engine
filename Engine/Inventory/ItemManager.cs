using System;
using System.Collections.Generic;
using System.Text;
using Engine;

namespace Engine.Inventory {
    //all possible items are stored the the list "ItemList". from here the items get added in the inventory
    //items can be added through the Addd... item  thing
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
        public static void AddStandardItemToItemList(string id, string name, int value) {
            ItemList.Add(new Item(id, name, value));
        }
        public static void AddWeaponItemToItemList(string id, string name, int value, int damage, int durability) {
            ItemList.Add(new Item(id, name, value, damage, durability));
        }
        public static void AddDrinkItemToItemList(string id, string name, int value, int durability, Effect effect) {
            ItemList.Add(new Item(id, name, value, durability, effect));
        }
        public static void AddTalismanItemToItemList(string id, string name, int value, int durability, Buff buff) {
            ItemList.Add(new Item(id, name, value, durability, buff));
        }
        public static void AddStoneItemToItemList(string id, string name, int value, Buff buff) {
            ItemList.Add(new Item(id, name, value, buff));
        }
        public static void AddStoryRelatedItemToItemList(string id, string name, int value, string content) {
            ItemList.Add(new Item(id, name, value, content));
        }
        public static void AddBookItemToItemList(string id, string name, int value, Book book) {
            ItemList.Add(new Item(id, name, value, book));
        }
        public static void AddPaperItemToItemList(string id, string name, int value, Paper paper) {
            ItemList.Add(new Item(id, name, value, paper));
        }
        public static void AddPoisonItemToItemList(string id, string name, int value, Effect effect, int durability, int damage) {
            ItemList.Add(new Item(id, name, value, effect, durability, damage));
        }
        public static void AddMapItemToItemList(string id, string name, int value, Map map) {
            ItemList.Add(new Item(id, name, value, map));
        }
        
    }
}