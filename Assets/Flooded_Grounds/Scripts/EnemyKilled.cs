using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilled : MonoBehaviour
{
    [SerializeField] int enemyNumber;
    // Start is called before the first frame update
    void Start()
    {
        if (enemyNumber ==1) 
        {
            SaveScripts.enemy1 = 0;
        }
        
    }

    
}
