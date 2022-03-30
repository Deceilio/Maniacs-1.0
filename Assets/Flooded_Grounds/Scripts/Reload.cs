using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    [SerializeField] GameObject knife;
    [SerializeField] GameObject bat;
    [SerializeField] GameObject axe;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject crossbow;
    [SerializeField] GameObject cabinKey;
    [SerializeField] GameObject houseKey;
    [SerializeField] GameObject roomKey;
    [SerializeField] GameObject enemy1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitToDestroy());
    }

    // Update is called once per frame

    IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(1);
        if (SaveScripts.knife == true)
        {
            Destroy(knife.gameObject);
        }
        if (SaveScripts.bat == true)
        {
            Destroy(bat.gameObject);
        }
        if (SaveScripts.gun == true)
        {
            Destroy(gun.gameObject);
        }
        if (SaveScripts.axe == true)
        {
            Destroy(axe.gameObject);
        }
       
        if (SaveScripts.crossbow == true)
        {
            Destroy(crossbow.gameObject);
        }
        if (SaveScripts.cabinKey == true)
        {
            Destroy(cabinKey.gameObject);
        }
        if (SaveScripts.houseKey == true)
        {
            Destroy(houseKey.gameObject);
        }
        if (SaveScripts.roomKey == true)
        {
            Destroy(roomKey.gameObject);
        }


        if (SaveScripts.enemy1 == 0)
        {
            Destroy(enemy1.gameObject);
        }


    }
   
}
