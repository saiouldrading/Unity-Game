

// using UnityEngine;

// public class EnemyDog : MonoBehaviour
// {
//     public float moveSpeed = 2f;
//     public float detectionRange = 5f;
//     private Transform player;
//     private Rigidbody2D rb;
//     private Vector2 moveDirection;
//     private float directionChangeInterval = 2f;
//     private float timeSinceLastChange = 0f;

//     private bool isChasing = false;
//     Animator animator;
//     private Vector2 orignalscale;


//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         player = GameObject.FindGameObjectWithTag("Player").transform;
//         ChooseRandomDirection();
//         animator = GetComponent<Animator>();
//         orignalscale = transform.localScale;
//     }

//     void Update()
//     {
//         float distanceToPlayer = Vector2.Distance(transform.position, player.position);

//         if (distanceToPlayer <= detectionRange)
//         {
//             isChasing = true;
//         }
//         else
//         {
//             isChasing = false;
//         }

//         if (isChasing)
//         {
//             // Move toward player
//             Vector2 direction = (player.position - transform.position).normalized;
//             rb.linearVelocity = new Vector2(direction.x * moveSpeed, rb.linearVelocity.y);
//         }
//         else
//         {
//             // Random movement
//             timeSinceLastChange += Time.deltaTime;
//             if (timeSinceLastChange >= directionChangeInterval)
//             {
//                 ChooseRandomDirection();
//                 timeSinceLastChange = 0f;
//             }
//             rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, rb.linearVelocity.y);
//         }

//         float s = Mathf.Abs(rb.linearVelocity.x);
//         animator.SetFloat("speed", s);
//         animator.SetBool("IsWalking", s > 0.01f);
//         flip();
//     }

//     void ChooseRandomDirection()
//     {
//         float RandomValue = Random.Range(0, 2);
//         if (RandomValue == 0)
//         {
//             moveDirection = Vector2.left;
//         }
//         else
//         {
//             moveDirection = Vector2.right;
//         }


//    }

//     void OnDrawGizmosSelected()
//     {
//         Gizmos.color = Color.red;
//         Gizmos.DrawWireSphere(transform.position, detectionRange);
//     }


//     void flip()
//     {
//         Vector3 scale = orignalscale;

//         if (rb.linearVelocity.x > 0)
//         {
//             scale.x = -Mathf.Abs(orignalscale.x); // right
//         }
//         else if (rb.linearVelocity.x < 0)
//         {
//             scale.x = Mathf.Abs(orignalscale.x); // left
//         }

//         transform.localScale = scale;
//     }
// }




// using UnityEngine;

// public class EnemyDog : MonoBehaviour
// {
//     private Transform player;
//     public float speed = 3f;

//     public float detectionRange = 5f;

//     private Rigidbody2D rb;
//     Animator animator;
//     private Vector2 moveDirection;
//     private Vector3 orignalscale;
//     private bool IsChasing = false;
//     private float timer = 0f;
//     private float DirectionChangeTimer = 2f;




//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         animator = GetComponent<Animator>();
//         orignalscale = transform.localScale;
//         player = GameObject.FindGameObjectWithTag("Player").transform;


//     }


//     void RandomMovement()
//     {
//         float random = Random.Range(0, 2);
//         if (random == 0)
//         {
//             moveDirection = Vector2.right;
//         }
//         else
//         {
//             moveDirection = Vector2.left;
//         }
//     }
//     void Update()
//     {
//         float PLayerDistance = Vector2.Distance(player.position, transform.position);
//         if (PLayerDistance <= detectionRange)
//         {
//             IsChasing = true;

//         }
//         else
//         {
//             IsChasing = false;

//         }

//         if (IsChasing)

//         {
//             Vector2 direction = (player.position - transform.position).normalized;
//             rb.linearVelocity = new Vector2(direction.x * speed, rb.linearVelocity.y);
//         }
//         else 
//         {
//             timer += Time.deltaTime;
//             if (timer >= DirectionChangeTimer)
//             {
//                 timer = 0;
//                 RandomMovement();
//             }
//             rb.linearVelocity =  new Vector2(moveDirection.x * speed, rb.linearVelocity.y);

//         }
//         flip();
//         float s = Mathf.Abs(rb.linearVelocity.x);
//         animator.SetFloat("speed", s);
//         animator.SetBool("IsWalking", s > 0);

//     }
//     void flip()
//     {
//         Vector3 scale = orignalscale;
//         if (rb.linearVelocity.x > 0)
//         {
//             scale.x = -Mathf.Abs(orignalscale.x);
//         }
//         else if (rb.linearVelocity.x < 0)
//         {
//             scale.x = Mathf.Abs(orignalscale.x);
//         }
//         transform.localScale = scale;
//     }
//     void OnDrawGizmosSelected()
//     {
//         Gizmos.color = Color.hotPink;
//         Gizmos.DrawWireSphere(transform.position, detectionRange);
//     }

// }









// using UnityEngine;



// public class EnemyDog : MonoBehaviour
// {
//     private Transform player;
//     public float speed = 2f;
//     public float detectionRange = 10f;
//     Animator animator;
//     Rigidbody2D rb;
//     private bool IsChasing = false;
//     private Vector2 moveDirection;
//     private Vector3 orignalscale;
//     private float timer = 0f;
//     private float DirectionChangeTimer = 3f;


//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         animator = GetComponent<Animator>();
//         orignalscale = transform.localScale;
//         player = GameObject.FindGameObjectWithTag("Player").transform;

//     }

//     void flip()
//     {
//         Vector3 scale = orignalscale;
//         if (rb.linearVelocity.x > 0)
//         {
//             scale.x = -Mathf.Abs(orignalscale.x);
//         }
//         else if (rb.linearVelocity.x < 0)
//         {
//             scale.x = Mathf.Abs(orignalscale.x);
//         }

//     }
//     void RandomMovement()
//     {
//         float random = Random.Range(0f, 2f);
//         if (random == 0)
//         {
//             moveDirection = Vector2.right;
//         }
//         else
//         {
//             moveDirection = Vector2.left;

//         }
//     }

//     void OnDrawGizmosSelected()
//     {
//         Gizmos.color = Color.purple;
//         Gizmos.DrawWireSphere(transform.position, detectionRange);
//     }
//     void Update()
//     {
//         float playerDistance = Vector2.Distance(transform.position, player.position);
//         if (playerDistance <= detectionRange)
//         {
//             IsChasing = true;
//         }
//         else
//         {
//             IsChasing = false;
//         }

//         if (IsChasing)
//         {
//             Vector2 direction = (player.position - transform.position).normalized;
//             rb.linearVelocity = new Vector2(direction.x * speed, rb.linearVelocity.y);
//         }
//         else
//         {
//             timer = Time.deltaTime;
//             if (timer > DirectionChangeTimer)

//             {
//                 timer = 0f;
//                 RandomMovement();
//             }
//                 rb.linearVelocity = new Vector2(moveDirection.x * speed, rb.linearVelocity.y);

//         }
//         flip();
//         float s = Mathf.Abs(rb.linearVelocity.x);
//         animator.SetFloat("speed", s);
//         animator.SetBool("IsWalking", s > 0.01f);
//     }
// }



using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyDog : MonoBehaviour
{
    private Transform player;
    private Rigidbody2D rb;
    private Animator animator;

    public float speed = 3f;
    public float detectionRange = 5f;
    private float timer = 0f;
    private float DirectionChangeTimer = 2f;
    private Vector2 moveDirection;
    private bool IsChasing = false;
    private Vector2 orignalscale;




    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        orignalscale = transform.localScale;
    }

    private void flip()
    {
        Vector2 scale = orignalscale;
        if (rb.linearVelocity.x > 0)
        {
            scale.x = -Mathf.Abs(orignalscale.x);
        }
        else if (rb.linearVelocity.x < 0)
        {
            scale.x = Mathf.Abs(orignalscale.x);
        }
        transform.position = scale;

    }


    private void GetRandomLocation()
    {
        float randomX = Random.Range(0, 2f);
        if (randomX == 0)
        {
            moveDirection = Vector2.right;
        }
        else
        {
            moveDirection = Vector2.left;
        }



    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }


    public void Update()
    {
        float PlayerDistance = Vector2.Distance(transform.position, player.position);

        if (PlayerDistance <= detectionRange)
        {
            IsChasing = true;
        }
        else
        {
            IsChasing = false;
        }

        if (IsChasing)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = new Vector2(direction.x * speed, rb.linearVelocity.y);
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= DirectionChangeTimer)
            {
                GetRandomLocation();
                timer = 0f;
            }
            rb.linearVelocity = new Vector2(moveDirection.x * speed, rb.linearVelocity.y);

        }
        flip();
        float s = Mathf.Abs(rb.linearVelocity.x);
        animator.SetFloat("speed", s);
        animator.SetBool("IsWalking", s > 0.01f);
    }


}
