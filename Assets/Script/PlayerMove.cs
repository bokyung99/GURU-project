using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�÷��̾� �̵�
public class PlayerMove : MonoBehaviour
{
    //�̵� �ӵ�
    public float moveSpeed = 7f;

    //ĳ���� ��Ʈ�ѷ� 
    CharacterController cc;

    //�߷� ����
    float gravity = -20f;

    //���� �ӷ� ����
    float yVelocity = 0;

    //������ ����
    public float jumpPower = 10f;

    //���� ���� ����
    public bool isJumping = false;

    private void Start()
    {
        //ĳ���� ��Ʈ�ѷ� ������Ʈ �޾ƿ���
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        //����� �Է�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //�̵� ����
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        //���� ī�޶� ���� ���� ��ȯ
        dir = Camera.main.transform.TransformDirection(dir);

        //�̵�
        transform.position += dir * moveSpeed * Time.deltaTime;

        //�����̽����Է½� ����
        if (Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
        }

        //���� ���̾��� �ٽ� �ٴ� ����
        if(isJumping&&cc.collisionFlags==CollisionFlags.Below)
        {
            //���� �� ���·� �ʱ�ȭ
            isJumping = false;

            yVelocity = 0;
        }

        //�����̽��� �Է��߰� ���� ���� ���¶��
        if(Input.GetButtonDown("Jump")&& !isJumping)
        {
            //ĳ���� ���� �ӵ��� ������ ���� �� ���� ���·� ����
            yVelocity = jumpPower;
            isJumping = true;
        }

        //ĳ���� ���� �ӵ��� �߷� �� ����
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //�̵��ӵ� ���� �̵�
        cc.Move(dir * moveSpeed * Time.deltaTime);


        
    }
}
