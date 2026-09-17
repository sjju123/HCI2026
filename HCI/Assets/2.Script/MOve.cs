using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MOve : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 2f;

    float move;

    public void OnTankMove(InputAction.CallbackContext context)
    {
        Debug.Log("Move value : " + context.ReadValue<float>);
    }

    public void OnTankRotate(InputAction.CallbackContext context)
    {
        Debug.Log("Rotate value : " + context.ReadValue<float>);
    }


    void OnMove(InputValue value)
    {
        Debug.Log("Input value:" + value.Get<float>());
    }

    void OnARotate(InputValue value)
    {
       
    }
}
