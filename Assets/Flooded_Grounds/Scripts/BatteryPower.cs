using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPower : MonoBehaviour
{
    [SerializeField] Image batteryUI;
    [SerializeField] float DrainTime = 15.0f;
    [SerializeField] float power;
    // Start is called before the first frame update
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        if (SaveScripts.batteryRefill == true)
        {
            SaveScripts.batteryRefill = false;
            batteryUI.fillAmount = 1.0f;
        }
        if (SaveScripts.flashLightOn == true || SaveScripts.nVLightOn == true)
        {
            batteryUI.fillAmount -= 1.0f / DrainTime * Time.deltaTime;
            power = batteryUI.fillAmount;
            SaveScripts.batteryPower = power;
        }
        
    }
}
