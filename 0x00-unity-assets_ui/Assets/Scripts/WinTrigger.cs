using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject wiñu;


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Timer>().Win();
        Cursor.lockState = CursorLockMode.None;
        other.GetComponent<Timer>().enabled=false;
        wiñu.SetActive(true);
    }
}
