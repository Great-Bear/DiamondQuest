using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lineHearth : MonoBehaviour
{

    public static short coutnHeart = 5;
    public short[] array = new short[5];
    public GameObject[] Garray = new GameObject[5];
    public static short FullHeath = 5;

    public Sprite img;
    public Sprite imgfull;

    void Start()
    {
        for (int i = 0; i < coutnHeart; i++)
        {
            if (i < FullHeath)
            {
                array[i] = 1;
            }
        }
        RedrawLineHearth();
    }
    public void RedrawLineHearth()
    {
        if (FullHeath == 0)
        {
            MenuBut.Pause = true;
            LossMenu.ShowMenu();
        }

        for (int i = 0; i < coutnHeart; i++)
        {
            if (i >= FullHeath)
            {
                Garray[i].GetComponent<Image>().sprite = img;
            }
            else
            {
                Garray[i].GetComponent<Image>().sprite = imgfull;
            }
        }      
    }
}