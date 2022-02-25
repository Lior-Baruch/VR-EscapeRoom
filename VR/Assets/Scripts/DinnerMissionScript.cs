using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnerMissionScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public GameObject FinishedMissionUI;
    public int NumOfPlatesToSet;
    // Start is called before the first frame update
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
            GameStatus.TotalTimeDinnerMission = GameStatus.FinishTimeDinnerMission - GameStatus.StartTimeDinnerMission;

            FinishedMissionUI.SetActive(true);
            
        }
        
    }
}
