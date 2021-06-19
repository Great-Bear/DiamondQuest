using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMoveUI : MonoBehaviour
{
    public void Right()
    {
        Move.Amove = 1;
        print(Move.Amove + "Move");
    }
    public void Left()
    {
        Move.Amove = 2;
        print(Move.Amove + "Move");
    }
    public void Jump()
    {
        Move.CanJump = true;
    }
    public void NoWay()
    {
        Move.Amove = 0;
    }  
}
