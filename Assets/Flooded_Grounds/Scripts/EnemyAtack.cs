using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAtack : MonoBehaviour
{
    private NavMeshAgent nav;
    private NavMeshHit hit;
    private bool blocked = false;
    private bool runToPlayer = false;
    private float distanceToPlayer;
    private bool isChecking=true;
    private int failedChecks=0;
    [SerializeField] Transform player;
    [SerializeField] Animator anim;
    [SerializeField] Transform enemy;
    [SerializeField] float maxRange=35.0f;
    [SerializeField] int maxChecks = 3;
    [SerializeField] float chaseSpeed = 8.5f;
    [SerializeField] float walkSpeed = 1.5f;
    [SerializeField] float attackDistance = 2.5f;
    [SerializeField] float attackRotateSpeed = 2.0f;
    [SerializeField] float checkTime = 3.0f;
    [SerializeField] GameObject chaseMusic;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponentInParent<NavMeshAgent>();
        chaseMusic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.position, enemy.transform.position);
        if (distanceToPlayer < maxRange)
        {
            if (isChecking == true)
            {
                isChecking = false;
                blocked = NavMesh.Raycast(transform.position, player.position, out hit, NavMesh.AllAreas);
                if (blocked == false)
                {
                    Debug.Log("ICan see");
                    runToPlayer = true;
                    failedChecks = 0;
                }
                if (blocked == true)
                {
                    Debug.Log("Where Did You Go");
                    runToPlayer = false;
                    anim.SetInteger("State", 1);
                    failedChecks++;
                }
                StartCoroutine(TimedCheck());
            }
        }
        if (runToPlayer == true)
        {
            enemy.GetComponent<EnemyMove>().enabled = false;
            chaseMusic.gameObject.SetActive(true);
            if (distanceToPlayer > attackDistance)
            {
                nav.isStopped = false;
                anim.SetInteger("State", 2);
                nav.acceleration = 24;
                nav.SetDestination(player.position);
                nav.speed = chaseSpeed;
            }

            if (distanceToPlayer < attackDistance - 0.5f)
            {
                nav.isStopped = true;
               // Debug.Log("I am Attacking");
                anim.SetInteger("State", 3);
                nav.acceleration = 180;
                Vector3 pos = (player.position - enemy.transform.position).normalized;
                Quaternion posRotation = Quaternion.LookRotation(new Vector3(pos.x, 0, pos.z));
                enemy.transform.rotation = Quaternion.Slerp(enemy.transform.rotation, posRotation, Time.deltaTime * attackRotateSpeed);
                
           
            }
        }
        else if (runToPlayer == false)
        {
            nav.isStopped = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            runToPlayer = true;
        }
    }
    IEnumerator TimedCheck()
    {
        yield return new WaitForSeconds(checkTime);
        isChecking = true;

        if (failedChecks > maxChecks)
        {
            enemy.GetComponent<EnemyMove>().enabled = true;
            nav.isStopped = false;
            nav.speed = walkSpeed;
            failedChecks = 0;
            chaseMusic.gameObject.SetActive(false);
        }

    }
}
