using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public Sprite DeadEnemy;
    public AudioClip Damage;
    private bool CanDamage = true;

    IEnumerator Recharge()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            CanDamage = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if( collision.gameObject.GetComponent<Move>().killEnemy == true) 
            {
                gameObject.GetComponent<Animator>().enabled = false;
                gameObject.GetComponent<AudioSource>().Play();
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 2 * transform.position, ForceMode2D.Impulse);
                gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                gameObject.GetComponent<SpriteRenderer>().sprite = DeadEnemy;
            }
            else
            {
                if(CanDamage == true)
                {
                    CanDamage = false;
                    StartCoroutine(Recharge());
                    lineHearth.FullHeath--;
                    gameObject.GetComponent<AudioSource>().PlayOneShot(Damage);
                    GameObject.Find("Main Camera").GetComponent<lineHearth>().RedrawLineHearth();
                }              
            }           
        }
    }
}
