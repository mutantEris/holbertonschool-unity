using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Timer>().enabled=false;
    }
}
