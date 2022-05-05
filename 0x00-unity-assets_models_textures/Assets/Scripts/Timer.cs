using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTime;
    public float start;
    public GameObject PlayerPill;

    void Start()
    {
        start = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ((PlayerPill.transform.position.x != 0 || PlayerPill.transform.position.z != 0) && start == 0.0)
        {
            timerGo();
        }
    }
        //timerStop();

    // void characterMove()
    // {
    //     if (PlayerPill.transform.position.x != 0 | PlayerPill.transform.position.z != 0)
    //     timerGo;
    // }
    void timerGo()
    {
        float time = Time.time - start;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        timerTime.text = minutes + ":" + seconds;
    
    }
    // public void timerStart()
    // {
    //     if (!GetComponent<Timer>().enabled)
    //         if (PlayerPill.transform.position.x != 0 | PlayerPill.transform.position.z != 0)
    //             GetComponent<Timer>().enabled = true;
    //             timerGo();
    // }
    // void timerStop()
    // {
    //     if (time.GetComponent<Timer>().enabled)
    //         time.GetComponent<Timer>().enabled = true;
    // }
    // private void OnTriggerEnter(Collider other)
    // {
    //     other.GetComponent<Timer>;()
    // }
}

