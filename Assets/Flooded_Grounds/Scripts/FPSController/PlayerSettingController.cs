using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class PlayerSettingController : MonoBehaviour
{
    [SerializeField] PostProcessVolume myvolume;
    [SerializeField] PostProcessProfile standerd;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;
    [SerializeField] GameObject flashLight;

    private bool nightVisionActive = false;
    private bool flashLightActive = false;
    // Start is called before the first frame update
    void Start()
    {
        nightVisionOverlay.gameObject.SetActive(false);
        flashLight.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        NightVision();
        FlashLight();


    }
    // This block of code is for night vision
    void NightVision()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (nightVisionActive == false)
            {
                myvolume.profile = nightVision;
                nightVisionActive = true;
                nightVisionOverlay.gameObject.SetActive(true);
            }
            else
            {
                myvolume.profile = standerd;
                nightVisionActive = false;
                nightVisionOverlay.gameObject.SetActive(false);
            }
        }

    }
    // this block of code is for flashlight
    void FlashLight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashLightActive == false)
            {
                flashLightActive = true;
                flashLight.gameObject.SetActive(true);
            }
            else
            {
                flashLightActive = false;
                flashLight.gameObject.SetActive(false);
            }

        }
        
    }
}
