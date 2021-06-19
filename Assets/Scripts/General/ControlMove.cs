using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMove : MonoBehaviour
{
    public static Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Move.Amove == 1 || Move.Amove == 2)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Move.CanJump)
        {

            anim.SetTrigger("Jump");
        }
    }
}

