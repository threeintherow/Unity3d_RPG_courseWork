using Data;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace StatsScene
{
    public class StatsScript : MonoBehaviour
    {
        public GameInteraction gameInteraction;
        
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

        public Text lvl1;
        public Text lvl2;
        public Text lvl3;
        
    
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
            EnableStats();      
        }

        public void EnableStats()
        {
            hp1.text = gameInteraction.hero1.health.ToString() + "/" + gameInteraction.hero1.healthMax.ToString();
            hpSlider1.value = gameInteraction.hero1.health;
            hpSlider1.maxValue = gameInteraction.hero1.healthMax;
            
            hp2.text = gameInteraction.hero2.health.ToString() + "/" + gameInteraction.hero2.healthMax.ToString();
            hpSlider2.value = gameInteraction.hero2.health;
            hpSlider2.maxValue = gameInteraction.hero2.healthMax;
            
            hp3.text = gameInteraction.hero3.health.ToString() + "/" + gameInteraction.hero3.healthMax.ToString();
            hpSlider3.value = gameInteraction.hero3.health;          
            hpSlider3.maxValue = gameInteraction.hero3.healthMax;        
            
            exp1.text = gameInteraction.hero1.experience.ToString() + "/" + gameInteraction.hero1.experienceMax.ToString();
            expSlider1.value = gameInteraction.hero1.experience;
            expSlider1.maxValue = gameInteraction.hero1.experienceMax;
            
            exp2.text = gameInteraction.hero2.experience.ToString() + "/" + gameInteraction.hero2.experienceMax.ToString();
            expSlider2.value = gameInteraction.hero2.experience;
            expSlider2.maxValue = gameInteraction.hero2.experienceMax;
            
            exp3.text = gameInteraction.hero3.experience.ToString() + "/" + gameInteraction.hero3.experienceMax.ToString();
            expSlider3.value = gameInteraction.hero3.experience;          
            expSlider3.maxValue = gameInteraction.hero3.experienceMax;

            physicalResist1.text = gameInteraction.hero1.physicalResist.ToString();
            spellResist1.text = gameInteraction.hero1.magicResist.ToString();
            
            physicalResist2.text = gameInteraction.hero2.physicalResist.ToString();
            spellResist2.text = gameInteraction.hero2.magicResist.ToString();
            
            physicalResist3.text = gameInteraction.hero3.physicalResist.ToString();
            spellResist3.text = gameInteraction.hero3.magicResist.ToString();

            lvl1.text = gameInteraction.hero1.level.ToString();
            lvl2.text = gameInteraction.hero2.level.ToString();
            lvl3.text = gameInteraction.hero3.level.ToString();
            
            classType1.text = GetClass(gameInteraction.hero1.classOfHero);
            classType2.text = GetClass(gameInteraction.hero2.classOfHero);
            classType3.text = GetClass(gameInteraction.hero3.classOfHero);

            damage1.text = gameInteraction.hero1.damage.ToString();
            damage2.text = gameInteraction.hero2.damage.ToString();
            damage3.text = gameInteraction.hero3.damage.ToString();
        
            mind1.text = gameInteraction.hero1.mind.ToString();
            mind2.text = gameInteraction.hero2.mind.ToString();       
            mind3.text = gameInteraction.hero3.mind.ToString();
            force1.text = gameInteraction.hero1.force.ToString();
            force2.text = gameInteraction.hero2.force.ToString();
            force3.text = gameInteraction.hero3.force.ToString();
            agility1.text = gameInteraction.hero1.agility.ToString();
            agility2.text = gameInteraction.hero2.agility.ToString();
            agility3.text = gameInteraction.hero3.agility.ToString();
            luck1.text = gameInteraction.hero1.luck.ToString();
            luck2.text = gameInteraction.hero2.luck.ToString();
            luck3.text = gameInteraction.hero3.luck.ToString();
            speed1.text = gameInteraction.hero1.speed.ToString();
            speed2.text = gameInteraction.hero2.speed.ToString();
            speed3.text = gameInteraction.hero3.speed.ToString(); 
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