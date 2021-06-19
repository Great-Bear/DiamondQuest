using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string NameScene;

    public void LoadNextScene()
    {
        MenuBut.Pause = false;
        SceneManager.LoadScene(NameScene);
    }
}
