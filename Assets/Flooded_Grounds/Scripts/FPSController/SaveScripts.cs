using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScripts : MonoBehaviour
{
    public static int playerHealth = 100;
    public static bool healthChanged = false;
    public static float batteryPower=1.0f;

    public static bool batteryRefill = false;
    public static bool flashLightOn = false;
    public static bool nVLightOn = false;

    public static int apples = 0;
    public static int batteryes = 0;
    public static int gunMag = 0;
    public static bool arrowRefill = false;
    public static bool cabinKey = false;
    public static bool roomKey = false;
    public static bool houseKey = false;
    public static bool knife = false;
    public static bool axe = false;
    public static bool bat = false;
    public static bool gun = false;
    public static bool crossbow = false;
    public static bool haveKnife = false;
    public static bool haveBat = false;
    public static bool haveGun = false;
    public static bool haveAxe = false;
    public static bool newGame = false;

    private void Start()
    {
        if (newGame == true)
        {
            playerHealth = 100;
   healthChanged = false;
     batteryPower = 1.0f;

     batteryRefill = false;
    flashLightOn = false;
     nVLightOn = false;

    apples = 0;
    batteryes = 0;
    gunMag = 0;
     arrowRefill = false;
     cabinKey = false;
     roomKey = false;
     houseKey = false;
     knife = false;
     axe = false;
    bat = false;
     gun = false;
     crossbow = false;
     haveKnife = false;
    haveBat = false;
     haveAxe = false;
   
}
    }

}
