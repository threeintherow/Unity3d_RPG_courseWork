using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInteraction : MonoBehaviour
{
    DataClass dataClass = new DataClass();

    public static int currentScene = 0;

    private DataClass.Hero _hero_1;

    private DataClass.Hero _hero_2;

    private DataClass.Hero _hero_3;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = 0;
    }

    public void FirstCharacterCreation()
    {
        _hero_1 = new DataClass.Hero(1);
        _hero_2 = new DataClass.Hero(2);
        _hero_3 = new DataClass.Hero(3);
    }

    public DataClass.Hero getHero(int index)
    {
        switch (index)
        {
            case 1:
                return _hero_1;
            case 2:
                return _hero_2;
            default:
                return _hero_3;
        }
    }
        
    
}
