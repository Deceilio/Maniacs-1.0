using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    [SerializeField] int batteryNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckBattery());
    }

   IEnumerator CheckBattery()
    {
        yield return new WaitForSeconds(1);
        if (batteryNumber > SaveScripts.batteryLeft)
        {
            Destroy(gameObject);
        }
    }
}
