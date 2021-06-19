using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBut : MonoBehaviour
{
    public static bool Pause = false;
    public GameObject Menu;
    public void ShowMenu()
    {
        GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
        Pause = true;
        Menu.SetActive(true);
    }
}
