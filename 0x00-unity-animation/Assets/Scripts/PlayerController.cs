using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 playerVelocity;
    public float speed;
    // public Rigidbody rb;
    public float force;
    public bool isGrounded = true;
    public float turnSpeed = 1.0f;
    public float jumpheight = 35;
    public float sensitivity;
    public Vector3 respawn = new Vector3(0f, 10f, 0f);
    public Transform cam;
    public Vector3 forward;
    public Vector3 right;
    public Transform Parent;
    public float turnSmoothTime = 0.1f;

    public float gravity = 9.8F;
    public float turnSmoothVelocity;

    public Transform groundCheck;
    public float groundDistance = 10f;
    public LayerMask groundMask;

    public CharacterController playerChar;

    public GameObject PlayerPill;

    public Vector2 rotationalicious = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        playerChar = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotationing();
        Respawn();
    }

    void Movement()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask, QueryTriggerInteraction.Ignore);
        if (isGrounded && playerVelocity.y < 0f)
        {
            Debug.Log("PV < 0");
            playerVelocity.y = -10f;
        }
        float xDirection = Input.GetAxisRaw("Horizontal");
        float zDirection = Input.GetAxisRaw("Vertical");

        //playerChar.Move(new Vector3(0, -gravity * Time.deltaTime, 0));
        //{
            // playerChar.AddForce(0, force, 0);
            // rb.AddForce(0, force, 0);
            // isGrounded = false;
       // }
        Vector3 direction = new Vector3(xDirection, 0f, zDirection).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            playerChar.Move(moveDir.normalized * speed * Time.deltaTime);
        }
            /* moving = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moving *= speed;
            moving = transform.rotation * moving;*/

            Debug.Log("IsGrounded = "+isGrounded+" jump = "+Input.GetButtonDown("Jump"));
        //transform.position += moveDirection * speed;
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Debug.Log("before jump");
            playerVelocity.y = jumpheight;//Mathf.Sqrt(3f * 2f * 9.8f);
            Debug.Log("after jump");
        }
        playerVelocity.y += -gravity * Time.deltaTime;
        playerChar.Move(playerVelocity * Time.deltaTime);
    }
    void Rotationing()
    {
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X") * sensitivity, 0));
        transform.rotation = cam.rotation;
        rotationalicious.y += Input.GetAxis("Mouse X") * sensitivity;
        rotationalicious.x -= Input.GetAxis("Mouse Y") * sensitivity;
        Parent.localRotation = Quaternion.Euler(rotationalicious.x, 0, 0);
        transform.eulerAngles = new Vector2(0, rotationalicious.y);
    }
    void Respawn()
    {
        if (transform.position.y < -35f)
        {
            transform.position = respawn;
        }
    }
}
