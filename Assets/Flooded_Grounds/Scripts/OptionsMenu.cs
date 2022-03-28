using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] GameObject visualPanel;
    [SerializeField] GameObject soundsPanel;
    [SerializeField] GameObject controlsPanel;
    [SerializeField] GameObject difficultyPanel;
    [SerializeField] GameObject savePanel;
    [SerializeField] GameObject backToMenuPanel;
    [SerializeField] PostProcessLayer myLaye;
    public Slider lightSlider;
    public Toggle fogToggle;
    public Toggle antiOff;
    public Toggle antiFXAA;
    public Toggle antiSMAA;
    public Toggle antiTAA;
    public bool fogOn = true;
    private int antiState = 4;
    public Slider ambienceLevel;
    public Slider sfxLevel;
    public AudioMixer ambienceMixer;
    public AudioMixer sfxMixer;




    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Time.timeScale = 0;
        visualPanel.gameObject.SetActive(true);
        soundsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(false);
        savePanel.gameObject.SetActive(false);
        backToMenuPanel.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Time.timeScale = 0;
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LightValue()
    {
        RenderSettings.ambientIntensity = lightSlider.value;
    }

    public void AmbienceVolume()
    {
        ambienceMixer.SetFloat("Volume", ambienceLevel.value);
    }
    public void SFXVolume()
    {
        sfxMixer.SetFloat("Volume", sfxLevel.value);
    }
    public void FogState()
    {
        if (fogToggle.isOn == true)
        {
            if (fogOn == true)
            {
                myLaye.fog.enabled = false;
                fogOn = false;
            }
        }
        else if (fogOn == false)
        {
            myLaye.fog.enabled = true;
            fogOn = true;
        }
        if (fogToggle.isOn == false)
        {
            if (fogOn == true)
            {
                myLaye.fog.enabled = false;
                fogOn = false;
            }
        }
        else if (fogOn == false)
        {
            myLaye.fog.enabled = true;
            fogOn = true;
        }

    }
    public void AntiAliasingoff()
    {
        if (antiState != 1)
        {
            if(antiOff.isOn==true)
            {
                myLaye.antialiasingMode = PostProcessLayer.Antialiasing.None;
                antiFXAA.isOn = false;
                antiSMAA.isOn = false;
                antiTAA.isOn = false;
                antiState = 1;
            }        }
    }
    public void AntiAliasingFXAA()
    {
        if (antiState != 2)
        {
            if (antiFXAA.isOn == true)
            {
                myLaye.antialiasingMode = PostProcessLayer.Antialiasing.FastApproximateAntialiasing;
                antiOff.isOn = false;
                antiSMAA.isOn = false;
                antiTAA.isOn = false;
                antiState = 2;
            }
        }
    }
    public void AntiAliasingSMAA()
    {
        if (antiState != 3)
        {
            if (antiSMAA.isOn == true)
            {
                myLaye.antialiasingMode = PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing;
                antiOff.isOn = false;
                antiFXAA.isOn = false;
                antiTAA.isOn = false;
                antiState = 3;
            }
        }
    }
    public void AntiAliasingTAA()
    {
        if (antiState != 4)
        {
            if (antiTAA.isOn == true)
            {
                myLaye.antialiasingMode = PostProcessLayer.Antialiasing.TemporalAntialiasing;
                antiOff.isOn = false;
                antiFXAA.isOn = false;
                antiSMAA.isOn = false;
                antiState = 4;
            }
        }
    }
    public void Visuals()
    {
        visualPanel.gameObject.SetActive(true);
        soundsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(false);
        savePanel.gameObject.SetActive(false);
        backToMenuPanel.gameObject.SetActive(false);

    }
    public void Sounds()
    {
        visualPanel.gameObject.SetActive(false);
        soundsPanel.gameObject.SetActive(true);
        controlsPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(false);
        savePanel.gameObject.SetActive(false);
        backToMenuPanel.gameObject.SetActive(false);

    }
    public void Control()
    {
        visualPanel.gameObject.SetActive(false);
        soundsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(true);
        difficultyPanel.gameObject.SetActive(false);
        savePanel.gameObject.SetActive(false);
        backToMenuPanel.gameObject.SetActive(false);

    }
    public void Difficulty()
    {
        visualPanel.gameObject.SetActive(false);
        soundsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(true);
        savePanel.gameObject.SetActive(false);
        backToMenuPanel.gameObject.SetActive(false);

    }
    public void Save()
    {
        visualPanel.gameObject.SetActive(false);
        soundsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(false);
        savePanel.gameObject.SetActive(true);
        backToMenuPanel.gameObject.SetActive(false);

    }
    public void BackToMenu()
    {
        visualPanel.gameObject.SetActive(false);
        soundsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(false);
        savePanel.gameObject.SetActive(false);
        backToMenuPanel.gameObject.SetActive(true);

    }
}
