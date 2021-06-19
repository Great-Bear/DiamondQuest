using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMassBox : MonoBehaviour
{
    public GameObject obj;
    Rigidbody2D rb;
    private void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            StartCoroutine(AddMass());
        }
    }
    private void OnCollisionExit2D(Collision2D Other)
    {
        StopAllCoroutines();
    }
    
    IEnumerator AddMass()
    {
        while (true)
        {
            rb.mass += 0.5f;
            yield return new WaitForSeconds(2f);
        }
    }


}
