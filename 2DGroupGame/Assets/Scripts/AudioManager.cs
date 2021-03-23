using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource firstTrack;

    // Start is called before the first frame update
    void Start()
    {
        if (firstTrack == null)
        {
            Debug.Log("First Track has not been set");
            enabled = false;
        }
        firstTrack.Play();
        firstTrack.volume = 0.1f;
    }

}
