using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float time = 2.0f;
    void Update()
    {
         transform.Rotate(0, 0, -time);
    }
}

