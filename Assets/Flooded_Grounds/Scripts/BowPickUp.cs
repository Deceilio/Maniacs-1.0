using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowPickUp : MonoBehaviour
{
    [SerializeField] int bowNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckBow());
    }

   IEnumerator CheckBow()
    {
        yield return new WaitForSeconds(1);
        if (bowNumber > SaveScripts.bowLeft)
        {
            Destroy(gameObject);
        }
    }
}
