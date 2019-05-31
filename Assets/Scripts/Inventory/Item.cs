using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int type;    //1 - шлем. 2 - ноги. 3 - руки. 4 - руки. 5 - кольца. 6 - пояс. 7 - броня
    public int ID;
    public int valueDamage;
    public int valueMagicResist;
    public int valuePhysicResist;
    public string pathSprite;
    public string pathPrefub;
}
