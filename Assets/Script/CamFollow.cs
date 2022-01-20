using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
   
    void Update()
    {   //카메라 이동
        transform.position = target.position;
    }
}
