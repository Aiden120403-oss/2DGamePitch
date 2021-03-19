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
<<<<<<< HEAD
        if(currentTime <= 1)
=======
        if(currentTime <= 0)
>>>>>>> b8b9739b487ddf67217c2e3c355555c01140f92f
        {
            currentTime = 0;
            Application.LoadLevel(levelToLoad);
        }
    }
}
