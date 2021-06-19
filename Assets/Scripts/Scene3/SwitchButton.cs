using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    public Sprite ImageON;
    public Sprite ImageOff;
    private short countPressed = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Box")
        {
            countPressed++;
            gameObject.GetComponent<SpriteRenderer>().sprite = ImageOff;
            GameObject.Find("PressWall (1)").GetComponent<Animator>().speed = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Box")
        {
            countPressed--;
            if (countPressed == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = ImageON;
                GameObject.Find("PressWall (1)").GetComponent<Animator>().speed = 1;
            }
        }
    }
}
