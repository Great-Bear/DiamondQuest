using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpedDoor : MonoBehaviour
{
    public GameObject Door;
    public GameObject Collider;
    public GameObject Message;
    BoxCollider2D col;

    private void Start()
    {
        col = Collider.GetComponent<BoxCollider2D>();
    }

    public void PayDoor()
    {
        if (ScoreAllCoins.ScoreDiamont >= 2)
        {
            col.enabled = false;
            ScoreAllCoins.ScoreDiamont -= 2;
            Destroy(Door);
            Destroy(Message);
         }
    }
 

    //private void OnMouseDown()
    //{
    //    DontJump = false;
    //    if (ScoreAllCoins.ScoreDiamont >= 2)
    //    {
    //        col.enabled = false;
    //        ScoreAllCoins.ScoreDiamont -= 2;
    //        Destroy(Door);
    //    }
    //}

}
