using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMove : MonoBehaviour
{

    public short directionWayX;
    public short directionWayY;
    public float speed = 10f;

    void Update()
    {      
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DestroyWall")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DestroyWall")
        {
            Destroy(gameObject);
        }
    }
}
