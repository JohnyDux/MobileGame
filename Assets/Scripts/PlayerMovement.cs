using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;

    public MainMenu menu;

    public Faucet faucet;

    public Slider volumeSlider;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;

    public int brickCount = 0;

    [Range(0f, 100f)] public float cementCount;
    [Range(0f, 100f)] public float sandCount;
    [Range(0f, 100f)] public float waterCount;

    public bool Pause = false;
    public GameObject PauseMenu;

    public Collider2D boxCollider;
    public Collider2D circleCollider;
    Animator animator;

    public AudioSource audioSource;

    void Start()
    {
        PauseMenu.SetActive(false);
        animator = GetComponent<Animator>();
        cementCount = 0;
        sandCount = 0;
        waterCount = 0;

        animator.SetBool("IsCrouch", false);
        animator.SetBool("IsWalking", false);

        audioSource.volume = 0.218f;

        volumeSlider.value = 100f;
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //recebe o input do player

        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
            crouch = false;
            animator.SetBool("IsCrouch", false);
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            jump = false;
            crouch = true;
            animator.SetBool("IsCrouch", true);
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsJumping", false);
        }

        if (Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Pause == false)
            {
                PauseGame();
            }  

            else if(Pause == true)
            {
                ResumeGame();
            }
        }

        audioSource.volume = volumeSlider.value;
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
            boxCollider.isTrigger = false;
            circleCollider.isTrigger = false;
            cementCount = cementCount + 50f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Sand"))
        {
            boxCollider.isTrigger = false;
            circleCollider.isTrigger = false;
            sandCount = sandCount + 40f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Faucet"))
        {
            waterCount = waterCount + faucet.waterIncrement;
        }

        if (other.gameObject.CompareTag("Betoneira"))
        {
            if(waterCount > 0 && sandCount > 0)
            {
                cementCount = cementCount + 30f;
                waterCount = 0;
                sandCount = 0;
            }
        }

        if (other.gameObject.CompareTag("Brick_Mold"))
        {
            if(cementCount > 3)
            {
                brickCount++;
                cementCount = 0;
            }
        }

        if (other.gameObject.CompareTag("Architect"))
        {
            if(brickCount > 0)
            {
                brickCount = brickCount - 1;
                animator.SetBool("IsHit", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Construction_Brick"))
        {
            boxCollider.isTrigger = false;
            circleCollider.isTrigger = false;
        }
        if (other.gameObject.CompareTag("Cement"))
        {
            boxCollider.isTrigger = false;
            circleCollider.isTrigger = false;
        }
        if (other.gameObject.CompareTag("Sand"))
        {
            boxCollider.isTrigger = false;
            circleCollider.isTrigger = false;
        }
        if (other.gameObject.CompareTag("Faucet"))
        {
            boxCollider.isTrigger = false;
        }
        if (other.gameObject.CompareTag("Architect"))
        {
            animator.SetBool("IsHit", false);
        }
    }

    void PauseGame()
    {
        menu.PauseGame();
        Pause = true;
        PauseMenu.SetActive(true);
        audioSource.Pause();
    }

    void ResumeGame()
    {
        menu.ResumeGame();
        Pause = false;
        PauseMenu.SetActive(false);
        audioSource.Play();
    }
}
