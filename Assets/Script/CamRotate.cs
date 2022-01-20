using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //ī�޶� ȸ�� �ӵ�
    public float rotSpeed = 200f;

    //ȸ�� ��
    float mx = 0;
    float my = 0;

    void Update()
    { 
        //ī�޶� ȸ��
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;

        Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);

       

        my = Mathf.Clamp(my, -90f, 90f);

       

        transform.eulerAngles += dir * rotSpeed * Time.deltaTime;

        Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90f, 90f);
        transform.eulerAngles = rot;

        transform.eulerAngles = new Vector3(-my, mx, 0);
 
    }
}
