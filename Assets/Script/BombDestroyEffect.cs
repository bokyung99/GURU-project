using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroyEffect : MonoBehaviour
{
    //���ŵ� �ð� ����
    public float destroyTime = 1.5f;

    //��� �ð� ������ ����
    float currentTime = 0;
   
    void Update()
    {
        //���� ��� �ð��� ���ŵ� �ð��� �ʰ��ϸ� �ڱ� �ڽ��� ����
        if(currentTime>destroyTime)
        {
            Destroy(gameObject);
        }

        //��� �ð� ����
        currentTime += Time.deltaTime;

    }
}
