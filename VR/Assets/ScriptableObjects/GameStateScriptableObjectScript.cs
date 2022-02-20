using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestScriptable", menuName = "ScriptableObjects")]
public class GameStateScriptableObjectScript : ScriptableObject
{
    //user id = prevID + 1
    public int UserID;//= PlayerPrefs.GetInt("prevID", 0) + 1;

    // Mission status
    public bool GarbageMissionComplete = false;
    public bool FireMissionComplete = false;
    public bool ThirdMissionComplete = false;
    // startMissionTimes
    public float StartTime = -1;
    public float StartTimeGarbageMission = -1;
    public float StartTimeFireMission = -1;
    // finishedMissionTimes
    public float finishTime = -1;
    public float finishTimeGarbageMission = -1;
    public float finishTimeFireMission = -1;
    //totalMissionTime
    public float TotalTime = -1;
    public float TotalTimeGarbageMission = -1;
    public float TotalTimeFireMission = -1;

    private void OnEnable()
    {
        //load PrevID from prev run
        UserID = PlayerPrefs.GetInt("prevID", -1) + 1;

        //save PrevID for next run
        PlayerPrefs.SetInt("prevID", UserID);
    }

    private void OnDestroy()
    {
        
    }




}
