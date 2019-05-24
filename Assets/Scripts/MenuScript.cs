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
    public GameObject ButtonMenu3;

    private void Start()
    {
        ButtonMenu2.SetActive(false);
        ButtonMenu3.SetActive(false);
    }

    public void Settings()    //Включение настроек
    {
        ButtonMenu.SetActive(false);
        ButtonMenu2.SetActive(true);
    }

    public void BackFromSettings()    //Выход из настроек
    {
        ButtonMenu.SetActive(true);
        ButtonMenu2.SetActive(false);
    }

    public void Choice()    //Продолжить или начать новую игру
    {
        ButtonMenu.SetActive(false);
        ButtonMenu3.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
