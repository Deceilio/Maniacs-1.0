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
    private bool damageOn=false;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<AudioSource>();
        anim =GetComponentInParent <Animator>();
        StartCoroutine(StartElements());
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (damageOn == true)
        {
            if (enemyHealth <= 0)
            {
                if (hasDied == false)
                {
                    anim.SetTrigger("Death");
                    anim.SetBool("IsDead", true);
                    hasDied = true;
                    SaveScripts.enemyOnScreen--;
                    Destroy(this.transform.parent.gameObject, 15f);
                }
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
        if (other.gameObject.CompareTag("PCrossbow"))
        {
            enemyHealth -= 50;
            myPlayer.Play();
            stabPlayer.Play();
            Destroy(other.gameObject, 0.05f);

        }
    }
    IEnumerator StartElements()
    {
        yield return new WaitForSeconds(0.1f);
        stabPlayer = SaveScripts.stabSound;
        bloodSplatKnife = SaveScripts.splatKnife;
        bloodSplatBat = SaveScripts.splatBat;
        bloodSplatAxe = SaveScripts.splatAxe;
        bloodSplatKnife.gameObject.SetActive(false);
        bloodSplatAxe.gameObject.SetActive(false);
        bloodSplatBat.gameObject.SetActive(false);
        damageOn = true;
    }
}
