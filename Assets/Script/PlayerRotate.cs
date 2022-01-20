using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    //회전 속도
    public float rotSpeed = 200f;
    //회전 값
    float mx = 0;

   
    void Update()
    {
        //플레이어 회전
        float mouse_X = Input.GetAxis("Mouse X");
        mx += mouse_X * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
        
    }
}
