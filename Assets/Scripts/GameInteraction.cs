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
        DataClass.Hero wizard = new DataClass.Hero(1);
        DataClass.Hero warrior = new DataClass.Hero(2);
        DataClass.Hero thief = new DataClass.Hero(3);
    }
}
