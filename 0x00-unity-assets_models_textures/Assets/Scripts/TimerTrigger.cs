using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{

    public Text timerTime;
    public float start;
    public GameObject PlayerPill;

    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        if (!other.GetComponent<Timer>().enabled)
        other.GetComponent<Timer>().start = Time.time;
        other.GetComponent<Timer>().enabled = true;
        timerGo();
    }

    void timerGo()
    {
        float time = Time.time - start;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        timerTime.text = minutes + ":" + seconds;
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
