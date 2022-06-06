using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

public string next;

public void Next()
    {
        SceneManager.LoadScene(next);
    }

}
