using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text volumeTextUI = null;
    private void Start()
    {
        loadValues();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0%");
    }

    public void saveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("volumeValue", volumeValue);
        loadValues();
    }

   void loadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("volumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}