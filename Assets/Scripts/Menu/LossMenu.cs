using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossMenu : MonoBehaviour
{
    public GameObject Menu;
    private static GameObject S_Menu;
    private void Start()
    {
        S_Menu = Menu;
    }
    public static void ShowMenu()
    {
        S_Menu.SetActive(true);
    }
}
