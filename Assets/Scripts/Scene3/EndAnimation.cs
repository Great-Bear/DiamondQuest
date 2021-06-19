using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimation : MonoBehaviour
{
    public static Animator anim;
    static public bool playEndAnim = true;
    public GameObject Player;
    public GameObject CubTop;
    public GameObject CubButton;
    public GameObject UI;
    public GameObject WinMenu;
    public GameObject ShipAnim;
    public GameObject ShipMap;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(playEndAnim == true)
        {
            Move.Amove = 0;
            GameObject.Find("Player").SetActive(false);
            UI.SetActive(false);
            Player.SetActive(true);
            CubTop.SetActive(true);
            CubButton.SetActive(true);
            ShipAnim.SetActive(true);
            ShipMap.SetActive(false);
            GameObject.Find("Main Camera").GetComponent<CameraControl>().target = null;
            playEndAnim = false;
            anim = GetComponent<Animator>();
            anim.Play("EndVideo");
            StartCoroutine("ShowEndMenu");
        }      
    }
        IEnumerator ShowEndMenu()
        {
            yield return new WaitForSeconds(3.7f);
            WinMenu.SetActive(true);
        }
}
