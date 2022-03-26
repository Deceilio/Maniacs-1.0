using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHealth = 100;
    private AudioSource myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Knife"))
        {
            enemyHealth -= 50;
            myPlayer.Play();

        }
    }
}
