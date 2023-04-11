using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManagement : MonoBehaviour
{
    public float speed;         // �ӵ� ����
    public float life;          // ü��
    public float jumpPower;     // ������
    Rigidbody2D rigid;          // ������ٵ�
    SpriteRenderer sprite;      // ��������Ʈ
    bool isLive = true;         // ������� �Ǵ�
    bool isJump = false;        // �ߺ� ���� �ȵǰ� �ϱ�
    Animator anime;             // ���ϸ��̼�

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
            Debug.Log("���� �ȴ���");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("���� ��� ����");
            isJump = false;
        }
    }
}
