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
    [SerializeField] float chaseSpeed = 2.5f;
    [SerializeField] float walkSpeed = 1.5f;
    [SerializeField] float attackDistance = 2.5f;
    [SerializeField] float attackRotateSpeed = 2.0f;
    [SerializeField] float checkTime = 3.0f;
    [SerializeField] GameObject chaseMusic;
    [SerializeField] GameObject hurtUI;
    [SerializeField] GameObject enemyDamageZone;
    private bool canRun = false;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponentInParent<NavMeshAgent>();
        
        StartCoroutine(StartElements());
       
    }

    // Update is called once per frame
    void Update()
    {
        if (canRun == true)
        {


            if (enemyDamageZone.GetComponent<EnemyDamage>().hasDied == true)
            {
                chaseMusic.gameObject.SetActive(false);
            }

            distanceToPlayer = Vector3.Distance(player.position, enemy.transform.position);
            if (distanceToPlayer < maxRange)
            {
                if (isChecking == true)
                {
                    isChecking = false;
                    blocked = NavMesh.Raycast(transform.position, player.position, out hit, NavMesh.AllAreas);
                    if (blocked == false)
                    {
                        // Debug.Log("ICan see");
                        runToPlayer = true;
                        failedChecks = 0;
                    }
                    if (blocked == true)
                    {
                        //Debug.Log("Where Did You Go");
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
                if (enemyDamageZone.GetComponent<EnemyDamage>().hasDied == false)
                {
                    chaseMusic.gameObject.SetActive(true);
                }

                if (distanceToPlayer > attackDistance)
                {
                    nav.isStopped = false;
                    anim.SetInteger("State", 2);
                    nav.acceleration = 24;
                    nav.SetDestination(player.position);
                    nav.speed = chaseSpeed;
                    hurtUI.gameObject.SetActive(false);
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
                    hurtUI.gameObject.SetActive(true);

                }
            }
            else if (runToPlayer == false)
            {
                nav.isStopped = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            runToPlayer = true;
        }
        if (other.gameObject.CompareTag("PKnife"))
        {
            anim.SetTrigger("SmallReact");

        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            anim.SetTrigger("BigReact");

        }
        if (other.gameObject.CompareTag("PBat"))
        {
            anim.SetTrigger("BigReact");

        }
        if (other.gameObject.CompareTag("PCrossbow"))
        {
            anim.SetTrigger("BigReact");

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
    IEnumerator StartElements()
    {
        yield return new WaitForSeconds(0.1f);
        player = SaveScripts.playerCar;
        chaseMusic = SaveScripts.chase;
        hurtUI = SaveScripts.hurtScreen;
        chaseMusic.gameObject.SetActive(false);
        canRun = true;
        checkTime = Random.Range(2, 15);
    }
}
