using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeChange : MonoBehaviour
{

    public Slider slider;
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(changeVolume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVolume(float vol)
    {
        if (vol == slider.minValue)
        {
            mixer.SetFloat("MusicVol", -80);
        }
        else
        {
            mixer.SetFloat("MusicVol", vol);
        }
    }
}
