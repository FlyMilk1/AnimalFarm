using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCams : MonoBehaviour
{
    public RenderTexture RenderT;
    public RenderTexture FakeT;
    public Camera[] Cams;
    public AudioSource audio;
    int CurCam = 0;
    // Start is called before the first frame update
    private void Start()
    {
        CamsDO();
    }
    public void PrevCam()
    {
        if(CurCam > 0)
        {
            CurCam--;
            CamsDO();
            audio.Play();
        }
    }
    private void CamsDO()
    {
        foreach (var cam in Cams)
        {
            cam.targetTexture = FakeT;
        }
        Cams[CurCam].targetTexture = RenderT;
    }

    // Update is called once per frame
    public void NextCam()
    {
        if (CurCam < Cams.Length-1)
        {
            CurCam++;
            CamsDO();
            audio.Play();
        }
    }
}
