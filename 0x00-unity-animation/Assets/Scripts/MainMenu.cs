using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{


public void LevelSelect(int level)
{
    string scene = "Level0" + level.ToString();
    PlayerPrefs.SetString("Prev", scene);
    SceneManager.LoadScene(scene);

}

public void Options()
    {
        PlayerPrefs.SetString("Prev", "MainMenu");
        SceneManager.LoadScene("Options");
    }

public void Exit()
    {
        Application.Quit();
    }
}
