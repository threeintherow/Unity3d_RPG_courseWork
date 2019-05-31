using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject monsterPanel;
    public GameInteraction gameInteraction;
    public MonsterInteraction monsterInteraction;

    public Text damage;
    public Text physicalResist;
    public Text spellResist;
    public Text health;

    public Slider healthSlider;
    public void OnMouseDown()
    {
        bool isActive = monsterPanel.activeSelf;
        
        if (gameObject.name.Equals("Slime_Green"))
        {
            if (!isActive)
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = monsterInteraction.enemy1.maxHp;
                healthSlider.value = monsterInteraction.enemy1.health;               
                health.text = monsterInteraction.enemy1.health.ToString() + "/" + monsterInteraction.enemy1.maxHp.ToString();
                damage.text = monsterInteraction.enemy1.damage.ToString();
                physicalResist.text = monsterInteraction.enemy1.physicalResist.ToString();
                spellResist.text = monsterInteraction.enemy1.magicResist.ToString();
            }
            else
            {
                healthSlider.maxValue = monsterInteraction.enemy1.maxHp;
                healthSlider.value = monsterInteraction.enemy1.health;
                health.text = monsterInteraction.enemy1.health.ToString() + "/" + monsterInteraction.enemy1.maxHp.ToString();
                damage.text = monsterInteraction.enemy1.damage.ToString();
                physicalResist.text = monsterInteraction.enemy1.physicalResist.ToString();
                spellResist.text = monsterInteraction.enemy1.magicResist.ToString();
    
            }       
        }
        else if (gameObject.name.Equals("Bat_Green"))
        {
            if (!isActive)
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = monsterInteraction.enemy2.maxHp;
                healthSlider.value = monsterInteraction.enemy2.health;               
                health.text = monsterInteraction.enemy2.health.ToString() + "/" + monsterInteraction.enemy2.maxHp.ToString();
                damage.text = monsterInteraction.enemy2.damage.ToString();
                physicalResist.text = monsterInteraction.enemy2.physicalResist.ToString();
                spellResist.text = monsterInteraction.enemy2.magicResist.ToString();
            }
            else
            {
                healthSlider.maxValue = monsterInteraction.enemy2.maxHp;
                healthSlider.value = monsterInteraction.enemy2.health;
                health.text = monsterInteraction.enemy2.health.ToString() + "/" + monsterInteraction.enemy2.maxHp.ToString();
                damage.text = monsterInteraction.enemy2.damage.ToString();
                physicalResist.text = monsterInteraction.enemy2.physicalResist.ToString();
                spellResist.text = monsterInteraction.enemy2.magicResist.ToString();
    
            }       
        }
        else if (gameObject.name.Equals("Ghost_Violet"))
        {
            
            if (isActive)
            {
                healthSlider.maxValue = monsterInteraction.enemy3.maxHp;
                healthSlider.value = monsterInteraction.enemy3.health;
                health.text = monsterInteraction.enemy3.health.ToString() + "/" + monsterInteraction.enemy3.maxHp.ToString();
                damage.text = monsterInteraction.enemy3.damage.ToString();
                physicalResist.text = monsterInteraction.enemy3.physicalResist.ToString();
                spellResist.text = monsterInteraction.enemy3.magicResist.ToString();
                
            }
            else
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = monsterInteraction.enemy3.maxHp;
                healthSlider.value = monsterInteraction.enemy3.health;
                health.text = monsterInteraction.enemy3.health.ToString() + "/" + monsterInteraction.enemy3.maxHp.ToString();                
                damage.text = monsterInteraction.enemy3.damage.ToString();
                physicalResist.text = monsterInteraction.enemy3.physicalResist.ToString();
                spellResist.text = monsterInteraction.enemy3.magicResist.ToString();  
            }                
        }        
    }
}
