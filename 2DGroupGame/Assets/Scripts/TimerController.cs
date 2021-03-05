using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text countdownText;

    private TimeSpan timePlaying;
    private bool timeGoing;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        countdownText.text = "Time 00:00.00";
        timeGoing = false;
    }

    public void BeginTimer()
    {
        timeGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timeGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timeGoing)
        {
            elapsedTime -= Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            countdownText.text = timePlayingStr;

            yield return null;
        }
    }
}
