using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Splitscreen : MonoBehaviour
{
    public Camera cam;
    public Camera cam1;
    public Camera cam2;

    public GameObject player;
    public GameObject player1;
    public GameObject player2;





    private bool isHSplit;
    private bool isHSplit1;
    private bool isHSplit2;



    void Start()
    {
        
    }

    void Update()
    {

    }
    public void SplitScreen()
    {
        isHSplit = !isHSplit;
        SetSplitScreen();
    }

    public void SetSplitScreen()
    {
        if (isHSplit)
        {
            cam.rect = new Rect(0f, .5f, 1f, .5f);
            cam1.rect = new Rect(0f, 0f, 1f, .5f);

            player.SetActive(true);
            player1.SetActive(false);
            player2.SetActive(false);
        }
        else
        {
            cam.rect = new Rect(0f, 0f, 1f, 1f);
            player.SetActive(false);
            player1.SetActive(false);
        }
    }

    public void SplitScreen1()
    {
        isHSplit1 = !isHSplit1;
        SetSplitScreen1();
    }

    public void SetSplitScreen1()
    {
        if (isHSplit1)
        {
            cam.rect = new Rect(0f, .5f, .5f, .5f);
            cam1.rect = new Rect(.5f, .5f, .5f, .5f);
            player.SetActive(true);
            player1.SetActive(true);
            player2.SetActive(false);
        }
        else
        {
            cam.rect = new Rect(0f, 0f, 1f, 1f);
            player.SetActive(false);
            player1.SetActive(false);

        }
    }

    public void SplitScreen2()
    {
        isHSplit2 = !isHSplit2;
        SetSplitScreen2();
    }

    public void SetSplitScreen2()
    {
        if (isHSplit2)
        {
            cam.rect = new Rect(0f, .5f, .5f, .5f);
            cam1.rect = new Rect(.5f, .5f, .5f, .5f);
            cam2.rect = new Rect(0f, 0f, .5f, .5f);
            player.SetActive(true);
            player1.SetActive(true);
            player2.SetActive(true);
        }
        else
        {
            cam.rect = new Rect(0f, 0f, 1f, 1f);
            player.SetActive(false);
            player1.SetActive(false);
            player2.SetActive(false);
        }
    }
}
