using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{

    public bool paused = false;
    public GameObject peñu;
    public AudioSource CheeryMonday;
    private float temp;
    //private float die = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if(paused)
                Pause();
            else
                Resume();
        }
    }

    public void Pause()
    {
        paused = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        peñu.SetActive(true);
        temp = CheeryMonday.volume;
        CheeryMonday.volume = CheeryMonday.volume*0.25f;
    }

    public void Resume()
    {
        paused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        peñu.SetActive(false);
        CheeryMonday.volume = temp;
    }

    public void Options()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetString("Prev", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
