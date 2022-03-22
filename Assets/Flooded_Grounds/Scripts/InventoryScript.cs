using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    //[SerializeField] Image myInventory;
    [SerializeField] GameObject inventoryPannel;
    private bool myInventoryActive = false;
    private AudioSource myPlayer;
    [SerializeField] AudioClip appleBite;
    [SerializeField] AudioClip batteryChange;
    [SerializeField] AudioClip WeaponChange;
    [SerializeField] AudioClip gunShort;
    [SerializeField] AudioClip arrowShort;
    [SerializeField] GameObject playerArms;
    [SerializeField] GameObject knife;
    [SerializeField] GameObject bat;
    [SerializeField] GameObject axe;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject crossbow;

    [SerializeField] Animator anim;


    //Apples
    [SerializeField] GameObject appleImage1;
    [SerializeField] GameObject appleButton1;
    [SerializeField] GameObject appleImage2;
    [SerializeField] GameObject appleButton2;
    [SerializeField] GameObject appleImage3;
    [SerializeField] GameObject appleButton3;
    [SerializeField] GameObject appleImage4;
    [SerializeField] GameObject appleButton4;
    [SerializeField] GameObject appleImage5;
    [SerializeField] GameObject appleButton5;
    [SerializeField] GameObject appleImage6;
    [SerializeField] GameObject appleButton6;

    //Battery
    [SerializeField] GameObject batteryImage1;
    [SerializeField] GameObject batteryButton1;
    [SerializeField] GameObject batteryImage2;
    [SerializeField] GameObject batteryButton2;
    [SerializeField] GameObject batteryImage3;
    [SerializeField] GameObject batteryButton3;
    [SerializeField] GameObject batteryImage4;
    [SerializeField] GameObject batteryButton4;

    // Weapons:
    [SerializeField] GameObject knifeImage;
    [SerializeField] GameObject knifeButton;
    [SerializeField] GameObject axeImage;
    [SerializeField] GameObject axeButton;
    [SerializeField] GameObject batImage;
    [SerializeField] GameObject batButton;
    [SerializeField] GameObject gunImage;
    [SerializeField] GameObject gunButton;
    [SerializeField] GameObject crossbowImage;
    [SerializeField] GameObject crossbowButton;

    // Weapons Utlity:
    [SerializeField] GameObject ammoImage1;
    [SerializeField] GameObject ammoButton1;
    [SerializeField] GameObject ammoImage2;
    [SerializeField] GameObject ammoButton2;
    [SerializeField] GameObject ammoImage3;
    [SerializeField] GameObject ammoButton3;
    [SerializeField] GameObject ammoImage4;
    [SerializeField] GameObject ammoButton4;
    [SerializeField] GameObject arrowImage1;
    [SerializeField] GameObject arrowButton1;

    //Keys:
    [SerializeField] GameObject cabinKey;
    [SerializeField] GameObject roomKey;
    [SerializeField] GameObject houseKey;


    // Start is called before the first frame update
    void Start()
    {
        inventoryPannel.gameObject.SetActive(false);
        myInventoryActive = false;
        Cursor.visible = false;
        myPlayer = GetComponent<AudioSource>();
       


        // Apples
        appleImage1.gameObject.SetActive(false);
        appleButton1.gameObject.SetActive(false);
        appleImage2.gameObject.SetActive(false);
        appleButton2.gameObject.SetActive(false);
        appleImage3.gameObject.SetActive(false);
        appleButton3.gameObject.SetActive(false);
        appleImage4.gameObject.SetActive(false);
        appleButton4.gameObject.SetActive(false);
        appleImage5.gameObject.SetActive(false);
        appleButton5.gameObject.SetActive(false);
        appleImage6.gameObject.SetActive(false);
        appleButton6.gameObject.SetActive(false);

        //Battery

        batteryImage1.gameObject.SetActive(false);
        batteryButton1.gameObject.SetActive(false);
        batteryButton2.gameObject.SetActive(false);
        batteryImage2.gameObject.SetActive(false);
        batteryImage3.gameObject.SetActive(false);
        batteryButton3.gameObject.SetActive(false);
        batteryImage4.gameObject.SetActive(false);
        batteryButton4.gameObject.SetActive(false);

        //Weapon

        knifeImage.gameObject.SetActive(false);
       knifeButton.gameObject.SetActive(false);
        axeImage.gameObject.SetActive(false);
        axeButton.gameObject.SetActive(false);
        batImage.gameObject.SetActive(false);
        batButton.gameObject.SetActive(false);
        crossbowImage.gameObject.SetActive(false);
        crossbowButton.gameObject.SetActive(false);
        gunImage.gameObject.SetActive(false);
        gunButton.gameObject.SetActive(false);

        // Weapon Utlity:

        ammoImage1.gameObject.SetActive(false);
        ammoButton1.gameObject.SetActive(false);
        ammoButton2.gameObject.SetActive(false);
        ammoImage2.gameObject.SetActive(false);
        ammoImage3.gameObject.SetActive(false);
        ammoButton3.gameObject.SetActive(false);
        ammoImage4.gameObject.SetActive(false);
        ammoButton4.gameObject.SetActive(false);
        arrowImage1.gameObject.SetActive(false);
        arrowButton1.gameObject.SetActive(false);

        //Keys:
        cabinKey.gameObject.SetActive(false);
        roomKey.gameObject.SetActive(false);
        houseKey.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (myInventoryActive == false)
            {
                myInventoryActive = true;
                inventoryPannel.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
                Cursor.visible = true;
            }
            else
            {
                myInventoryActive = false;
                inventoryPannel.gameObject.SetActive(false);
                Time.timeScale = 1.0f;
                Cursor.visible = false;
                    

            }
        }

        CheckInventory();
        CheckWeapons();
        WeaponUtlity();
        CheckKeys();


    }

    void CheckKeys()
    {
        if (SaveScripts.cabinKey == true)
        {
            cabinKey.gameObject.SetActive(true);
        }
        if (SaveScripts.roomKey == true)
        {
            roomKey.gameObject.SetActive(true);
        }
        if (SaveScripts.houseKey == true)
        {
            houseKey.gameObject.SetActive(true);
        }

    }
    void CheckInventory()
    { 
        // Apples

        if (SaveScripts.apples == 0)
        {
            
            appleImage1.gameObject.SetActive(false);
            appleButton1.gameObject.SetActive(false);
            appleImage2.gameObject.SetActive(false);
            appleButton2.gameObject.SetActive(false);
            appleImage3.gameObject.SetActive(false);
            appleButton3.gameObject.SetActive(false);
            appleImage4.gameObject.SetActive(false);
            appleButton4.gameObject.SetActive(false);
            appleImage5.gameObject.SetActive(false);
            appleButton5.gameObject.SetActive(false);
            appleImage6.gameObject.SetActive(false);
            appleButton6.gameObject.SetActive(false);

        }
        if (SaveScripts.apples == 1)
        {

            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(true);
            appleImage2.gameObject.SetActive(false);
            appleButton2.gameObject.SetActive(false);
            appleImage3.gameObject.SetActive(false);
            appleButton3.gameObject.SetActive(false);
            appleImage4.gameObject.SetActive(false);
            appleButton4.gameObject.SetActive(false);
            appleImage5.gameObject.SetActive(false);
            appleButton5.gameObject.SetActive(false);
            appleImage6.gameObject.SetActive(false);
            appleButton6.gameObject.SetActive(false);

        }
        if (SaveScripts.apples == 2)
        {

            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(false);
            appleImage2.gameObject.SetActive(true);
            appleButton2.gameObject.SetActive(true);
            appleImage3.gameObject.SetActive(false);
            appleButton3.gameObject.SetActive(false);
            appleImage4.gameObject.SetActive(false);
            appleButton4.gameObject.SetActive(false);
            appleImage5.gameObject.SetActive(false);
            appleButton5.gameObject.SetActive(false);
            appleImage6.gameObject.SetActive(false);
            appleButton6.gameObject.SetActive(false);

        }
        if (SaveScripts.apples == 3)
        {

            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(false);
            appleImage2.gameObject.SetActive(true);
            appleButton2.gameObject.SetActive(false);
            appleImage3.gameObject.SetActive(true);
            appleButton3.gameObject.SetActive(true);
            appleImage4.gameObject.SetActive(false);
            appleButton4.gameObject.SetActive(false);
            appleImage5.gameObject.SetActive(false);
            appleButton5.gameObject.SetActive(false);
            appleImage6.gameObject.SetActive(false);
            appleButton6.gameObject.SetActive(false);

        }
        if (SaveScripts.apples == 4)
        {

            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(false);
            appleImage2.gameObject.SetActive(true);
            appleButton2.gameObject.SetActive(false);
            appleImage3.gameObject.SetActive(true);
            appleButton3.gameObject.SetActive(false);
            appleImage4.gameObject.SetActive(true);
            appleButton4.gameObject.SetActive(true);
            appleImage5.gameObject.SetActive(false);
            appleButton5.gameObject.SetActive(false);
            appleImage6.gameObject.SetActive(false);
            appleButton6.gameObject.SetActive(false);

        }
        if (SaveScripts.apples == 5)
        {

            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(false);
            appleImage2.gameObject.SetActive(true);
            appleButton2.gameObject.SetActive(false);
            appleImage3.gameObject.SetActive(true);
            appleButton3.gameObject.SetActive(false);
            appleImage4.gameObject.SetActive(true);
            appleButton4.gameObject.SetActive(false);
            appleImage5.gameObject.SetActive(true);
            appleButton5.gameObject.SetActive(true);
            appleImage6.gameObject.SetActive(false);
            appleButton6.gameObject.SetActive(false);

        }
        if (SaveScripts.apples == 6)
        {

            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(false);
            appleImage2.gameObject.SetActive(true);
            appleButton2.gameObject.SetActive(false);
            appleImage3.gameObject.SetActive(true);
            appleButton3.gameObject.SetActive(false);
            appleImage4.gameObject.SetActive(true);
            appleButton4.gameObject.SetActive(false);
            appleImage5.gameObject.SetActive(true);
            appleButton5.gameObject.SetActive(false);
            appleImage6.gameObject.SetActive(true);
            appleButton6.gameObject.SetActive(true);

        }
        //Battery

        if (SaveScripts.batteryes == 0)
        {
            batteryImage1.gameObject.SetActive(false);
            batteryButton1.gameObject.SetActive(false);
            batteryImage2.gameObject.SetActive(false);
            batteryButton2.gameObject.SetActive(false);
            batteryImage3.gameObject.SetActive(false);
            batteryButton3.gameObject.SetActive(false);
            batteryImage4.gameObject.SetActive(false);
            batteryButton4.gameObject.SetActive(false);
        }

        if(SaveScripts.batteryes == 1)
        {
            batteryImage1.gameObject.SetActive(true);
            batteryButton1.gameObject.SetActive(true);
            batteryImage2.gameObject.SetActive(false);
            batteryButton2.gameObject.SetActive(false);
            batteryImage3.gameObject.SetActive(false);
            batteryButton3.gameObject.SetActive(false);
            batteryImage4.gameObject.SetActive(false);
            batteryButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.batteryes == 2)
        {
            batteryImage1.gameObject.SetActive(true);
            batteryButton1.gameObject.SetActive(false);
            batteryImage2.gameObject.SetActive(true);
            batteryButton2.gameObject.SetActive(true);
            batteryImage3.gameObject.SetActive(false);
            batteryButton3.gameObject.SetActive(false);
            batteryImage4.gameObject.SetActive(false);
            batteryButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.batteryes == 3)
        {
            batteryImage1.gameObject.SetActive(true);
            batteryButton1.gameObject.SetActive(false);
            batteryImage2.gameObject.SetActive(true);
            batteryButton2.gameObject.SetActive(false);
            batteryImage3.gameObject.SetActive(true);
            batteryButton3.gameObject.SetActive(true);
            batteryImage4.gameObject.SetActive(false);
            batteryButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.batteryes == 4)
        {
            batteryImage1.gameObject.SetActive(true);
            batteryButton1.gameObject.SetActive(false);
            batteryImage2.gameObject.SetActive(true);
            batteryButton2.gameObject.SetActive(false);
            batteryImage3.gameObject.SetActive(true);
            batteryButton3.gameObject.SetActive(false);
            batteryImage4.gameObject.SetActive(true);
            batteryButton4.gameObject.SetActive(true);
        }

    }

    void CheckWeapons()
    {
        if (SaveScripts.knife == true)
        {
            knifeImage.gameObject.SetActive(true);
            knifeButton.gameObject.SetActive(true);
            
        }
        if (SaveScripts.axe == true)
        {
            
            axeImage.gameObject.SetActive(true);
            axeButton.gameObject.SetActive(true);
           
        }
        if (SaveScripts.bat == true)
        {
            
            batImage.gameObject.SetActive(true);
            batButton.gameObject.SetActive(true);
            
        }
        if (SaveScripts.crossbow == true)
        {
      
            crossbowImage.gameObject.SetActive(true);
            crossbowButton.gameObject.SetActive(true);
           
        }
        if (SaveScripts.gun == true)
        {
         
            gunImage.gameObject.SetActive(true);
            gunButton.gameObject.SetActive(true);
        }
    }

    void WeaponUtlity()
    {
        if (SaveScripts.gunMag == 0)
        {

            ammoImage1.gameObject.SetActive(false);
            ammoButton1.gameObject.SetActive(false);
            ammoButton2.gameObject.SetActive(false);
            ammoImage2.gameObject.SetActive(false);
            ammoImage3.gameObject.SetActive(false);
            ammoButton3.gameObject.SetActive(false);
            ammoImage4.gameObject.SetActive(false);
            ammoButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.gunMag == 1)
        {

            ammoImage1.gameObject.SetActive(true);
            ammoButton1.gameObject.SetActive(true);
            ammoButton2.gameObject.SetActive(false);
            ammoImage2.gameObject.SetActive(false);
            ammoImage3.gameObject.SetActive(false);
            ammoButton3.gameObject.SetActive(false);
            ammoImage4.gameObject.SetActive(false);
            ammoButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.gunMag == 2)
        {

            ammoImage1.gameObject.SetActive(true);
            ammoButton1.gameObject.SetActive(false);
            ammoButton2.gameObject.SetActive(true);
            ammoImage2.gameObject.SetActive(true);
            ammoImage3.gameObject.SetActive(false);
            ammoButton3.gameObject.SetActive(false);
            ammoImage4.gameObject.SetActive(false);
            ammoButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.gunMag == 3)
        {

            ammoImage1.gameObject.SetActive(true);
            ammoButton1.gameObject.SetActive(false);
            ammoButton2.gameObject.SetActive(false);
            ammoImage2.gameObject.SetActive(true);
            ammoImage3.gameObject.SetActive(true);
            ammoButton3.gameObject.SetActive(true);
            ammoImage4.gameObject.SetActive(false);
            ammoButton4.gameObject.SetActive(false);
        }
        if (SaveScripts.gunMag == 4)
        {

            ammoImage1.gameObject.SetActive(true);
            ammoButton1.gameObject.SetActive(false);
            ammoButton2.gameObject.SetActive(false);
            ammoImage2.gameObject.SetActive(true);
            ammoImage3.gameObject.SetActive(true);
            ammoButton3.gameObject.SetActive(false);
            ammoImage4.gameObject.SetActive(true);
            ammoButton4.gameObject.SetActive(true);
        }
        if (SaveScripts.arrowRefill==false)
        {
            arrowImage1.gameObject.SetActive(false);
            arrowButton1.gameObject.SetActive(false);
        }
        if (SaveScripts.arrowRefill==true)
        {
            arrowImage1.gameObject.SetActive(true);
            arrowButton1.gameObject.SetActive(true);
        }
    }
    public void HealthUpdate()
    {  if(SaveScripts.playerHealth <100)
        {
            SaveScripts.playerHealth += 10;
            SaveScripts.healthChanged = true;
            SaveScripts.apples -= 1;
            myPlayer.clip = appleBite;
            myPlayer.Play();

            if (SaveScripts.playerHealth > 0)
            {
                SaveScripts.playerHealth = 100;
            }
        }

        
       
    }
    public void BattryUpdate()
    {
        SaveScripts.batteryRefill = true;
        SaveScripts.batteryPower += 1;
        SaveScripts.batteryes -= 1;
        myPlayer.clip = batteryChange;
        myPlayer.Play();

    }
    public void AssignKnife()
    {
        playerArms.gameObject.SetActive(true);
        knife.gameObject.SetActive(true);
        anim.SetBool("Malee", true);
        myPlayer.clip = WeaponChange;
        myPlayer.Play();


    }
    public void AssignBat()
    {
        playerArms.gameObject.SetActive(true);
        bat.gameObject.SetActive(true);
        anim.SetBool("Malee", true);
        myPlayer.clip = WeaponChange;
        myPlayer.Play();


    }
    public void AssignAxe()
    {
        playerArms.gameObject.SetActive(true);
        axe.gameObject.SetActive(true);
        anim.SetBool("Malee", true);
        myPlayer.clip = WeaponChange;
        myPlayer.Play();


    }
    public void AssignGun()
    {
        playerArms.gameObject.SetActive(true);
        gun.gameObject.SetActive(true);
        anim.SetBool("Malee", false);
        myPlayer.clip = gunShort;
        myPlayer.Play();


    }
    public void AssignCrossbow()
    {
        playerArms.gameObject.SetActive(true);
        crossbow.gameObject.SetActive(true);
        anim.SetBool("Malee", false);
        myPlayer.clip = arrowShort;
        myPlayer.Play();


    }
    public void WeaponsOff()
    {
        axe.gameObject.SetActive(false);
        bat.gameObject.SetActive(false);
        knife.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        crossbow.gameObject.SetActive(false);
    }
}
