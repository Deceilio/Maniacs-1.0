using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponDamage : MonoBehaviour
{
    [SerializeField] int weaponDamage=2;
    [SerializeField] Animator hurtAnim;
    [SerializeField] AudioSource myplayer;
    private bool hitActive = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hitActive == false)
            {
                hitActive = true;
                hurtAnim.SetTrigger("Hurt");
                SaveScripts.playerHealth -= weaponDamage;
                SaveScripts.healthChanged = true;
                myplayer.Play();
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hitActive == true)
            {
                hitActive = false;
                hurtAnim.SetTrigger("Hurt");
                
            }
        }

    }
}
