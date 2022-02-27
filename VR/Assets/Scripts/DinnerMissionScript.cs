using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnerMissionScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public GameObject FinishedMissionUI;
    public GameObject CurrentMusicObject;
    public int NumOfPlatesToSet;

    private new AudioSource audio;
    // Start is called before the first frame update
    private void Start()
    {
        audio = CurrentMusicObject.GetComponent<AudioSource>();
    }
    public void FoodOnPlate()
    {
        NumOfPlatesToSet--;
        CheckIfMissionComplete();
    }
    public void FoodOffPlate()
    {
        NumOfPlatesToSet++;
        CheckIfMissionComplete();
    }

    private void CheckIfMissionComplete()
    {
        if (NumOfPlatesToSet == 0)
        {
            //Mission Complete
            GameStatus.FinishTimeDinnerMission = Time.realtimeSinceStartup;
            GameStatus.FinishTime = Time.realtimeSinceStartup;

            GameStatus.TotalTimeDinnerMission = GameStatus.FinishTimeDinnerMission - GameStatus.StartTimeDinnerMission;
            GameStatus.TotalTime = GameStatus.FinishTime - GameStatus.StartTime;           
            FinishedMissionUI.SetActive(true);
            audio.Stop();
            
        }
        
    }
}
