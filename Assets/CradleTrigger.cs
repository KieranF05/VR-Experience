using UnityEngine;
using System;
public class CradleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleActive();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleDeactive();
        }
    }

}
