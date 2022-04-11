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
    public float rotateHorizontal;
    public float rotateVertical;

    void start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        rotateHorizontal = Input.GetAxis("Mouse X");
        rotateVertical = Input.GetAxis("Mouse Y");
        transform.Rotate(rotateVertical * sensitivity, rotateHorizontal * sensitivity, 0, Space.World);
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, 0);
        transform.position = player.transform.position;
    }
}