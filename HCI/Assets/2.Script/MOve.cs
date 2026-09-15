using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MOve : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 2f;

    float move;

    
    void OnMove(InputValue value)
    {
        Debug.Log("Input value:" + value.Get<float>());
    }

    void OnARotate(InputValue value)
    {
       
    }
}
