using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManagement : MonoBehaviour
{
    public float Speed;         // �ӵ� ����
    public float Life;          // ü��
    public float JumpPower;     // ������
    float hor;
    Rigidbody2D rigid;          // ������ٵ�
    SpriteRenderer sprite;      // ��������Ʈ
    bool isLive = true;         // ������� �Ǵ�
    bool isJump = false;        // �ߺ� ���� �ȵǰ� �ϱ�
    Animator anime;             // ���ϸ��̼�

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
            Debug.Log("���� �ȴ���");
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
            Debug.Log("���� ����");
        }
    }
    private void UpdataState()
    {

    }
}
