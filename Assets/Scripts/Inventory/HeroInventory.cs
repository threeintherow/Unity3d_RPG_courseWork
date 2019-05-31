using System.Collections.Generic;
using Characters;
using UnityEngine;

namespace Inventory
{
    public class HeroInventory : MonoBehaviour
    {
        public Hero hero;

        public Item helmet;
        public Item armor;
        public Item sword2;
        public Item sword1;
        public Item ring1;
        public Item ring2;
        public Item ring3;
        public Item shoes;
        
        public List<Item> onHero;
        public GameObject panel;
        public List<Drag> drags;
        public List<Item> items = new List<Item>();

        public void InventoryActive()
        {
            print(Input.touchCount);
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
                drag.RemoveSell();
            }
            panel.SetActive(false);
            
        }

        public void InventoryEnable()
        {
            panel.SetActive(true);
            foreach(var t in drags)
            {
                t.RemoveSell();
            }

            for(int i = 0; i < items.Count; i++)
            {
                drags[i].item = items[i];
                drags[i].image.sprite = Resources.Load<Sprite>(items[i].pathSprite);
                drags[i].ownerOfItem = "hero";

            }
        }

        public void UseItem(Drag drag)
        {
            print("use");
        }
    }
}
