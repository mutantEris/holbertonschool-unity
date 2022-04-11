using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public float force;
    public bool isGrounded = true;
    public float turnSpeed = 1.0f;
    float rotation;
    public float sensitivity;
    public Vector3 respawn = new Vector3(0f, 10f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotationing();
        Respawn();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isGrounded = true;
    }
    void Movement()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(0, force, 0);
            isGrounded = false;
        }

            /* moving = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moving *= speed;
            moving = transform.rotation * moving;
            if (Input.GetButton("Jump"))
            {
                moving.y = jumpForce;
            } */

        if (Input.GetKey(KeyCode.A))
        {
            //rotation = Input.GetAxis ("Horizontal") * turnSpeed;
            //transform.Rotate(transform.up, rotation);
            //rb.AddForce(speed * Time.deltaTime, 0, 0);
            //transform.rotation = Quaternion.Euler(0f, 0f, 10f);
            rb.velocity = new Vector3(xDirection, (rb.velocity.y/speed), zDirection) * speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(xDirection, (rb.velocity.y/speed), zDirection) * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(xDirection, (rb.velocity.y/speed), zDirection) * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(xDirection, (rb.velocity.y/speed), zDirection) * speed;
        }
        //transform.position += moveDirection * speed;
    }
    void Rotationing()
    {
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X") * sensitivity, 0));
    }
    void Respawn()
    {
        if (transform.position.y < -35f)
        {
            transform.position = respawn;
        }
    }
}
