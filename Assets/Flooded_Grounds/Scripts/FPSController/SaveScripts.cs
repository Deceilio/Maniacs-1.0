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
    public static bool haveCrossbow = false;
    public static bool haveAxe = false;
    public static bool newGame = false;
    public static bool savedGame = false;
    public static int bullets = 12;
    public static int arrows = 6;
    public static bool inventoryOpen = false;
    public static bool optionOpen = false;

    public static Transform target1;
    public static Transform target2;
    public static Transform target3;
    public static Transform target4;
    public static Transform target5;
    public static Transform target6;
    public static Transform target7;
    public static Transform target8;
    public static Transform target9;
    public static Transform target10;

    public static Transform playerCar;
    public static GameObject chase;
    public static GameObject hurtScreen;
    public static AudioSource stabSound;
    public static GameObject splatKnife;
    public static GameObject splatBat;
    public static GameObject splatAxe;
    public static Animator hurt;
    public static AudioSource audioP;
    public static GameObject arms;
    public static int maxEnemyOnScreen = 6;
    public static int enemyOnScreen = 0;
    public static int maxEnemiesInGame = 100;
    public static int enemiesCurrent = 0;
    public static int applesLeft = 10;
    public static int ammoLeft = 8;
    public static int batteryLeft = 6;
    public static int bowLeft = 4;
    public static int enemy1 = 1;
    public static int enemy2 = 1;
    public static int enemy3 = 1;
    public static int enemy4 = 1;


    [SerializeField] Transform _target1;
    [SerializeField] Transform _target2;
    [SerializeField] Transform _target3;
    [SerializeField] Transform _target4;
    [SerializeField] Transform _target5;
    [SerializeField] Transform _target6;
    [SerializeField] Transform _target7;
    [SerializeField] Transform _target8;
    [SerializeField] Transform _target9;
    [SerializeField] Transform _target10;

    [SerializeField] Transform playerPrefab;
    [SerializeField] GameObject chaseMusic;
    [SerializeField] GameObject hurtUI;
    [SerializeField] AudioSource stabPlayer;
    [SerializeField] GameObject bloodSplatKnife;
    [SerializeField] GameObject bloodSplatBat;
    [SerializeField] GameObject bloodSplatAxe;
    [SerializeField] Animator hurtAnim;
    [SerializeField] AudioSource myplayer;
    [SerializeField] GameObject fpsArms;

    private void Start()
    {
        target1 = _target1;
        target2 = _target2;
        target3 = _target3;
        target4 = _target4;
        target5 = _target5;
        target6 = _target6;
        target7 = _target7;
        target8 = _target8;
        target9 = _target9;
        target10 =_target10;
        playerCar = playerPrefab;
        chase = chaseMusic;
        hurtScreen = hurtUI;
        stabSound = stabPlayer;
        splatKnife = bloodSplatKnife;
        splatBat = bloodSplatBat;
        splatAxe = bloodSplatAxe;
        hurt = hurtAnim;
        audioP = myplayer;
        arms = fpsArms;

        

        if (newGame == true)
        {
             playerHealth = 100;
             healthChanged = true;
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
            newGame = false;
            applesLeft = 10;
            ammoLeft = 8;
            batteryLeft = 6;
            bowLeft = 4;
            enemy1 = 1;
            enemy2 = 1;
            enemy3 = 1;
            enemy4 = 1;
            inventoryOpen = false;
            optionOpen = false;


        }

        if (savedGame == true)
        {
            playerHealth = PlayerPrefs.GetInt("PlayersHealth");
            healthChanged = true;
            batteryPower = PlayerPrefs.GetFloat("BatteriesPower");
            apples = PlayerPrefs.GetInt("ApplesAmt");
            batteryes = PlayerPrefs.GetInt("BatteriesAmt");
            gunMag = PlayerPrefs.GetInt("BulletsClips");
            bullets = PlayerPrefs.GetInt("BulletAmt");
            arrows = PlayerPrefs.GetInt("ArrowsAmt");
            maxEnemyOnScreen = PlayerPrefs.GetInt("MaxEScreen");
            maxEnemiesInGame = PlayerPrefs.GetInt("MaxEGame");
            applesLeft = PlayerPrefs.GetInt("ApplesL");
            ammoLeft = PlayerPrefs.GetInt("AmmoL");
            batteryLeft = PlayerPrefs.GetInt("BatteryL");
            bowLeft = PlayerPrefs.GetInt("BowL");
            enemy1 = PlayerPrefs.GetInt("Enemy1Alive");
            enemy2 = PlayerPrefs.GetInt("Enemy2Alive");
            enemy3 = PlayerPrefs.GetInt("Enemy3Alive");
            enemy4 = PlayerPrefs.GetInt("Enemy4Alive");

            if (PlayerPrefs.GetInt("KnifeInv") == 1)
            {
                knife = true;
            }
            if (PlayerPrefs.GetInt("BatInv") == 1)
            {
                bat = true;
            }
            if (PlayerPrefs.GetInt("AxeInv") == 1)
            {
                axe = true;
            }
            if (PlayerPrefs.GetInt("GunInv") == 1)
            {
                gun = true;
            }
            if (PlayerPrefs.GetInt("CrossbowInv") == 1)
            {
                crossbow = true;
            }
            if (PlayerPrefs.GetInt("CabinK") == 1)
            {
                cabinKey= true;
            }
            if (PlayerPrefs.GetInt("RoomK") == 1)
            {
                roomKey = true;
            }
            if (PlayerPrefs.GetInt("HouseK") == 1)
            {
                houseKey= true;
            }
            if (PlayerPrefs.GetInt("ArrowR") == 1)
            {
                arrowRefill = true;
            }
            savedGame = false;
            inventoryOpen = false;
            optionOpen = false;

        }
    }

}
