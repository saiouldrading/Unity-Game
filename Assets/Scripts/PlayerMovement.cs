// using System;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     [SerializeField] float speed = 5f;
//     [SerializeField] float jumpForce = 5f;
//     [NonSerialized] public bool isGrounded = false;

//     Rigidbody2D rb;

//     // 🔐 Store original scale
//     private Vector3 originalScale;

//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         originalScale = transform.localScale; // Save original scale
//     }

//     void Update()
//     {
//         float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

//         Vector3 move = new Vector3(xMovement, 0, 0);
//         rb.AddForce(move, ForceMode2D.Impulse);

//         // 🔁 Flip the sprite without changing original size
//         if (xMovement > 0)
//             transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z); // Face right
//         else if (xMovement < 0)
//             transform.localScale = new Vector3(-Mathf.Abs(originalScale.x), originalScale.y, originalScale.z); // Face left

//         Jump();
//     }

//     void Jump()
//     {
//         if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
//         {
//             rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
//             isGrounded = false;
//         }
//     }

//     void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.CompareTag("Ground"))
//         {
//             isGrounded = true;
//         }
//     }
// }



using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    private Vector3 originalScale;

    public Animator animator;
    private bool crouched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        originalScale = transform.localScale;
        animator = GetComponent<Animator>();
    }

    void Update()
    {


        float xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 move = new Vector3(xMovement, 0f, 0f);
        if (crouched == false)
        { transform.Translate(move); }

        //animation k liye
        animator.SetFloat("speed", Mathf.Abs(xMovement));


        if (xMovement > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
        else if (xMovement < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }

        Jump();
        Crouching();
        Hurt();

    }

    void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
            animator.SetBool("Jump", true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("Jump", false);
        }
    }

    void Crouching()
    {
        if (Input.GetKeyDown(KeyCode.C) && isGrounded == true)
        {
            animator.SetBool("IsCrouching", true);
            crouched = true;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("IsCrouching", false);
            crouched = false;
        }
    }

    void Hurt()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("IsHurt", true);
            crouched = true;    
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            animator.SetBool("IsHurt", false);
            crouched = false;
           
        }
    }
}
