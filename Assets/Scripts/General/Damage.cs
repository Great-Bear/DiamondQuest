using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public AudioClip _clip;
    lineHearth lineHearth;

    private void Start()
    {
        lineHearth = GameObject.Find("Main Camera").GetComponent<lineHearth>();
    }
    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.name == "Player")
        {
            StartCoroutine(MinusHearth());
        }
    }
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.name == "Player")
        {
            if (tag == "Lava")
            {
                StartCoroutine(MinusHearth());
            }
            else
            {
                if (lineHearth.FullHeath != 0)
                {
                    GameObject.Find("Shell").GetComponent<AudioSource>().Play();
                }
                RemoveOneHearth();
                if (tag == "Shell")
                {
                    Destroy(gameObject);
                }
            }
        }
    }
    private void OnCollisionExit2D(Collision2D Other)
    {
        StopAllCoroutines();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopAllCoroutines();
    }
    public IEnumerator MinusHearth()
    {
        while (true)
        {
            if (lineHearth.FullHeath != 0)
            {
                GetComponent<AudioSource>().PlayOneShot(_clip);
            }
            RemoveOneHearth();
            yield return new WaitForSeconds(5f);
        }
    }
    void RemoveOneHearth()
    {
        if (lineHearth.FullHeath == 0 || MenuBut.Pause == true)
        {
            return;
        }
        lineHearth.FullHeath--;
        lineHearth.RedrawLineHearth();
    }
}
