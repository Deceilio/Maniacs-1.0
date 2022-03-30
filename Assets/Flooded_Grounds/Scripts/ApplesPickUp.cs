using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    [SerializeField] int ammoNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckAmmo());
    }

   IEnumerator CheckAmmo()
    {
        yield return new WaitForSeconds(1);
        if (ammoNumber > SaveScripts.ammoLeft)
        {
            Destroy(gameObject);
        }
    }
}
