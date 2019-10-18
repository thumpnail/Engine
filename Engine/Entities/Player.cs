using System;
using Engine;
using Engine.Inventory;
using System.Collections.Generic;

namespace Engine.Entities {
    public class Player {
        private InventoryManager InvManager;
        private string name;
        private int hp;
        private Item equiptedItem_leftHand;
        private Item equiptedItem_rightHand;
        private List<Item> equiptedItem_list = new List<Item>(5);//0=feet, 1=throuses, 2=chest, 3=head, 4=hand

        private float armor;
        private float speed;
        private float dodge;
        private float throwing;
        private float sanity;
        private float searching;
        private float eyes;
        private float sneaking;
        private float firstAid;

        public Player(string name, int hp, float armor, float speed, float dodge, float throwing, float sanity, float searching, float eyes, float sneaking, float firstAid) {
            this.name = name;
            this.hp = hp;
            this.armor = armor;
            this.speed = speed;
            this.dodge = dodge;
            this.throwing = throwing;
            this.sanity = sanity;
            this.searching = searching;
            InvManager = new InventoryManager();
        }
        public Player(int invSize, string name, int hp) {
            this.name = name;
            this.hp = hp;
            InvManager = new InventoryManager(invSize);
        }
        
        //do damage
        //take damage
    }
}
