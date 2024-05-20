using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float thrust = 1.0f;
    public float distance = 0.5f;
    public Transform jumpPos;
    public Vector3 FallingDown;
    private bool stop = false;
    public Animator animator;

    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * thrust);
            //Debug.Log("jump");
            stop = true;
            animator.SetBool("isRunning", false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            stop = false;
            animator.SetBool("isRunning", true);
        }

        //if (Input.touchCount > 0 && IsGrounded() == true)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        rb.AddForce(Vector3.up * thrust);
        //    }



        //}

        //if (Input.touchCount > 0)
        //{
        //    Touch touch1 = Input.GetTouch(0);

        //    if (touch1.phase == TouchPhase.Ended)
        //    {
        //        rb.AddForce(FallingDown);
        //    }
        //}

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                stop = true;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                stop = false;
            }
        }
        
    }
    

    void FixedUpdate()
    {
        if (!stop)
        rb.MovePosition(transform.position + Vector3.forward * Time.deltaTime * speed);
    }

    bool IsGrounded()
    {
        return Physics.Raycast(jumpPos.position, Vector3.down, distance);
    }
}
