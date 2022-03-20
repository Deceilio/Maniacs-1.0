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
        if (SaveScripts.batteryPower > 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                if (nightVisionActive == false)
                {
                    myvolume.profile = nightVision;
                    nightVisionActive = true;
                    nightVisionOverlay.gameObject.SetActive(true);
                    SaveScripts.nVLightOn = true;
                }
                else
                {
                    myvolume.profile = standerd;
                    nightVisionActive = false;
                    nightVisionOverlay.gameObject.SetActive(false);
                    SaveScripts.nVLightOn = false;
                }
            }
        }
        if (SaveScripts.batteryPower <=0.0f)
        {
            myvolume.profile = standerd;
            nightVisionActive = false;
            nightVisionOverlay.gameObject.SetActive(false);
            SaveScripts.nVLightOn = false;
        }

    }
    // this block of code is for flashlight
    void FlashLight()
    {
        if (SaveScripts.batteryPower > 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (flashLightActive == false)
                {
                    flashLightActive = true;
                    flashLight.gameObject.SetActive(true);
                    SaveScripts.flashLightOn = true;
                }
                else
                {
                    flashLightActive = false;
                    flashLight.gameObject.SetActive(false);
                    SaveScripts.flashLightOn = false;
                }

            }

        }
        if (SaveScripts.batteryPower <=0.0f)
        {
            flashLightActive = false;
            flashLight.gameObject.SetActive(false);
            SaveScripts.flashLightOn = false;
        }
    }
}
