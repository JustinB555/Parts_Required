using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject RacePanel;

    public Text Lap;
    public Text Timer;
    public LapHandle lH;
    
    private int lapNumber;
    private float startTime;

    public CarLap UpdateUIForPlayer;

    void Start()
    {
        RacePanel = this.gameObject;
        startTime = Time.time;
    }

    void Update()
    {
        if (UpdateUIForPlayer == null)
            return;
        
        if(UpdateUIForPlayer.lapNumber != lapNumber)
        {
            lapNumber = UpdateUIForPlayer.lapNumber;
            Lap.text = $"Lap: {lapNumber}" + "/" + lH.maxLaps;
        }

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        if (t % 60 < 10)
            Timer.text = minutes + ":" + "0" + seconds;
        else
            Timer.text = minutes + ":" + seconds;
        
    }
}
