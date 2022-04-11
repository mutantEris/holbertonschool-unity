using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //player
    public GameObject player;
    // distance between camera and player
    public Vector3 cameraOffset;
    public float sensitivity;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraOffset;
        float rotateHorizontal = Input.GetAxis ("Mouse X");
        float rotateVertical = Input.GetAxis ("Mouse Y");
        transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
        transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity);
    }
}