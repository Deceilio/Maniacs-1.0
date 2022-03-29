using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHealth = 100;
    private AudioSource myPlayer;
    [SerializeField] AudioSource stabPlayer;
    public bool hasDied = false;
    private Animator anim;
    [SerializeField] GameObject enemyObject;
    [SerializeField] GameObject bloodSplatKnife;
    [SerializeField] GameObject bloodSplatBat;
    [SerializeField] GameObject bloodSplatAxe;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<AudioSource>();
        anim =GetComponentInParent <Animator>();
        bloodSplatKnife.gameObject.SetActive(false);
        bloodSplatAxe.gameObject.SetActive(false);
        bloodSplatBat.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            if (hasDied == false)
            {
                anim.SetTrigger("Death");
                anim.SetBool("IsDead", true);
                hasDied = true;
                Destroy(enemyObject, 15f);
            }
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PKnife"))
        {
            enemyHealth -= 10;
            myPlayer.Play();
            stabPlayer.Play();
            bloodSplatKnife.gameObject.SetActive(true);

        }
        if (other.gameObject.CompareTag("PBat"))
        {
            enemyHealth -= 15;
            myPlayer.Play();
            stabPlayer.Play();
            bloodSplatBat.gameObject.SetActive(true);

        }
        if (other.gameObject.CompareTag("PAxe"))
        {
            enemyHealth -= 20;
            myPlayer.Play();
            stabPlayer.Play();
            bloodSplatAxe.gameObject.SetActive(true);

        }
    }
}
