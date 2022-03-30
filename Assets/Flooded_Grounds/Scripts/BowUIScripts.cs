using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowUIScripts : MonoBehaviour
{
    [SerializeField] Text bowAmt;
    // Start is called before the first frame update
    void Start()
    {
        bowAmt.text = SaveScripts.arrows + "";
    }

    // Update is called once per frame
    void Update()
    {
        bowAmt.text = SaveScripts.arrows + "";
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (SaveScripts.inventoryOpen == false && SaveScripts.optionOpen == false)
            {
                if (SaveScripts.arrows > 0)
                {
                    SaveScripts.arrows -= 1;

                }
            }
            
        }
    }
}
