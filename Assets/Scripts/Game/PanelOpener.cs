using System.Collections;
using System.Collections.Generic;
using Data;
using Game;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject monsterPanel;
    public GameObject winPanel;
    public GameInteraction gameInteraction;
    public MonsterBand monsterBand;

    public Text damage;
    public Text physicalResist;
    public Text spellResist;
    public Text health;
    public Text expGained;

    public Slider healthSlider;
    public void OnMouseDown()
    {
            Upt();
    }

    public void Upt()
    {
        bool isActive = monsterPanel.activeSelf;
        
        if (gameObject.name.Equals("Slime_Green") || gameObject.name.Equals("Rabbit_Cyan"))
        {
            if (!isActive)
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = monsterBand.monster1.maxHp;
                healthSlider.value = monsterBand.monster1.health;               
                health.text = monsterBand.monster1.health.ToString() + "/" + monsterBand.monster1.maxHp.ToString();
                damage.text = monsterBand.monster1.damage.ToString();
                physicalResist.text = monsterBand.monster1.physicalResist.ToString();
                spellResist.text = monsterBand.monster1.magicResist.ToString();
            }
            else
            {
                healthSlider.maxValue = monsterBand.monster1.maxHp;
                healthSlider.value = monsterBand.monster1.health;
                health.text = monsterBand.monster1.health.ToString() + "/" + monsterBand.monster1.maxHp.ToString();
                damage.text = monsterBand.monster1.damage.ToString();
                physicalResist.text = monsterBand.monster1.physicalResist.ToString();
                spellResist.text = monsterBand.monster1.magicResist.ToString();
    
            }       
        }
        else if (gameObject.name.Equals("Bat_Green") || gameObject.name.Equals("Rabbit_Red"))
        {
            if (!isActive)
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = monsterBand.monster2.maxHp;
                healthSlider.value = monsterBand.monster2.health;               
                health.text = monsterBand.monster2.health.ToString() + "/" + monsterBand.monster2.maxHp.ToString();
                damage.text = monsterBand.monster2.damage.ToString();
                physicalResist.text = monsterBand.monster2.physicalResist.ToString();
                spellResist.text = monsterBand.monster2.magicResist.ToString();
            }
            else
            {
                healthSlider.maxValue = monsterBand.monster2.maxHp;
                healthSlider.value = monsterBand.monster2.health;
                health.text = monsterBand.monster2.health.ToString() + "/" + monsterBand.monster2.maxHp.ToString();
                damage.text = monsterBand.monster2.damage.ToString();
                physicalResist.text = monsterBand.monster2.physicalResist.ToString();
                spellResist.text = monsterBand.monster2.magicResist.ToString();
    
            }       
        }
        else if (gameObject.name.Equals("Ghost_Violet") || gameObject.name.Equals("Rabbit_Yellow"))
        {
            
            if (isActive)
            {
                healthSlider.maxValue = monsterBand.monster3.maxHp;
                healthSlider.value = monsterBand.monster3.health;
                health.text = monsterBand.monster3.health.ToString() + "/" + monsterBand.monster3.maxHp.ToString();
                damage.text = monsterBand.monster3.damage.ToString();
                physicalResist.text = monsterBand.monster3.physicalResist.ToString();
                spellResist.text = monsterBand.monster3.magicResist.ToString();
                
            }
            else
            {
                monsterPanel.SetActive(true);
                healthSlider.maxValue = monsterBand.monster3.maxHp;
                healthSlider.value = monsterBand.monster3.health;
                health.text = monsterBand.monster3.health.ToString() + "/" + monsterBand.monster3.maxHp.ToString();                
                damage.text = monsterBand.monster3.damage.ToString();
                physicalResist.text = monsterBand.monster3.physicalResist.ToString();
                spellResist.text = monsterBand.monster3.magicResist.ToString();  
            }                
        }    
    }
}
