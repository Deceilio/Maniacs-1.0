using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private NavMeshAgent nav;
    private Transform theTarget;

    private float distanceToTarget;
    private int targetNumber = 1;
    [SerializeField] float stopDistance = 2.0f;
    [SerializeField] int maxTargets = 7;
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
   [SerializeField] Transform target3;
    [SerializeField] Transform target4;
    [SerializeField] Transform target5;
    [SerializeField] Transform target6;
    [SerializeField] Transform target7;
  
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        theTarget = target1;
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(theTarget.position, transform.position);
        if (distanceToTarget > stopDistance)
        {
            nav.SetDestination(theTarget.position);
        }
        if (distanceToTarget < stopDistance)
        {
            targetNumber++;
            if (targetNumber > maxTargets)
            {
                targetNumber = 1;
            }
           
        }
        SetTarget();

    }
    void SetTarget()
    {
        if (targetNumber == 1)
        {
            theTarget = target1;
        }
        if (targetNumber == 2)
        {
            theTarget = target2;
        }
        if (targetNumber == 3)
        {
            theTarget = target3;
        }
        if (targetNumber == 4)
        {
            theTarget = target4;
        }
        if (targetNumber == 5)
        {
            theTarget = target5;
        }
        if (targetNumber == 6)
        {
            theTarget = target6;
        }
        if (targetNumber == 7)
        {
            theTarget = target7;
        }
    }
    
}
