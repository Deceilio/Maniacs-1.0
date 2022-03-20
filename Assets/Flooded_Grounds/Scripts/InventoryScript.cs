﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    //[SerializeField] Image myInventory;
    [SerializeField] GameObject inventoryPannel;
    private bool myInventoryActive = false;

    [SerializeField] GameObject appleImage1;
    [SerializeField] GameObject appleButton1;
    // Start is called before the first frame update
    void Start()
    {
        inventoryPannel.gameObject.SetActive(false);
        myInventoryActive = false;
        Cursor.visible = false;
        appleImage1.gameObject.SetActive(false);
        appleButton1.gameObject.SetActive(false);

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
        if (SaveScripts.apples == 1)
        {
            appleImage1.gameObject.SetActive(true);
            appleButton1.gameObject.SetActive(true);
        }
    }
}
