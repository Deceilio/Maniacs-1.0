using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public int dataExists = 10;
    [SerializeField] GameObject loadButton;


    // Start is called before the first frame update
    void Start()
    {
        if (loadButton != null)
        {
            loadButton.gameObject.SetActive(false);
            dataExists = PlayerPrefs.GetInt("PlayersHealth", 0);
            if (dataExists > 0)
            {
                loadButton.gameObject.SetActive(true);
            }
        }
    }

   

    public void LoadGameData()
    {
        SaveScripts.savedGame = true;
    }
    public void SaveGame()
    {
        PlayerPrefs.SetInt("PlayersHealth", SaveScripts.playerHealth);
        PlayerPrefs.SetFloat("BatteriesPower", SaveScripts.batteryPower);
        PlayerPrefs.SetInt("BatteriesAmt", SaveScripts.batteryes);
        PlayerPrefs.SetInt("ApplesAmt", SaveScripts.apples);
        PlayerPrefs.SetInt("BulletsClips", SaveScripts.gunMag);
        PlayerPrefs.SetInt("BulletAmt", SaveScripts.bullets);
        PlayerPrefs.SetInt("ArrowsAmt", SaveScripts.arrows);
        PlayerPrefs.SetInt("MaxEScreen", SaveScripts.maxEnemyOnScreen);
        PlayerPrefs.SetInt("MaxEGame", SaveScripts.maxEnemiesInGame);
        PlayerPrefs.SetInt("ApplesL", SaveScripts.applesLeft);
        PlayerPrefs.SetInt("AmmoL", SaveScripts.ammoLeft);
        PlayerPrefs.SetInt("BatteryL", SaveScripts.batteryLeft);
        PlayerPrefs.SetInt("BowL", SaveScripts.bowLeft);
        PlayerPrefs.SetInt("Enemy1Alive", SaveScripts.enemy1);
        PlayerPrefs.SetInt("Enemy2Alive", SaveScripts.enemy2);
        PlayerPrefs.SetInt("Enemy3Alive", SaveScripts.enemy3);
        PlayerPrefs.SetInt("Enemy4Alive", SaveScripts.enemy4);

        if (SaveScripts.knife == true)
            PlayerPrefs.SetInt("KnifeInv", 1);
        if (SaveScripts.bat== true)
            PlayerPrefs.SetInt("BatInv", 1);
        if (SaveScripts.axe == true)
            PlayerPrefs.SetInt("AxeInv", 1);
        if (SaveScripts.gun == true)
            PlayerPrefs.SetInt("GunInv", 1);
        if (SaveScripts.crossbow == true)
            PlayerPrefs.SetInt("CrossbowInv", 1);
        if (SaveScripts.cabinKey == true)
            PlayerPrefs.SetInt("CabinK", 1);
        if (SaveScripts.roomKey == true)
            PlayerPrefs.SetInt("RoomK", 1);
        if (SaveScripts.houseKey == true)
            PlayerPrefs.SetInt("HouseK", 1);
        if (SaveScripts.arrowRefill == true)
            PlayerPrefs.SetInt("ArrowR", 1);

    }
}
