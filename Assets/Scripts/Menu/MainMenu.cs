using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void GoMainMenu()
    {
        EndAnimation.playEndAnim = true;
        SceneManager.LoadScene("Menu");
    }
}
