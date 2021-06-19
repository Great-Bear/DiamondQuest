using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{

   public AudioClip[] arrClip = new AudioClip[4];
    short clipNumber = 0;

    void Update()
    {
        if (GetComponent<AudioSource>().isPlaying == false && AudioListener.volume == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(arrClip[clipNumber]);
            clipNumber++;
            if(clipNumber == 4)
            {
                clipNumber = 0;
            }
        }
    }
}
