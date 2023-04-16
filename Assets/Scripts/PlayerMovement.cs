using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;

    public int brickCount = 0;

    public bool Pause = false;
    public GameObject PauseMenu;

    public Collider2D boxCollider;
    public Collider2D circleCollider;
    Animator animator;

    void Start()
    {
        PauseMenu.SetActive(false);
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //recebe o input do player

        if (Input.GetKey(KeyCode.W))
        {
            jump = true;
            animator.SetBool("IsCrouch", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            crouch = true;
            animator.SetBool("IsCrouch", true);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            if(Pause == false)
            {
                PauseGame();
            }  

            else
            {
                ResumeGame();
            }
        }
    }

    void FixedUpdate()
    {
        //move o player
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        crouch = false;
        animator.SetBool("IsCrouch", false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Brick"))
        {
            // Add the brick to the player's count and destroy the brick GameObject
            brickCount=brickCount+1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Construction_Brick"))
        {
            boxCollider.isTrigger = true;
            circleCollider.isTrigger = true;
        }

        if (other.gameObject.CompareTag("Cement"))
        {
            boxCollider.isTrigger = true;
            circleCollider.isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Construction_Brick"))
        {
            boxCollider.isTrigger = false;
            circleCollider.isTrigger = false;
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        Debug.Log("Set Pause");
        Pause = true;
        PauseMenu.SetActive(true);
    }

    void ResumeGame()
    {
        Time.timeScale = 1.0f;
        Debug.Log("Set Resume");
        Pause = false;
        PauseMenu.SetActive(false);
    }
}
