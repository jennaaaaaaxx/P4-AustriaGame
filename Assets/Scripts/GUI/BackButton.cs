using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public int level;

    public void OpenScene()
    {
        SceneManager.LoadScene("Start Screen");
        Time.timeScale = 1f;
    }
}
