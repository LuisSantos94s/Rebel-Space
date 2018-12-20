using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour {

    public AudioMixer masterMixer;

    public void MusicVolume (float music)
    {
        masterMixer.SetFloat("Music", music);
    }

    public void EffectVolume(float effect)
    {
        masterMixer.SetFloat("Effect", effect);
    }
}
