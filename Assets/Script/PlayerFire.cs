using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //�߻� ��ġ
    public GameObject firePosition;

    //��ô ���� ������Ʈ
    public GameObject bombFactory;

    //��ô �Ŀ�
    public float throwPower = 15f;

    void Update()
    {
        //���콺 �� ������ �ü��� �ٶ󺸴� �������� ����ź ��ô
        if(Input.GetMouseButtonDown(2))
        {
            //����ź ������Ʈ�� ������ �� ����ź�� ���� ��ġ�� �߻� ��ġ��
            GameObject bomb = Instantiate(bombFactory);
            bomb.transform.position = firePosition.transform.position;

        }

  

        //����ź ������Ʈ�� rigidbidy ������Ʈ ��������
        Rigidbody rb = bombFactory.GetComponent<Rigidbody>();

        //ī�޶��� ���� �������� ����ź�� �������� �� ���ϱ�
        rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
        

    }
}