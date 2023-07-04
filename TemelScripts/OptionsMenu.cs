using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
  public void EnDusuk()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void Orta()
    {
        QualitySettings.SetQualityLevel(2);
    }

    public void EnYuksek()
    {
        QualitySettings.SetQualityLevel(5);
    }

    public AudioMixer audioMixer;
    
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
