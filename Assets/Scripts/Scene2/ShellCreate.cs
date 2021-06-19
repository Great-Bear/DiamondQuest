using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellCreate : MonoBehaviour
{
    public GameObject obj;
    public float TiltAngleZ = 90f;
    public float TimeCreate = 3f;

    void Start()
    {
        StartCoroutine("CreateShell");
    }
    IEnumerator CreateShell()
    {
        while (true)
        {
            Instantiate(obj,transform.position, Quaternion.Euler(0f, 0f, TiltAngleZ));
            yield return new WaitForSeconds(TimeCreate);
        }
    }
}
