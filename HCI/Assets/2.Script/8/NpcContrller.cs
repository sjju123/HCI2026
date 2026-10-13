using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NpcContrller : MonoBehaviour
{
    public Transform targetTR;

    //NavMeshAgent ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //NavMesh.SetDestination(targetTR.position);
    }
}
