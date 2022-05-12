using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{

    public GameObject MainCam;
    public GameObject Player;
    public GameObject TimerCanvas;
    public GameObject CutCam;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        CutCam = GameObject.Find("CutsceneCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            TimerCanvas.gameObject.SetActive(true);
            Player.GetComponent<PlayerController>().enabled = true;
            MainCam.gameObject.SetActive(true);
            CutCam.gameObject.SetActive(false);

        }
			
        
    }
}
