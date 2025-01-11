using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] logo;
    public GameObject[] menus;

    public void Toggle(GameObject target)
    {
        if (target != null)
        {
            target.SetActive(!target.activeInHierarchy);
        }
        if (logo != null)
        {
            logo[0].SetActive(!logo[0].activeInHierarchy);
        }
    }


    public void Settings(GameObject sessions)
    {
        menus[0].SetActive(false);
        sessions.SetActive(true);
    }

    public void SettingsBack(GameObject sessions)
    {
        sessions.SetActive(false);
        menus[0].SetActive(true);
    }

    public void SettingsNext(GameObject sessions)
    {
        sessions.SetActive(false);
        menus[0].SetActive(true);
    }
}

