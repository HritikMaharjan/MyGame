using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 30f;
    Rigidbody rb;
    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        if (translation != 0)
        {
            animator.SetInteger("anim", 1);

        }
        else
        {
            animator.SetInteger("anim", 0);
        }


        transform.Translate(0, 0, translation * Time.deltaTime);



        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
