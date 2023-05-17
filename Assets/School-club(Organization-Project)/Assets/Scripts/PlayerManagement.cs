using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManagement : MonoBehaviour
{
    public float Speed;         // 속도 조절
    public float Life;          // 체력
    public float JumpPower;     // 점프력
    float hor;
    Rigidbody2D rigid;          // 리지드바디
    SpriteRenderer sprite;      // 스프라이트
    bool isLive = true;         // 살아있음 판단
    bool isJump = false;        // 중복 점프 안되게 하기
    Animator anime;             // 에니메이션

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        hor = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(hor * Speed, rigid.velocity.y);

    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;
            rigid.velocity = Vector2.up * JumpPower;
            Debug.Log("땅에 안닿음");
        }
    }
    private void Flip()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJump = false;
            Debug.Log("땅에 닿음");
        }
    }
    private void UpdataState()
    {

    }
}
