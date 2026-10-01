using UnityEngine;
using UnityEngine.InputSystem;

public class Player2DContrller : MonoBehaviour
{
    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnFire(InputValue value)
    {
        anim.SetTrigger("IsFire");
    }
}
