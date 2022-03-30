using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplesPickUp : MonoBehaviour
{
    [SerializeField] int appleNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckApples());
    }

   IEnumerator CheckApples()
    {
        yield return new WaitForSeconds(1);
        if (appleNumber > SaveScripts.applesLeft)
        {
            Destroy(gameObject);
        }
    }
}
