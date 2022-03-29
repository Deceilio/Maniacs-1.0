using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunUIScripts : MonoBehaviour
{
    [SerializeField] Text bulletAmt;
    // Start is called before the first frame update
    void Start()
    {
        bulletAmt.text = SaveScripts.bullets + "";
    }

    // Update is called once per frame
    void Update()
    {
        bulletAmt.text = SaveScripts.bullets + "";
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (SaveScripts.bullets > 0)
            {
                SaveScripts.bullets -= 1;
                
            }
        }
    }
}
