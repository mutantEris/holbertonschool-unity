using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsControl : MonoBehaviour
{

    public Animator anim;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            anim.SetBool("Running", true);
        // else if (Input.GetAxisRaw("Horizontal"))
        //     anim.SetBool("Running", true);
        else
            anim.SetBool("Running", false);
    }
}
