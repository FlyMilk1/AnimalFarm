using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
    
{
    public GameObject Flashlight;
    public SideLook sl;
    public AudioSource flashaudio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sl.Looking == 1 || sl.Looking == -1 || sl.Looking == 3)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                flashaudio.Play();
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                flashaudio.Play();
            }
        }

            
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if(sl.Looking == 1 || sl.Looking == -1 || sl.Looking == 3)
            {
                
                Flashlight.SetActive(true);
                
            }
            else
            {
                Flashlight.SetActive(false);
            }


        }
        else
        {
            Flashlight.SetActive(false);
        }
    }
}
