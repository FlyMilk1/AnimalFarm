using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideLook : MonoBehaviour
{
    public GameObject camera;
    public GameObject arrows;
    public int Looking = 0;
    Animator lookanim;
    bool UsingPc = false;
    // Start is called before the first frame update
    void Start()
    {
        lookanim = camera.GetComponent<Animator>();
    }
    void Update()
    {
        if (!UsingPc)
        {
            if (Input.GetKey("d") && Input.GetKey("a") == false && Looking != 3)
            {
                //lookanim.speed = 1;
                
                lookanim.ResetTrigger("Idle");
                lookanim.SetTrigger("LookRight");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 1;
            }
            else if (Looking == 1)
            {
                //lookanim.speed = -1;
                
                lookanim.ResetTrigger("LookRight");
                lookanim.SetTrigger("Idle");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 0;
            }
            if (Input.GetKey("a") && Input.GetKey("d") == false && Looking != 3)
            {
                //lookanim.speed = 1;
                
                lookanim.ResetTrigger("Idle");
                lookanim.SetTrigger("LookLeft");
                //lookanim.Play("LookRight", -1, 1);
                Looking = -1;
            }
            else if (Looking == -1)
            {
                //lookanim.speed = -1;
                
                lookanim.ResetTrigger("LookLeft");
                lookanim.SetTrigger("Idle");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 0;
            }
            if (Input.GetKey("w") && Looking != -1 && Looking != 1)
            {
                //lookanim.speed = 1;
                ;
                lookanim.ResetTrigger("Idle");
                lookanim.SetTrigger("LookUp");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 3;
            }
            else if (Looking == 3)
            {
                //lookanim.speed = -1;
               
                lookanim.ResetTrigger("LookUp");
                lookanim.SetTrigger("Idle");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            UsingPc = !UsingPc;
            if (UsingPc)
            {
                arrows.SetActive(true);
                lookanim.ResetTrigger("Idle");
                lookanim.SetTrigger("Zoom");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 2;
            }
            else if (!UsingPc)
            {
                arrows.SetActive(false);
                lookanim.ResetTrigger("Zoom");
                lookanim.SetTrigger("Idle");
                //lookanim.Play("LookRight", -1, 1);
                Looking = 0;
            }
            
            
            
        }
        
    }
}
