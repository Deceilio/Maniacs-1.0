using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator anim;
    public  bool isOpen = false;
   
    private AudioSource myplayer;
    [SerializeField] AudioClip cabinSound;
    [SerializeField] AudioClip roomSound;
    [SerializeField] AudioClip houseSound;
    [SerializeField] bool cabin;
    [SerializeField] bool room;
    [SerializeField] bool house;
    public bool locked;
    public string doorType;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myplayer = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (cabin == true)
        {
            doorType = "cabin";
            if (SaveScripts.cabinKey == true)
            {
                locked = false;
            }

        }
        if (house == true)
        {
            doorType = "house";
            if (SaveScripts.houseKey == true)
            {
                locked = false;
            }

        }
        if (room == true)
        {
            doorType = "room";
            if (SaveScripts.roomKey == true)
            {
                locked = false;
            }

        }

    }
    public void DoorOpen()
    {
        if (isOpen == false)
        {
            anim.SetTrigger("Open");
            isOpen = true;

            if (cabin == true)
            {
                myplayer.clip = cabinSound;
                myplayer.Play();
            }
            if (house == true)
            {
                myplayer.clip = houseSound;
                myplayer.Play();
            }
            if (room == true)
            {
                myplayer.clip = roomSound;
                myplayer.Play();
            }
        }
        else if (isOpen == true)
        {
            anim.SetTrigger("Close");
            isOpen = false;

            if (cabin == true)
            {
                myplayer.clip = cabinSound;
                myplayer.Play();
            }
            if (house == true)
            {
                myplayer.clip = houseSound;
                myplayer.Play();
            }
            if (room == true)
            {
                myplayer.clip = roomSound;
                myplayer.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {

        }
    }
}
