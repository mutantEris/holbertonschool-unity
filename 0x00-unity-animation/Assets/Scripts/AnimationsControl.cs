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
        PlayerController playbert = player.GetComponent<PlayerController>();
        if (playbert.isGrounded == false)
        {
            anim.SetBool("Jumping", true);
            anim.SetBool("Falling", true);
            anim.SetBool("Idling", false);
        }
        else
        {
            anim.SetBool("Jumping", false);
            anim.SetBool("Falling", false);
            anim.SetBool("Idling", true);
        }
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     anim.SetBool("Jumping", true);
        //     anim.SetBool("Running", false);
        // }
        // else 
        // {
        //     anim.SetBool("Jumping", false);
        //     anim.SetBool("Running", true);
        // }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("Running", true);
            anim.SetBool("Idling", false);
        }
        // else if (Input.GetAxisRaw("Horizontal"))
        //     anim.SetBool("Running", true);
        
        // else
        // {
        //     anim.SetBool("Running", false);
        //     anim.SetBool("Idling", true);
        // }
    }
}
