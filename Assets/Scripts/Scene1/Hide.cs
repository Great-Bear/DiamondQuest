using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public class HideGreeting : MonoBehaviour
{
    public GameObject table;
   public void Hide()
    {
        Destroy(table);
    }
    
}
