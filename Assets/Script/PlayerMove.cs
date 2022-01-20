using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 이동
public class PlayerMove : MonoBehaviour
{
    //이동 속도
    public float moveSpeed = 7f;

    //캐릭터 콘트롤러 
    CharacterController cc;

    //중력 변수
    float gravity = -20f;

    //수직 속력 변수
    float yVelocity = 0;

    //점프력 변수
    public float jumpPower = 10f;

    //점프 상태 변수
    public bool isJumping = false;

    private void Start()
    {
        //캐릭터 콘트롤러 컴포넌트 받아오기
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        //사용자 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 방향
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        //메인 카메라 기준 방향 변환
        dir = Camera.main.transform.TransformDirection(dir);

        //이동
        transform.position += dir * moveSpeed * Time.deltaTime;

        //스페이스바입력시 점프
        if (Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
        }

        //점프 중이었고 다시 바닥 착지
        if(isJumping&&cc.collisionFlags==CollisionFlags.Below)
        {
            //점프 전 상태로 초기화
            isJumping = false;

            yVelocity = 0;
        }

        //스페이스바 입력했고 점프 안한 상태라면
        if(Input.GetButtonDown("Jump")&& !isJumping)
        {
            //캐릭터 수직 속도에 점프력 적용 후 점프 상태로 변경
            yVelocity = jumpPower;
            isJumping = true;
        }

        //캐릭터 수직 속도에 중력 값 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //이동속도 맞춰 이동
        cc.Move(dir * moveSpeed * Time.deltaTime);


        
    }
}
