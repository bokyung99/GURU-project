using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    //���� ����Ʈ ����
    public GameObject bombEffect;

    //�浹 ���� ��
    private void OnCollisionEnter(Collision collision)
    {
        //���� ����Ʈ ����
        GameObject eff = Instantiate(bombEffect);

        //���� ����Ʈ ��ġ�� ����ź ������Ʈ ��ġ�� ���Ͻ�
        eff.transform.position = transform.position;

        //�ڱ� �ڽ� ����
        Destroy(gameObject);
    }
}
