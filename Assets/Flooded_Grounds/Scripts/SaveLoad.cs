using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public int testHealth=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            testHealth = PlayerPrefs.GetInt("PlayersHealth");
        }
    }
    public void SaveGame()
    {
        PlayerPrefs.SetInt("PlayersHealth", SaveScripts.playerHealth);
        PlayerPrefs.SetFloat("BatteriesPower", SaveScripts.batteryPower);
    }
}
