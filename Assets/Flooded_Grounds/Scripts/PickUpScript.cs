using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float distance = 4.0f;
    [SerializeField] GameObject pickupMessage;
    [SerializeField] GameObject playerArms;
    private AudioSource myplayer;


    private bool canSeeDoor = false;
    [SerializeField] GameObject doorMessage;
    [SerializeField] Text doorText;

    //[SerializeField] DoorScript door;
    private bool canSeePickup = false;
    private float rayDistance;

    // Start is called before the first frame update
    void Start()
    {
        

        pickupMessage.gameObject.SetActive(false);
        doorMessage.gameObject.SetActive(false);
        rayDistance = distance;
        myplayer = GetComponent<AudioSource>();
        playerArms.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {  // pickup massage scripts using raycast
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
           
            if (hit.transform.tag == "Door")
            {
                canSeeDoor = true;
                if (hit.transform.gameObject.GetComponent<DoorScript>().locked == false)
                {


                    if (hit.transform.gameObject.GetComponent<DoorScript>().isOpen == false)
                    {
                        doorText.text = "Press E to Open";
                    }
                    if (hit.transform.gameObject.GetComponent<DoorScript>().isOpen == true)
                    {
                        doorText.text = "Press E to Close";
                    }
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        hit.transform.gameObject.SendMessageUpwards("DoorOpen");

                    }
                }
                else if (hit.transform.gameObject.GetComponent<DoorScript>().locked == true)
                {
                    doorText.text = "You need the " + hit.transform.gameObject.GetComponent<DoorScript>().doorType + " key";
                }
            }

            else if (hit.transform.tag == "Apple")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.apples < 6)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.applesLeft--;
                        SaveScripts.apples += 1;
                        myplayer.Play();
                    }

                }
            }


            else if (hit.transform.tag == "GunMag")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.gunMag < 4)
                    {
                        Destroy(hit.transform.gameObject);
                        
                        SaveScripts.gunMag ++;
                        SaveScripts.ammoLeft--;
                        myplayer.Play();
                    }

                }
            }

            else if (hit.transform.tag == "Arrow")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.arrowRefill == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.arrowRefill = true;
                        SaveScripts.bowLeft--;
                        myplayer.Play();
                    }

                }
            }
            else if (hit.transform.tag == "CabinK")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.cabinKey == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.cabinKey = true;
                        myplayer.Play();
                    }

                }
            }
            else if (hit.transform.tag == "RoomK")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.roomKey == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.roomKey = true;
                        myplayer.Play();
                    }

                }
            }
            else if (hit.transform.tag == "HouseK")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.houseKey == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.houseKey = true;
                        myplayer.Play();
                    }

                }
            }
            else if (hit.transform.tag == "Bat")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.bat == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.bat = true;
                        myplayer.Play();
                    }

                }

            }
            else if (hit.transform.tag == "Axe")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.axe == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.axe = true;
                        myplayer.Play();
                    }

                }

            }
            else if (hit.transform.tag == "Crossbow")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.crossbow == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.crossbow = true;
                        myplayer.Play();
                    }

                }

            }
            else if (hit.transform.tag == "Gun")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.gun == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.gun = true;
                        myplayer.Play();
                    }

                }

            }
            else if (hit.transform.tag == "Knife")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.knife == false)
                    {
                        Destroy(hit.transform.gameObject);
                        SaveScripts.knife = true;
                        myplayer.Play();
                    }

                }

            }




            else if (hit.transform.tag == "Baterry")
            {
                canSeePickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SaveScripts.batteryes < 4)
                    {
                        Destroy(hit.transform.gameObject);

                        SaveScripts.batteryes += 1;
                        SaveScripts.batteryLeft--;
                        myplayer.Play();
                    }

                }
            }
            else
            {
                canSeePickup = false;
                canSeeDoor = false;
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
        if (canSeeDoor == true)
        {
            doorMessage.gameObject.SetActive(true);
            rayDistance = 1000f;
        }
        if (canSeeDoor == false)
        {
            doorMessage.gameObject.SetActive(false);
            rayDistance = distance;
        }
    }
}
