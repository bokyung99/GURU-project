using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
   
    void Update()
    {   //ī�޶� �̵�
        transform.position = target.position;
    }
}
