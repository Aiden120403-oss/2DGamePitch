using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownController : MonoBehaviour
{
    public string levelToLoad;
    float currentTime = 0f;
    float startingTime = 3f;

    [SerializeField] Text sceneStarterText;

    void Start()
    {
        currentTime = startingTime;
    }

    [System.Obsolete]
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        sceneStarterText.text = currentTime.ToString("f0");
        if(currentTime <= 1)
        {
            currentTime = 0;
            Application.LoadLevel(levelToLoad);
        }
    }
}
