using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManagement : MonoBehaviour
{
    public float speed;         // 속도 조절
    public float life;          // 체력
    public float jumpPower;     // 점프력
    Rigidbody2D rigid;          // 리지드바디
    SpriteRenderer sprite;      // 스프라이트
    bool isLive = true;         // 살아있음 판단
    bool isJump = false;        // 중복 점프 안되게 하기
    Animator anime;             // 에니메이션

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = false;
        sprite = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        anime.SetFloat("horizontal", horizontal);
        anime.SetFloat("vertical", vertical);
    }
    void FixedUpdate()
    {
        Move();
        Jump();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.A) && isLive)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            sprite.flipX = true;
            
        }
        else if (Input.GetKey(KeyCode.D) && isLive)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            sprite.flipX = false;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isJump = true;
            Debug.Log("땅에 안닿음");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("땅에 닿고 있음");
            isJump = false;
        }
    }
}
