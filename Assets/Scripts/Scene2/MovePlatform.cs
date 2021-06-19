using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    enum Way
    {
        Right = 1,
        Left = -1
    }

    public short directionWayX;
    public static float speed = 1.5f;
    private void Update()
    {
        transform.Translate(new Vector2(directionWayX, 0) * speed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ReflectionWall")
        {
            if(directionWayX == (short)Way.Right)
            {
                directionWayX = (short)Way.Left;
            }
            else
            {
                directionWayX = (short)Way.Right;
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.transform.Translate(new Vector2(directionWayX, 0) * speed * Time.deltaTime, Space.World);
        }    
    }
}
