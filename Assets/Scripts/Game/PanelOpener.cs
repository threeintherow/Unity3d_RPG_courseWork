using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject monsterPanel;

    public void OnMouseDown()
    {
        if (monsterPanel != null)
        {
            bool isActive = monsterPanel.activeSelf;
            monsterPanel.SetActive(!isActive);
        }
    }
}
