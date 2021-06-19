using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBut : MonoBehaviour
{
    public GameObject Panel;
    public void ClosePanel()
    {
        GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
    }
}
