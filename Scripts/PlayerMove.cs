using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 4f;
    CharacterController cc;

    float gravity = -10f;   
    float yVelocity = 0;

    public Vector3 pre_position;
    public Vector3 dir;

    public float jumpPower = 0.5f;
    public bool isJumping = false;

    Animator anim;

    void Start()
    { 
        cc = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        pre_position = transform.position;
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        dir = new Vector3(h, 0, v);

        if ((h > 0) && h <= 1)
            h = 1;
        else if ((h < 0) && h >= -1)
            h = -1;
        if ((v > 0) && v < 1)
            v = 1;
        else if ((v < 0) && v > -1)
            v = -1;

        // if ((h!=0) || (v != 0)) {
        if ((h == -1) || (v == -1) || (h == 1) || (v == 1))
        {
            if (pre_position == transform.position)
            {
                yVelocity = jumpPower * 0.1f;
                yVelocity += gravity * Time.deltaTime;
                dir.y = yVelocity;
            }
            
            pre_position = transform.position;
        }

        dir = dir.normalized;

        anim.SetFloat("MoveDirection", dir.magnitude);

        transform.position += dir * moveSpeed * Time.deltaTime;
        dir = Camera.main.transform.TransformDirection(dir);

        if (cc.collisionFlags == CollisionFlags.Below)
        {
            if (isJumping)
            {
                isJumping = false;     
                yVelocity = 0;
            }

            if (Input.GetButtonDown("Jump") && !isJumping)
            {
                yVelocity = jumpPower;
                isJumping = true;
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
                yVelocity = jumpPower;
        }

        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);

        if (Time.timeScale == 0)
        {
            anim.SetFloat("MoveDirection", 0);
        }
    }
}
    /*
    public float moveSpeed = 4f;

    CharacterController cc;

    // �߷� ����
    float gravity = -10f;

    // ���� �ӷ� ����
    float yVelocity = 0;

    public float jumpPower = 0.5f;

    public bool isJumping = false;

   void Start()
    {
        // ĳ���� ��Ʈ�ѷ� ������Ʈ �޾ƿ���
        cc = GetComponent<CharacterController>();
    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �̵� ������ �����Ѵ�
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        transform.position += dir * moveSpeed * Time.deltaTime;
        // ���� ī�޶� �������� ������ ��ȯ�Ѵ�
        dir = Camera.main.transform.TransformDirection(dir);

        // ����, �ٽ� �ٴڿ� �����ߴٸ�
        if (cc.collisionFlags == CollisionFlags.Below)
        {
            // ���� ���̾��ٸ�
            if (isJumping)
            {
                // ���� �� ���·� �ʱ�ȭ�Ѵ�
                isJumping = false;

                // ĳ���� ���� �ӵ��� 0���� �����
                yVelocity = 0;
            }
            // ����, Ű���� Ű�� �Է��߰�, ������ ���� ���� ���¶��
            if (Input.GetButtonDown("Jump") && !isJumping)
            {
                yVelocity = jumpPower;
                isJumping = true;
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            // ĳ���� ���� �ӵ��� �������� �����Ѵ�
            yVelocity = jumpPower;
        }
        // ĳ���� ���� �ӵ��� �߷� ���� �����Ѵ�
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // �̵� �ӵ��� ���� �̵��Ѵ�
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
    */

