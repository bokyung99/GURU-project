using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    //폭발 이펙트 변수
    public GameObject bombEffect;

    //충돌 했을 때
    private void OnCollisionEnter(Collision collision)
    {
        //폭발 이펙트 생성
        GameObject eff = Instantiate(bombEffect);

        //폭발 이펙트 위치를 수류탄 오브젝트 위치와 동일시
        eff.transform.position = transform.position;

        //자기 자신 제거
        Destroy(gameObject);
    }
}
