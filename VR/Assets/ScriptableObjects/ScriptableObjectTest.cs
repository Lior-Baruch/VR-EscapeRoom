using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestScriptable", menuName = "ScriptableObjects")]
public class ScriptableObjectTest : ScriptableObject
{
    public bool GarbageMissionComplete = false;
    public bool FireMissionComplete = false;
    public bool ThirdMissionComplete = false;
    // startMissionTimes
    public float StartTime = 0;
    public float StartTimeGarbageMission = 0;
    public float StartTimeFireMission = 0;
    // finishedMissionTimes
    public float finishTime = 0;
    public float finishTimeGarbageMission = 0;
    public float finishTimeFireMission = 0;


}
