using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        if (!other.GetComponent<Timer>().enabled)
        other.GetComponent<Timer>().start = Time.time;
        other.GetComponent<Timer>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
