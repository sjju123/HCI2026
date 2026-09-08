using UnityEngine;

public class CannonController : MonoBehaviour
{

    public GameObject shellPrefab;
    public Transform fireTrans;

    GameObject shell;


    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            shell = Instantiate(shellPrefab, fireTrans.position, fireTrans.rotation);
            shell.GetComponent<>;
        } 
    }
}
