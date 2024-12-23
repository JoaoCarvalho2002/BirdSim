using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Audio : MonoBehaviour
{
    public AudioMixer theMixer;
    public Slider slidermaster;
    public void SetMasterVol(float Mastervol1)
    {
        theMixer.SetFloat("Mastervol",Mastervol1);

    }
}
