﻿using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed= 0.025f;
    public Vector3 offset;
     

    
    void Update()
    {
     
     Vector3 desiredPosition= target.position+offset;
     Vector3 smoothPosition= Vector3.Lerp(transform.position,desiredPosition,smoothSpeed);
     transform.position=  smoothPosition;
     transform.LookAt(target);
   
    }
}
