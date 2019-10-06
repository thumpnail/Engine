using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Inventory {
    
    public class Item {
        //item type enum list
        private enum itemTypeList {
            standard = 1,
            weapon = 2,
            drink = 3,
            talisman = 4,
            stone = 5,
            storyRelated = 6,
            book = 7,
            paper = 8,
            poison = 9,
            map = 10
        }

        private int id; //identification
        private string name; //name of te item
        private int value; //"mehrwehrt"(ger)
        private itemTypeList itemType; //just types
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
        Item(int id, string name, int value) {
            itemType = itemTypeList.standard;
            this.id = id;
            this.name = name;
            this.value = value;
        }
        //Weapon
        Item(int id, string name, int value, int damage, int durability) {
            itemType = itemTypeList.weapon;
            this.id = id;
            this.name = name;
            this.value = value;
            this.damage = damage;
            this.durability = durability;
        }
        //Drink
        Item(int id, string name, int value, int durability, Effect effect) {
            itemType = itemTypeList.drink;
            this.id = id;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.effect = effect;
        }
        //Talisman
        Item(int id, string name, int value, int durability, Buff buff) {
            itemType = itemTypeList.talisman;
            this.id = id;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.buff = buff;
        }
        //Stone
        Item(int id, string name, int value, Buff buff) {
            itemType = itemTypeList.stone;
            this.id = id;
            this.name = name;
            this.value = value;
            this.buff = buff;
        }
        //StoryRelated
        Item(int id, string name, int value, string content) {
            itemType = itemTypeList.storyRelated;
            this.id = id;
            this.name = name;
            this.value = value;
            this.content = content;
        }
        //Book
        Item(int id, string name, int value, Book book) {
            itemType = itemTypeList.book;
            this.id = id;
            this.name = name;
            this.value = value;
            this.book = book;
        }
        //Paper
        Item(int id, string name, int value, Paper paper) {
            itemType = itemTypeList.paper;
            this.id = id;
            this.name = name;
            this.value = value;
            this.paper = paper;
        }
        //Poison
        Item(int id, string name, int value, Effect effect, int durability) {
            itemType = itemTypeList.poison;
            this.id = id;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.effect = effect;
        }
        Item(int id, string name, int value, Map map) {
            itemType = itemTypeList.map;
            this.id = id;
            this.name = name;
            this.value = value;
            this.map = map;
        }
    }
}
