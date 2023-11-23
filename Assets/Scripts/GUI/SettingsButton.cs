using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public int level;

    void Start()
    {

    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Settings Screen");
    }
}
