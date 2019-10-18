using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Inventory {
    
    public class Item {
        private int id; //identification
        private string name; //name of te item
        private int value; //"mehrwehrt"(ger)
        private Enums.itemTypeList itemType; //just types
        private int damage;//damage of poison or weapons... if item type not a weapon or poison or what ever, should be empty or it doesnt matter
        private int durability;//how many times this item could be used(goes down by any use) is if 0 its infinit
        private Buff buff; //only a buff... more likly for stones and talismans but could be Effect
        private Book book;//book with stuff learing, magic, infos what ever
        private Paper paper;//paper with story on it
        private string content;//story related
        private Map map; //Contains a map... for what ever reason
        private Effect effect; //Effects for drinks and talismans
        //crafting?
        //functions?

        //Standard
        public Item(int id, string name, int value) {
            itemType = Enums.itemTypeList.standard;
            this.id = id;
            this.name = name;
            this.value = value;
        }
        //Weapon
        public Item(int id, string name, int value, int damage, int durability) {
            itemType = Enums.itemTypeList.weapon;
            this.id = id;
            this.name = name;
            this.value = value;
            this.damage = damage;
            this.durability = durability;
        }
        //Drink
        public Item(int id, string name, int value, int durability, Effect effect) {
            itemType = Enums.itemTypeList.drink;
            this.id = id;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.effect = effect;
        }
        //Talisman
        public Item(int id, string name, int value, int durability, Buff buff) {
            itemType = Enums.itemTypeList.talisman;
            this.id = id;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.buff = buff;
        }
        //Stone
        public Item(int id, string name, int value, Buff buff) {
            itemType = Enums.itemTypeList.stone;
            this.id = id;
            this.name = name;
            this.value = value;
            this.buff = buff;
        }
        //StoryRelated
        public Item(int id, string name, int value, string content) {
            itemType = Enums.itemTypeList.storyRelated;
            this.id = id;
            this.name = name;
            this.value = value;
            this.content = content;
        }
        //Book
        public Item(int id, string name, int value, Book book) {
            itemType = Enums.itemTypeList.book;
            this.id = id;
            this.name = name;
            this.value = value;
            this.book = book;
        }
        //Paper
        public Item(int id, string name, int value, Paper paper) {
            itemType = Enums.itemTypeList.paper;
            this.id = id;
            this.name = name;
            this.value = value;
            this.paper = paper;
        }
        //Poison
        public Item(int id, string name, int value, Effect effect, int durability, int damage) {
            itemType = Enums.itemTypeList.poison;
            this.id = id;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.effect = effect;
            this.damage = damage;
        }
        //Map
        public Item(int id, string name, int value, Map map) {
            itemType = Enums.itemTypeList.map;
            this.id = id;
            this.name = name;
            this.value = value;
            this.map = map;
        }

        //returns the name
        public string GetName() {
            return name;
        }
        //returns the item ID
        public int GetID() {
            return id;
        }
        //returns the item value... importent for stores
        public int GetValue() {
            return value;
        }
        //returns the item type
        public Enums.itemTypeList GetItemType() {
            if (itemType == Enums.itemTypeList.book) {
                return Enums.itemTypeList.book;
            } else if (itemType == Enums.itemTypeList.drink) {
                return Enums.itemTypeList.drink;
            } else if (itemType == Enums.itemTypeList.map) {
                return Enums.itemTypeList.map;
            } else if (itemType == Enums.itemTypeList.paper) {
                return Enums.itemTypeList.paper;
            } else if (itemType == Enums.itemTypeList.poison) {
                return Enums.itemTypeList.poison;
            } else if (itemType == Enums.itemTypeList.standard) {
                return Enums.itemTypeList.standard;
            } else if (itemType == Enums.itemTypeList.stone) {
                return Enums.itemTypeList.stone;
            } else if (itemType == Enums.itemTypeList.storyRelated) {
                return Enums.itemTypeList.storyRelated;
            } else if (itemType == Enums.itemTypeList.talisman) {
                return Enums.itemTypeList.talisman;
            } else if (itemType == Enums.itemTypeList.weapon) {
                return Enums.itemTypeList.weapon;
            } else {
                return Enums.itemTypeList.nothing;
            }
        }
        //items without a damage value return 0
        public int GetDamage() {
            if (itemType == Enums.itemTypeList.weapon || itemType == Enums.itemTypeList.poison) {
                return damage;
            } else {
                return 0;
            }
        }
        //is 0 when the item got no durability
        public int GetDurability() {
            if (itemType == Enums.itemTypeList.weapon 
                || itemType == Enums.itemTypeList.drink 
                || itemType == Enums.itemTypeList.talisman 
                || itemType == Enums.itemTypeList.poison) {
                return durability;
            } else {
                return 0;
            }
        }
        //returns a buff or returns null
        public Buff GetBuff() {
            if (itemType == Enums.itemTypeList.stone) {
                return buff;
            } else {
                return null;
            }
        }
        //returns the book
        public Book GetBook() {
            if (itemType == Enums.itemTypeList.book) {
                return book;
            } else {
                return null;
            }
        }
        //returns the paper
        public Paper GetPaper() {
            if (itemType == Enums.itemTypeList.paper) {
                return paper;
            } else {
                return null;
            }
        }
        //returns the content
        public string GetContent() {
            return content;
        }
        //returns the map
        public Map GetMap() {
            return map;
        }
        //returns the effect of the item
        public Effect GetEffect() {
            return effect;
        }
    }
}
