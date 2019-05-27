using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsScript : MonoBehaviour
{
    public Text classType1;
    public Text classType2;
    public Text classType3;
    
    public Text damage1;
    public Text damage2;
    public Text damage3;
    
    public Text hp1;
    public Text hp2;
    public Text hp3;
    public Text exp1;
    public Text exp2;
    public Text exp3;
    public Text mind1;
    public Text mind2;
    public Text mind3;
    public Text force1;
    public Text force2;
    public Text force3;
    public Text agility1;
    public Text agility2;
    public Text agility3;
    public Text luck1;
    public Text luck2;
    public Text luck3;
    public Text speed1;
    public Text speed2;
    public Text speed3;

    public Slider hpSlider1;
    public Slider hpSlider2;
    public Slider hpSlider3;
    public Slider expSlider1;
    public Slider expSlider2;
    public Slider expSlider3;

    public void Start()
    {
        classType1.text = GetClass(DataInteraction.GetHero(1).GetСlass());
        classType2.text = GetClass(DataInteraction.GetHero(2).GetСlass());
        classType3.text = GetClass(DataInteraction.GetHero(3).GetСlass());

        damage1.text = DataInteraction.GetHero(1).GetDamage().ToString();
        damage2.text = DataInteraction.GetHero(2).GetDamage().ToString();
        damage3.text = DataInteraction.GetHero(3).GetDamage().ToString();
        
        mind1.text = DataInteraction.GetHero(1).GetCharacteristics().GetMind().ToString();
        mind2.text = DataInteraction.GetHero(2).GetCharacteristics().GetMind().ToString();       
        mind3.text = DataInteraction.GetHero(3).GetCharacteristics().GetMind().ToString();
        force1.text = DataInteraction.GetHero(1).GetCharacteristics().GetForce().ToString();
        force2.text = DataInteraction.GetHero(2).GetCharacteristics().GetForce().ToString();
        force3.text = DataInteraction.GetHero(3).GetCharacteristics().GetForce().ToString();
        agility1.text = DataInteraction.GetHero(1).GetCharacteristics().GetAgility().ToString();
        agility2.text = DataInteraction.GetHero(2).GetCharacteristics().GetAgility().ToString();
        agility3.text = DataInteraction.GetHero(3).GetCharacteristics().GetAgility().ToString();
        luck1.text = DataInteraction.GetHero(1).GetCharacteristics().GetLuck().ToString();
        luck2.text = DataInteraction.GetHero(2).GetCharacteristics().GetLuck().ToString();
        luck3.text = DataInteraction.GetHero(3).GetCharacteristics().GetLuck().ToString();
        speed1.text = DataInteraction.GetHero(1).GetCharacteristics().GetSpeed().ToString();
        speed2.text = DataInteraction.GetHero(2).GetCharacteristics().GetSpeed().ToString();
        speed3.text = DataInteraction.GetHero(3).GetCharacteristics().GetSpeed().ToString();        
    }

    private string GetClass(int index)
    {
        switch (index)
        {
            case 1:
                return "Воин";
            break;
            
            case 2:
                return "Вор";
            break;
            
            case 3:
                return "Маг";
            break;
             
            default:
                return "Твоя мать";
            break;
        }
    }
}