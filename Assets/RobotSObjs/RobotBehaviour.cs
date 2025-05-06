using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RobotBehaviour", menuName = "ScriptableObjects/RobotBehaviour", order = 1)]
public class RobotBehaviour : ScriptableObject
{
    public Vector2 SecondRandom;
    public int[] Route1;
    public int[] Route2;
    public Vector3[] Positions;
    
}
