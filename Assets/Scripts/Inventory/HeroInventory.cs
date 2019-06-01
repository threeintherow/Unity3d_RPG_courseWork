using System.Collections.Generic;
using Characters;
using Data;
using Game;
using UnityEngine;

namespace Inventory
{
    public class HeroInventory : MonoBehaviour
    {
        public GameInteraction gameInteraction;
        public Hero hero1;
        public Hero hero2;
        public Hero hero3;
        public Hero currentHero;
        
        public Item helmet;
        public Item armor;
        public Item belt;
        public Item sword2;
        public Item sword1;
        public Item ring1;
        public Item ring2;
        public Item ring3;
        public Item shoes;
        
        public List<Item> onHero;
        public GameObject panel;
        public List<Drag> drags;
        public List<Item> items;

        public GameObject cell;
        public Transform cellParent;
        
        private void Awake()
        {
            onHero = new List<Item>();
            items = new List<Item>();
            currentHero = gameObject.GetComponent<Hero>();
            currentHero = gameInteraction.hero1;
            items = currentHero.listItems;
        }

        public void InventoryActive()
        {
            if(panel.activeSelf)
            {
                InventoryDisable();
            }
            else
            {
                InventoryEnable();
            }
        }

        public void InventoryDisable()
        {
            foreach(var drag in drags)
            {
                Destroy(drag.gameObject);
            }
            drags.Clear();
            panel.SetActive(false);
            gameInteraction.camera.transform.position = new Vector3(-8.183913f, 8.72238f, -29.79492f);
            
        }

        public void InventoryEnable()
        {
            panel.SetActive(true);
            foreach(var drag in drags)
            {
                Destroy(drag.gameObject);
            }
            drags.Clear();

            for(int i = 0; i < items.Count; i++)
            {
                GameObject newCell = Instantiate(cell);
                newCell.transform.SetParent(cellParent, false);
                drags.Add(newCell.GetComponent<Drag>());
            }

            items = currentHero.listItems;
            for(int i = 0; i < items.Count; i++)
            {
                drags[i].item = items[i];
                drags[i].image.sprite = Resources.Load<Sprite>(items[i].pathSprite);
                drags[i].ownerOfItem = currentHero.GetKey();
                drags[i].heroInventory = this;
            }

            for(int i = drags.Count - 1; i > 0; i--)
            {
                if(drags[i].ownerOfItem == "")
                {
                    Destroy(drags[i].gameObject);
                    drags.RemoveAt(i);
                }
            }
        }

        public void UseItem(Drag drag)
        {
            print("use");
        }

        public void SetHero1()
        {
            if(currentHero.GetKey() == "Hero1")
                return;
            else
            {
                this.currentHero = DataInteraction.hero1;
                InventoryEnable();
            }
        }
        public void SetHero2()
        {
            if(currentHero.GetKey() == "Hero2")
                return;
            else
            {
                this.currentHero = DataInteraction.hero2;
                InventoryEnable();
            }
            
        }
        public void SetHero3()
        {
            if(currentHero.GetKey() == "Hero3")
                return;
            else
            {
                this.currentHero = DataInteraction.hero3;
                InventoryEnable();
            }
        }
    }
}
