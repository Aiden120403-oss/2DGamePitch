using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text sceneStarterText;

    void Start()
    {
        currentTime = startingTime;
    }
    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        sceneStarterText.text = currentTime.ToString("0");
        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
