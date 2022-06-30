using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    

    public class Item : MonoBehaviour
    {

        public int id;
        public string title;

        public Item()
        {

        }
    }


    public class Shoes : Item
    {
        public new int id;
        public new string title;
        public int Speed;
        public float Drag;


    public Shoes(int id, string title, int Speed, float Drag)
        {
            this.id = id;
            this.title = title;
            this.Speed = Speed;
            this.Drag = Drag;

    }

        public Shoes(Shoes shoes)
        {
            this.id = shoes.id;
            this.title = shoes.title;
            this.Speed = shoes.Speed;
            this.Drag = shoes.Drag;
        }
    }

    public class BackPack : Item
    {
        public new int id;
        public new string title;
        public float Gravity;

        public BackPack(int id, string title, float Gravity)
        {
            this.id = id;
            this.title = title;
            this.Gravity = Gravity;
        }

        public BackPack(BackPack backpack)
        {
            this.id = backpack.id;
            this.title = backpack.title;
            this.Gravity = backpack.Gravity;
        }
    }
    public class ItemDataBase : MonoBehaviour
    {
        public List<Shoes> shoes = new List<Shoes>();

        public List<BackPack> backpack = new List<BackPack>();


        void Awake()
        {
            BuildShoesDataBase();
            BuildBackPackDataBase();
        }

        public int GetID(string title)
        {
            bool HasBP = backpack.Exists(b => b.title == title);
            if (HasBP == true)
            {
                BackPack holderB = backpack.Find(b => b.title == title);
                Debug.Log("ID:" + holderB.id);
                return holderB.id;
            }
            Shoes holderS = shoes.Find(s => s.title == title);
            Debug.Log("ID" + holderS.id);
            return holderS.id;
        }

        public int GetShoesSpeed(string title)
        {
            
            Shoes holderS = shoes.Find(shoes => shoes.title == title);
            return holderS.Speed;
        }

        public float GetShoesDrag(string title)
        { 
            Shoes holderS = shoes.Find(shoes => shoes.title == title);
            return holderS.Drag;
        }

    public float GetBackPackGravity(string title)
        {
            BackPack holderB = backpack.Find(backpack => backpack.title == title);
            return holderB.Gravity;
        }


        void BuildShoesDataBase()
        {
            shoes = new List<Shoes>()
        {
            new Shoes(4, "SlippySlides(Clone)", 70, 0.01f),
            new Shoes(5, "GrippedTrainers(Clone)", 35, 0.175f),
            new Shoes(6, "Wano11s(Clone)", 55, 0.02f),

        };
        }

        void BuildBackPackDataBase()
        {
            backpack = new List<BackPack>()
        {
            new BackPack(1, "Cannon(Clone)", 0.65f),
            new BackPack(2, "Auto(Clone)", 0.75f),
            new BackPack(3, "BigBang(Clone)", 0.5f),

        };
        }
    }
