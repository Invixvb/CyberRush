using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public Animator animator;

    public float runSpeed = 40f;

    private float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        Controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}