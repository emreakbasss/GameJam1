using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float jumpForce = 5f; // Zýplama kuvveti
    private bool isGrounded = true; // Yerde mi kontrolü
    private bool canJumpInAir = false; // Havada iken zýplamaya izin verme kontrolü

    private Rigidbody rb;
    private Animator animator;
    public float rotationSpeed = 90f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isW", true);
            transform.Translate(new Vector3(0, 0, 3) * Time.deltaTime);
        }

        else
        {
            animator.SetBool("isW", false);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWandShift", true);
            transform.Translate(new Vector3(0, 0, 6) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWandShift", false);
        }


        if (isGrounded)
        {
            canJumpInAir = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || canJumpInAir))
        {
            animator.SetBool("isSpace", true);
            Jump();
        }

        else
        {
            animator.SetBool("isSpace", false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            Rotated();
        }

        void Rotated()
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * rotationAmount); // Nesneyi y ekseninde döndürme
        }


        if (Input.GetKey(KeyCode.A))
        {
            Rotatea();
        }

        void Rotatea()
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * -rotationAmount); // Nesneyi y ekseninde döndürme
        }


        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWr", true);
            transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWr", false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        canJumpInAir = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        canJumpInAir = false;
    }
}
