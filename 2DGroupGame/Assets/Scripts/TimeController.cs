using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public string levelToLoad;
    float currentTime = 0f;
    float startingTime = 15f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    [System.Obsolete]
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("f2");
        if (currentTime <= 0)
        {
            currentTime = 0;
            Application.LoadLevel(levelToLoad);
        }
    }
}
