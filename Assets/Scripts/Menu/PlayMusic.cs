using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMusic : MonoBehaviour
{
    public Sprite Play;
    public Sprite NotPlay;

    private void Start()
    {
        OnlyChangeSprite();
    }
    public void ChangeSprite()
    {
        AudioListener.volume = 1 - AudioListener.volume;
        OnlyChangeSprite();
    }
    private void OnlyChangeSprite()
    {
        GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
        if (AudioListener.volume == 1)
        {
            GetComponent<Image>().sprite = Play;
        }
        else
        {
            GetComponent<Image>().sprite = NotPlay;
        }
    }
}
