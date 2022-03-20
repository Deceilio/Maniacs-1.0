using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    //[SerializeField] Image myInventory;
    [SerializeField] GameObject inventoryPannel;
    private bool myInventoryActive = false;
    // Start is called before the first frame update
    void Start()
    {
        inventoryPannel.gameObject.SetActive(false);
        
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
            }
            else
            {
                myInventoryActive = false;
                inventoryPannel.gameObject.SetActive(false);
            }
        }
        
    }
}
