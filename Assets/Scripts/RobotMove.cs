using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class RobotMove : MonoBehaviour
{
    public RobotBehaviour rb;
    public Transform RobotTransform;
    int CurStage = 1;
    bool Paused = false;
    Stopwatch stopwatch = new Stopwatch();
    int LastRoute = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        RobotTransform.position = rb.Positions[0];
        if (!Paused )
        {
            
            stopwatch.Start();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (stopwatch.ElapsedMilliseconds >= Random.Range(rb.SecondRandom.x, rb.SecondRandom.y)*1000)
        {
            
            if (rb.Route1[CurStage] == rb.Route2[CurStage])
            {
                RobotTransform.position = rb.Positions[rb.Route1[CurStage]];
            }
            else
            {
                if(LastRoute == 0)
                {
                    int r = Random.Range(1, 3);
                    if (r == 1)
                    {
                        RobotTransform.position = rb.Positions[rb.Route1[CurStage]];
                        LastRoute = 1;
                    }
                    else
                    {
                        RobotTransform.position = rb.Positions[rb.Route2[CurStage]];
                        LastRoute = 2;
                    }
                }
                else if(LastRoute == 1)
                {
                    RobotTransform.position = rb.Positions[rb.Route1[CurStage]];
                }
                else
                {
                    RobotTransform.position = rb.Positions[rb.Route2[CurStage]];
                }
                
                
            }
            UnityEngine.Debug.Log("Moved");
            if(CurStage < rb.Positions.Length - 1)
            {
                CurStage++;
            }
            
            stopwatch.Reset();
            stopwatch.Start();
            
        }
    }
}
