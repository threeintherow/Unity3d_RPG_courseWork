using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataClass dataClass = new DataClass();
        DataClass.Hero wizard = new DataClass.Hero(1);
        DataClass.Hero warrior = new DataClass.Hero(2);
        DataClass.Hero thief = new DataClass.Hero(3);
    }
}
