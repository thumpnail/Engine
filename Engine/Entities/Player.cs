using System;
using Engine;
using Engine.Inventory;
using System.Collections.Generic;
using System.Numerics;

namespace Engine.Entities {
    public class Player {
        public string ID { get; }
        public Vector2 position { get; set; }
        public InventoryManager InvManager { get; set; }
        public string name { get; set; }
        public int hp { get; set; }
        public Item equiptedItem_leftHand { get; set; }
        public Item equiptedItem_rightHand { get; set; }
        public List<Item> equiptedItem_list = new List<Item>(5);//0=feet, 1=throuses, 2=chest, 3=head, 4=hand

        public bool isPlayer { get; }

        public float armor { get; set; }
        public float speed { get; set; }
        public float dodge { get; set; }
        public float throwing { get; set; }
        public float sanity { get; set; }
        public float searching { get; set; }
        public float eyes { get; set; }
        public float sneaking { get; set; }
        public float firstAid { get; set; }

        public Player(bool isPlayer, string name, int hp, float armor, float speed, float dodge, float throwing, float sanity, float searching, float eyes, float sneaking, float firstAid) {
            this.isPlayer = isPlayer;
            this.name = name;
            this.hp = hp;
            this.armor = armor;
            this.speed = speed;
            this.dodge = dodge;
            this.throwing = throwing;
            this.sanity = sanity;
            this.searching = searching;
            this.eyes = eyes;
            this.sneaking = sneaking;
            this.firstAid = firstAid;
            InvManager = new InventoryManager();
        }
        public Player(bool isPlayer, int invSize, string name, int hp, float armor, float speed, float dodge, float throwing, float sanity, float searching, float eyes, float sneaking, float firstAid) {
            this.isPlayer = isPlayer;
            this.name = name;
            this.hp = hp;
            this.armor = armor;
            this.speed = speed;
            this.dodge = dodge;
            this.throwing = throwing;
            this.sanity = sanity;
            this.searching = searching;
            this.eyes = eyes;
            this.sneaking = sneaking;
            this.firstAid = firstAid;
            InvManager = new InventoryManager(invSize);
        }
        
        //do damage (random multiplayer, critical damage = higher random multiplayer, missing, failure, )
        //take damage
        //equipt item etc
    }
}
