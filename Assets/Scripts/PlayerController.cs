using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables

    public float speed = 3f;
    public float jumpForce = 300f;

    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;

    private float horizontal;

    private bool isGrounded = false;

    private Rigidbody2D rb;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position.x += speed * horizontal * Time.fixedDeltaTime;

        rb.position = position;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer) && 
                     !Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer).isTrigger;
    }

    private void OnDrawGizmosSelected()
    {
        Color prevColor = Gizmos.color;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);

        Gizmos.color = prevColor;
    }
}
