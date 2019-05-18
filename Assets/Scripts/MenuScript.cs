using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject PlayButton;

    public GameObject SettingsButton;

    public GameObject ExitButton;

    public GameObject ButtonMenu;
    public GameObject ButtonMenu2;

    /*private void Start()
    {
        ButtonMenu2.SetActive(false);
    }
*/

    public void play()
    {
        ButtonMenu.SetActive(false);
        ButtonMenu2.SetActive(true);
    }

    public void back()
    {
        ButtonMenu.SetActive(true);
        ButtonMenu2.SetActive(false);
    }
}
