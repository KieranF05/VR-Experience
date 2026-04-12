using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action eventCradleActive;
    public event Action eventCradleDeactive;


    public void SetCradleActive()
    {
        
        if (eventCradleActive != null) 
        {
            eventCradleActive();
            
        }
            


    }

    public void SetCradleDeactive()
    {
       
        if (eventCradleDeactive != null)
        {
            eventCradleDeactive();
            
        }



    }


}


