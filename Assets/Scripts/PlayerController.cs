using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 캐릭터 이동 속도
    public float jumpForce = 5f; // 점프력

    private Rigidbody2D rb;
    private bool isGrounded = true; // 바닥에 있는지 여부를 판단하는 변수
    private bool canDoubleJump = false; // 더블 점프 가능 여부를 판단하는 변수

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0f, 0f);
        transform.position += direction * moveSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                isGrounded = false;
                canDoubleJump = true;
            }
            else if (canDoubleJump)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                canDoubleJump = false;
            }
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Space))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.5f);
            foreach (Collider2D collider in colliders)
            {
                if (collider.CompareTag("Platform"))
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider, true);
                }
            }
            rb.velocity = new Vector2(rb.velocity.x, -jumpForce);
            isGrounded = false;
        }
    }
     
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            canDoubleJump = false;
        }
        else if (collision.gameObject.CompareTag("Platform") && !Input.GetKey(KeyCode.S))
        {
            isGrounded = true;
            canDoubleJump = false;
        }

        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.collider, false);
    }
}
