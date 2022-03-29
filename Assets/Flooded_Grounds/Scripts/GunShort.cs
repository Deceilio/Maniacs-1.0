using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShort : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (SaveScripts.haveGun == true)
        {
            if (SaveScripts.bullets > 0)
            {
                if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (Physics.Raycast(transform.position, transform.forward, out hit, 3000))
                    {
                        if (hit.transform.Find("Body"))
                        {
                            hit.transform.gameObject.GetComponentInChildren<EnemyDamage>().enemyHealth -= Random.Range(30, 101);
                            hit.transform.gameObject.GetComponent<Animator>().SetTrigger("BigReact");
                        }
                    }
                }
            }
        }   
    }
}
