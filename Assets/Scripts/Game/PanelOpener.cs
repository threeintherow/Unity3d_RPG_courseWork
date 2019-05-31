using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject monsterPanel;
    public GameInteraction gameInteraction;

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
                healthSlider.maxValue = gameInteraction.enemy1.maxHp;
                healthSlider.value = gameInteraction.enemy1.health;               
                health.text = gameInteraction.enemy1.health.ToString() + "/" + gameInteraction.enemy1.maxHp.ToString();
                damage.text = gameInteraction.enemy1.damage.ToString();
                physicalResist.text = gameInteraction.enemy1.physicalResist.ToString();
                spellResist.text = gameInteraction.enemy1.magicResist.ToString();
            }
            else
            {
                healthSlider.maxValue = gameInteraction.enemy1.maxHp;
                healthSlider.value = gameInteraction.enemy1.health;
                health.text = gameInteraction.enemy1.health.ToString() + "/" + gameInteraction.enemy1.maxHp.ToString();
                damage.text = gameInteraction.enemy1.damage.ToString();
                physicalResist.text = gameInteraction.enemy1.physicalResist.ToString();
                spellResist.text = gameInteraction.enemy1.magicResist.ToString();
    
            }       
        }
        else if (gameObject.name.Equals("Bat_Green"))
        {
            if (!isActive)
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = gameInteraction.enemy2.maxHp;
                healthSlider.value = gameInteraction.enemy2.health;               
                health.text = gameInteraction.enemy2.health.ToString() + "/" + gameInteraction.enemy2.maxHp.ToString();
                damage.text = gameInteraction.enemy2.damage.ToString();
                physicalResist.text = gameInteraction.enemy2.physicalResist.ToString();
                spellResist.text = gameInteraction.enemy2.magicResist.ToString();
            }
            else
            {
                healthSlider.maxValue = gameInteraction.enemy2.maxHp;
                healthSlider.value = gameInteraction.enemy2.health;
                health.text = gameInteraction.enemy2.health.ToString() + "/" + gameInteraction.enemy2.maxHp.ToString();
                damage.text = gameInteraction.enemy2.damage.ToString();
                physicalResist.text = gameInteraction.enemy2.physicalResist.ToString();
                spellResist.text = gameInteraction.enemy2.magicResist.ToString();
    
            }       
        }
        else if (gameObject.name.Equals("Ghost_Violet"))
        {
            
            if (isActive)
            {
                healthSlider.maxValue = gameInteraction.enemy3.maxHp;
                healthSlider.value = gameInteraction.enemy3.health;
                health.text = gameInteraction.enemy3.health.ToString() + "/" + gameInteraction.enemy3.maxHp.ToString();
                damage.text = gameInteraction.enemy3.damage.ToString();
                physicalResist.text = gameInteraction.enemy3.physicalResist.ToString();
                spellResist.text = gameInteraction.enemy3.magicResist.ToString();
                
            }
            else
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = gameInteraction.enemy3.maxHp;
                healthSlider.value = gameInteraction.enemy3.health;
                health.text = gameInteraction.enemy3.health.ToString() + "/" + gameInteraction.enemy3.maxHp.ToString();                
                damage.text = gameInteraction.enemy3.damage.ToString();
                physicalResist.text = gameInteraction.enemy3.physicalResist.ToString();
                spellResist.text = gameInteraction.enemy3.magicResist.ToString();  
            }                
        }        
    }
}
