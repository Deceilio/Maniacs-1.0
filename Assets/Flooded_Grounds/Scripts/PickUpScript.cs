using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float distance = 4.0f;
    [SerializeField] GameObject pickupMessage;

    private bool canSeePickup = false;
    private float rayDistance;

    // Start is called before the first frame update
    void Start()
    {

        pickupMessage.gameObject.SetActive(false);
        rayDistance = distance;

    }

    // Update is called once per frame
    void Update()
    {  // pickup massage scripts using raycast
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if(hit.transform.tag == "Apple")
            {
                canSeePickup = true;
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.apples < 6)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.apples += 1;
                    }
                   
                }
            }
           

           else if ( hit.transform.tag == "Baterry")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.batteryes < 4)
                    {
                        Destroy(hit.transform.gameObject);

                        SaveScripts.batteryes += 1;
                    }
                    
                }
            }
            else
            {
                canSeePickup = false;
            }

        }
        if (canSeePickup == true)
        {
            pickupMessage.gameObject.SetActive(true);
            rayDistance = 1000f;
        }
        if (canSeePickup == false)
        {
            pickupMessage.gameObject.SetActive(false);
            rayDistance = distance;
        }

    }
}
