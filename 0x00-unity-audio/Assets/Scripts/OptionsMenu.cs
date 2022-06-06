using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle inverted;

    private void Start()
    {
        if (PlayerPrefs.HasKey("yInvert"))
        {
            if (PlayerPrefs.GetInt("yInvert") == -1)
                inverted.isOn = true;
            else
                inverted.isOn = false;
        }
        else
        {
            PlayerPrefs.SetInt("yInvert", 1);
        }
    }

public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Prev"));
    }

    public void Apply()
    {
        if (inverted.isOn)
            PlayerPrefs.SetInt("yInvert", -1);
        else
            PlayerPrefs.SetInt("yInvert", 1);
        SceneManager.LoadScene(PlayerPrefs.GetString("Prev"));
    }
}

