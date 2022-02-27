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
    public bool DinnerMissionComplete = false;
    // startMissionTimes
    public float StartTime = -1;
    public float StartTimeGarbageMission = -1;
    public float StartTimeFireMission = -1;
    public float StartTimeDinnerMission = -1;
    // finishedMissionTimes
    public float FinishTime = -1;
    public float FinishTimeGarbageMission = -1;
    public float FinishTimeFireMission = -1;
    public float FinishTimeDinnerMission = -1;

    //totalMissionTime
    public float TotalTime = -1;
    public float TotalTimeGarbageMission = -1;
    public float TotalTimeFireMission = -1;
    public float TotalTimeDinnerMission = -1;


    private void OnEnable()
    {
        //load PrevID from prev run
        UserID = PlayerPrefs.GetInt("prevID", -1) + 1;

        //save PrevID for next run
        PlayerPrefs.SetInt("prevID", UserID);
    }

    private void OnDisable()
    {
        //store time for each mission
        if (GarbageMissionComplete)
            PlayerPrefs.SetFloat(UserID + "GarbageMission", TotalTimeGarbageMission);
        if (FireMissionComplete)
            PlayerPrefs.SetFloat(UserID + "FireMission", TotalTimeFireMission);
        if (DinnerMissionComplete)
            PlayerPrefs.SetFloat(UserID + "DinnerMission", TotalTimeDinnerMission);
        //store time for total escape room
        if (GarbageMissionComplete && FireMissionComplete && DinnerMissionComplete)
            PlayerPrefs.SetFloat(UserID + "EscapeRoomMission", TotalTime);
        //save stored values in disk
        PlayerPrefs.Save();
    }





}
