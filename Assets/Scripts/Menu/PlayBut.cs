using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBut : MonoBehaviour
{
    public GameObject LevelMenu;

    public void ShowLevelMenu()
    {
        GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
        LevelMenu.SetActive(true);
    }

}
