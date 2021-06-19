using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDiamont : MonoBehaviour
{
    public AudioClip _clip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            ScoreAllCoins.ScoreDiamont++;
            GetComponent<AudioSource>().PlayOneShot(_clip);
            Invoke("OnDestroy", _clip.length);
        }
    }
    private void OnDestroy()
    {
        Destroy(gameObject);
    }
}
