using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 30f;
    public float attackCooldown = 1f; // Time between attacks
    private float nextAttackTime = 0f;

    Rigidbody rb;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    public void FixedUpdate()
    {
        // Movement
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

        // Attack
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackCooldown;
        }
    }

    void Attack()
    {
        // Trigger attack animation
        animator.SetTrigger("attack");

        // Add attack logic here, e.g., deal damage, play sound, etc.
        Debug.Log("Attack executed");
    }
}
