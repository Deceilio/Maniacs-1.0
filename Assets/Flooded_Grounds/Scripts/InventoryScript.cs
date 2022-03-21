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
        batteryButton2.gameObject.SetActive(false);
        batteryImage2.gameObject.SetActive(false);
        batteryImage3.gameObject.SetActive(false);
        batteryButton3.gameObject.SetActive(false);
        batteryImage4.gameObject.SetActive(false);
        batteryButton4.gameObject.SetActive(false);
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

        SaveScripts.batteryes -= 1;
        myPlayer.clip = batteryChange;
        myPlayer.Play();

    }
}
