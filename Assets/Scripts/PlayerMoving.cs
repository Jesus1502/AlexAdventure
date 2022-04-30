using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoving : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator animator;
    private SpriteRenderer SR;
    public Vector2 moveVector;
    public float speed = 2f;
    public float jumpforce = 7f;
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        SR = GetComponent<SpriteRenderer>();
       

    }

   
    void Update()
    {
        Walk();
        Flip();
        Jump();
        CheckingGround();

    }
   void Walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        animator.SetFloat("HorizontalMove", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
       
    }

    void Flip()
    {
        if (moveVector.x > 0)
        {
            SR.flipX = false;
        }
        else if (moveVector.x < 0)
        {
            SR.flipX = true;
        }
       
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector2.up * jumpforce);
        }
    }

    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;

    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
        animator.SetBool("OnGround", onGround);
    }

    void OnTriggerEnter2D(Collider2D  other)
    {
        if(other.tag == "respawn")
        {
            SceneManager.LoadScene(1);

        }
    }


}
