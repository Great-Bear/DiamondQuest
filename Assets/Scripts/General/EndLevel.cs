using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
 public GameObject Player;
 public GameObject WinMenu;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            MenuBut.Pause = true;
            WinMenu.SetActive(true);
        }
    }
}
