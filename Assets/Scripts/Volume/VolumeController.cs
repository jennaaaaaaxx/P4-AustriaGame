using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.HasKey("volumeValue"))
        {
            float localVolume = PlayerPrefs.GetFloat("volumeValue");
            AudioListener.volume = localVolume;
        }
    }
}

