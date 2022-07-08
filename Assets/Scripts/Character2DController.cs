using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    // Start is called before the first frame update

    private float MovementSpeed = 4;
    private float JumpForce = 5;

    private Rigidbody rb;

    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0) * Time.deltaTime * MovementSpeed;

        if (movement != 0)
        {
            animator.SetBool("isWalking", true);
            float rotation = movement < 0 ? -90f : 90;
            transform.rotation = Quaternion.Euler(0, rotation, 0f);
        }

        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode.Impulse);
        }
    }
}
