using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioControler : MonoBehaviour
{
    //meu codigo todo fudido n funciona essa desgraçaaaaaa
    /*[Header("Volume")]
    [Range(0, 1)]
    public float MasterVolume = 1;
    [Range(0,1)]
    private Bus MasterBus;
    public void Awake(){
        MasterBus = RuntimeManager.GetBus("Bus:/");
    }
    public void Update(){
        MasterBus.setVolume(MasterVolume);

    }*/
    //codigo david
    FMOD.Studio.Bus Master;
    float MasterVolume = 1f;
    void Awake(){
        Master = FMODUnity.RuntimeManager.GetBus("bus:/");
    }
    void Update(){
        Master.setVolume(MasterVolume);
    }
    public void MasterVolumeLevel(float newMasterVolume){
        MasterVolume = newMasterVolume;
    }


}
