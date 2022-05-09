using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerCam;
    //player
    public GameObject player;
    // distance between camera and player
    public Vector3 cameraOffset;
    public float sensitivity;
    public float rotateHorizontal;
    public float rotateVertical;
    public bool isInverted;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        {
        rotateHorizontal += Input.GetAxisRaw("Mouse X");

        // if (isInverted)
        // {
        // rotateVertical = Mathf.Clamp(rotateVertical + Input.GetAxisRaw("Mouse Y"), -30, 60);
        // }
        // else
        // {
        rotateVertical = (Mathf.Clamp(rotateVertical - Input.GetAxisRaw("Mouse Y"), -30f, 60f)*PlayerPrefs.GetInt("yinvert", 1));
        // }
    }
    }


    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(rotateVertical, rotateHorizontal, 0);
        transform.position = playerCam.position + rotation * new Vector3(0, 0, -6.25f);
        transform.LookAt(playerCam);
        // rotateHorizontal = Input.GetAxis("Mouse X");
        // rotateVertical = Input.GetAxis("Mouse Y");
        // transform.Rotate(rotateVertical * sensitivity, rotateHorizontal * sensitivity, 0, Space.World);
        // gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, 0);
        //  comment player.transform.rotateHorizontal(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, 0);
        //  comment transform.rotation = player.transform.rotation;
        // gameObject.transform.position = new Vector3(player.transform.position.forward - 6, player.transform.position.y +34, player.transform.position.z);
    }
}