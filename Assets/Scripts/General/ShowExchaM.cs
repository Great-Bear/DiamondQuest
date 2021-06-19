using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowExchaM : MonoBehaviour
{
   public GameObject cloud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            cloud.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        cloud.SetActive(false);
    }

}
