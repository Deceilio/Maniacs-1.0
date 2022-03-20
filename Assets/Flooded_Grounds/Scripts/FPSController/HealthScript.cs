using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = SaveScripts.playerHealth+"%";
    }

    // Update is called once per frame
    void Update()
    {
        if( SaveScripts.healthChanged == true)
        {
            SaveScripts.healthChanged = false;
            healthText.text = SaveScripts.playerHealth + "%";

        }
    }
}
