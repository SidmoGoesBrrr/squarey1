using UnityEngine;

public class PlayerControls : MonoBehaviour
{
     public Rigidbody2D rb;
     public Transform groundCheck;
     public float groundCheckRadius;
     public LayerMask whatIsGround;
     private bool onGround;
     public float slidingForce = 10f;
     public float jumpHeight = 5f;
void Start() {
     rb = GetComponent<Rigidbody2D>();
     }

    void Update() {
         rb.velocity = new Vector2(slidingForce, rb.velocity.y);
         onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); 
         //onground is a boolean which is set true when squarey is on the ground        
         if (Input.GetMouseButtonDown(0) && onGround) {//left button mouse click or tap in android
                 rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
                 }

    }
    }

