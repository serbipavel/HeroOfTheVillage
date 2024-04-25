using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] int numOfJumps = 2;

    [SerializeField] GameObject maincamera;
    //Animator anim;

    void Start()
    {

    }

    void Update()
    {
        //Способ 3 (с анимациями)
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement += Camera.main.transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement -= Camera.main.transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement -= Camera.main.transform.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Camera.main.transform.right;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }

        movement.Normalize();

        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z * speed);

        if (Input.GetKeyDown(KeyCode.Space) && numOfJumps > 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            numOfJumps--;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        numOfJumps = 2;
    }
}
