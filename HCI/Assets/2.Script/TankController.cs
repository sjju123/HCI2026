using UnityEngine;

public class TankController : MonoBehaviour
{
    public float moveSpped = 200;
    float move;
    float rotate;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Verticla");
        rotate = Input.GetAxis("Horizontal");
        if (Mathf.Abs(move) > 1) 
            ;
    }


    void Move()
    {
        Vector3 moveDir = transform.forward * move * moveSpped * Time.deltaTime;
        rb.MovePosition(rb.position + moveDir);
    }
}
