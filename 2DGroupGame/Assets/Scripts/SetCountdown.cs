using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountdown : MonoBehaviour
{
    private GameManagerScript GMS;
    public void SetCountDown()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.countdownDone = true;
    }
}
