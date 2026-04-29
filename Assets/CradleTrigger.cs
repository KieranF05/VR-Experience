using UnityEngine;
using System;
public class CradleTrigger : MonoBehaviour
{
    public AudioSource generatorAudio;
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleActive();
        }

        if (generatorAudio != null)
        {
            generatorAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleDeactive();
        }
        
        if (generatorAudio != null)
        {
            generatorAudio.Play();
        }

    }


}
