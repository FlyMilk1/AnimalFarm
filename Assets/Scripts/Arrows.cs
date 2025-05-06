using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Arrows : MonoBehaviour
{
    public ChangeCams ChangeCams;
    public bool TrueForRight;
    public Material Mat;
    Color OldColors;
    float adjIntensity = 1.4f;
    
    // Start is called before the first frame update
    void Start()
    {
        OldColors = Mat.GetColor("_Color");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        
        
        
        Color color = OldColors * adjIntensity;
        Mat.SetColor("_EmissionColor", color);
    }
    
    public void OnMouseExit()
    {
        
        
        
        Mat.SetColor("_EmissionColor", OldColors);
    }


    private void OnMouseDown()
    {
        
        if(TrueForRight)
        {
            ChangeCams.NextCam();
        }
        else
        {
            ChangeCams.PrevCam();
        }
    }
}
