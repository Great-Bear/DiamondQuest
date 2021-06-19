using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesBut : MonoBehaviour
{
    public GameObject RulesMenu;

    public void ShowRulesMenu()
    {
        GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
        RulesMenu.SetActive(true);
    }
}
