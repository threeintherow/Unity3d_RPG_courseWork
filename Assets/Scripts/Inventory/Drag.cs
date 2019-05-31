using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Inventory
{
    public class Drag : MonoBehaviour, IPointerClickHandler
    {
        public HeroInventory heroInventory;
        public Item item;
        public string ownerOfItem;
        public Image image;
        public Sprite defaultSprite;
    
        public void OnPointerClick(PointerEventData eventData)
        {
            heroInventory.UseItem(this);
        }

        public void RemoveSell()
        {
            item = null;
            ownerOfItem = "";
            image.sprite = null;
        }
        
    }
}
