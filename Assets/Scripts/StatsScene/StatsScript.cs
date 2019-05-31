using Data;
using UnityEngine;
using UnityEngine.UI;

namespace StatsScene
{
    public class StatsScript : MonoBehaviour
    {
        public Text classType1;
        public Text classType2;
        public Text classType3;
    
        public Text damage1;
        public Text damage2;
        public Text damage3;
        
        public Text physicalResist1;
        public Text physicalResist2;
        public Text physicalResist3;
        public Text spellResist1;
        public Text spellResist2;
        public Text spellResist3;
        
    
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
            hp1.text = DataInteraction.GetHero(1).health.ToString() + "/" + DataInteraction.GetHero(1).healthMax.ToString();
            hpSlider1.value = DataInteraction.GetHero(1).health;
            hpSlider1.maxValue = DataInteraction.GetHero(1).healthMax;
            
            hp2.text = DataInteraction.GetHero(2).health.ToString() + "/" + DataInteraction.GetHero(2).healthMax.ToString();
            hpSlider2.value = DataInteraction.GetHero(2).health;
            hpSlider2.maxValue = DataInteraction.GetHero(2).healthMax;
            
            hp3.text = DataInteraction.GetHero(3).health.ToString() + "/" + DataInteraction.GetHero(3).healthMax.ToString();
            hpSlider3.value = DataInteraction.GetHero(3).health;          
            hpSlider3.maxValue = DataInteraction.GetHero(3).healthMax;        
            
            exp1.text = DataInteraction.GetHero(1).experience.ToString() + "/" + DataInteraction.GetHero(1).experienceMax.ToString();
            expSlider1.value = DataInteraction.GetHero(1).experience;
            expSlider1.maxValue = DataInteraction.GetHero(1).experienceMax;
            
            exp2.text = DataInteraction.GetHero(2).experience.ToString() + "/" + DataInteraction.GetHero(2).experienceMax.ToString();
            expSlider2.value = DataInteraction.GetHero(2).experience;
            expSlider2.maxValue = DataInteraction.GetHero(2).experienceMax;
            
            exp3.text = DataInteraction.GetHero(3).experience.ToString() + "/" + DataInteraction.GetHero(3).experienceMax.ToString();
            expSlider3.value = DataInteraction.GetHero(3).experience;          
            expSlider3.maxValue = DataInteraction.GetHero(3).experienceMax;

            physicalResist1.text = DataInteraction.GetHero(1).physicalResist.ToString();
            spellResist1.text = DataInteraction.GetHero(1).magicResist.ToString();
            
            physicalResist2.text = DataInteraction.GetHero(2).physicalResist.ToString();
            spellResist2.text = DataInteraction.GetHero(2).magicResist.ToString();
            
            physicalResist3.text = DataInteraction.GetHero(3).physicalResist.ToString();
            spellResist3.text = DataInteraction.GetHero(3).magicResist.ToString();
            
            classType1.text = GetClass(DataInteraction.GetHero(1).classOfHero);
            classType2.text = GetClass(DataInteraction.GetHero(2).classOfHero);
            classType3.text = GetClass(DataInteraction.GetHero(3).classOfHero);

            damage1.text = DataInteraction.GetHero(1).damage.ToString();
            damage2.text = DataInteraction.GetHero(2).damage.ToString();
            damage3.text = DataInteraction.GetHero(3).damage.ToString();
        
            mind1.text = DataInteraction.GetHero(1).mind.ToString();
            mind2.text = DataInteraction.GetHero(2).mind.ToString();       
            mind3.text = DataInteraction.GetHero(3).mind.ToString();
            force1.text = DataInteraction.GetHero(1).force.ToString();
            force2.text = DataInteraction.GetHero(2).force.ToString();
            force3.text = DataInteraction.GetHero(3).force.ToString();
            agility1.text = DataInteraction.GetHero(1).agility.ToString();
            agility2.text = DataInteraction.GetHero(2).agility.ToString();
            agility3.text = DataInteraction.GetHero(3).agility.ToString();
            luck1.text = DataInteraction.GetHero(1).luck.ToString();
            luck2.text = DataInteraction.GetHero(2).luck.ToString();
            luck3.text = DataInteraction.GetHero(3).luck.ToString();
            speed1.text = DataInteraction.GetHero(1).speed.ToString();
            speed2.text = DataInteraction.GetHero(2).speed.ToString();
            speed3.text = DataInteraction.GetHero(3).speed.ToString();        
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
}