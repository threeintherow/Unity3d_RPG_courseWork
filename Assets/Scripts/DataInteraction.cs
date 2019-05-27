using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataInteraction
{

    private static bool _music = true;
    
    private static DataClass dataClass = new DataClass();

    public static int lastSaved = 0;

    public static DataClass.Hero hero1 = new DataClass.Hero(1);

    public static DataClass.Hero hero2 = new DataClass.Hero(2);

    public static DataClass.Hero hero3 = new DataClass.Hero(3);
    
//    public static void FirstCharacterCreation()
//    {
//        hero1 = new DataClass.Hero(1);
//        hero2 = new DataClass.Hero(2);
//        hero3 = new DataClass.Hero(3);
//    }

    public static DataClass.Hero GetHero(int index)
    {
        switch (index)
        {
            case 1:
                return hero1;
            case 2:
                return hero2;
            case 3:
                return hero3;
            default:
                return null;
        }
    }

    public static DataClass.Monster CreateNewMonster()
    {
        return new DataClass.Monster();
    }

    public static void TurnOffMusic()
    {
        _music = false;
    }

    public static void TurnOnMusic()
    {
        _music = true;
    }

    public static void setHeroDataAfterLoad(DataClass.Hero hero, int index)
    {
        switch(index)
        {
            case 1:
                hero1 = hero;
                break;
            case 2:
                hero2 = hero;
                break;
            case 3:
                hero3 = hero;
                break;
        }
    }
}
