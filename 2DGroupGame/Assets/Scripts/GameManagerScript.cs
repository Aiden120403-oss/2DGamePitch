﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public bool countdownDone = false;
    public GameObject CountDownImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownDone)
        {
            CountDownImage.SetActive(false);
        }
    }
}