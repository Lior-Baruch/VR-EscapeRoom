using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnerWareMissionScript : MonoBehaviour
{
    //public GameObject Foods;
    public GameStateScriptableObjectScript GameStatus;
    public GameObject FinishedMissionUI;
    public int NumOfPlatesToSet;
    public int NumOfKnifesToSet;
    public int NumOfForksToSet;
    public int NumOfCupsToSet;

    // Start is called before the first frame update
    void Start()
    {
        GameStatus.StartTimeDinnerMission = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Plate enter\exit socket
    public void OnPlateEnter()
    {
        NumOfPlatesToSet--;
        CheckIfMissionComplete();
    }
    public void OnPlateExit()
    {
        NumOfPlatesToSet++;
        CheckIfMissionComplete();
    }
    // Knife enter\exit socket
    public void OnKnifeEnter()
    {
        NumOfKnifesToSet--;
        CheckIfMissionComplete();
    }
    public void OnKnifeExit()
    {
        NumOfKnifesToSet++;
        CheckIfMissionComplete();
    }
    // Fork enter\exit socket
    public void OnForkEnter()
    {
        NumOfForksToSet--;
        CheckIfMissionComplete();
    }
    public void OnForkExit()
    {
        NumOfForksToSet++;
        CheckIfMissionComplete();
    }
    // Cup enter\exit socket
    public void OnCupEnter()
    {
        NumOfCupsToSet--;
        CheckIfMissionComplete();
    }
    public void OnCupExit()
    {
        NumOfCupsToSet++;
        CheckIfMissionComplete();
    }


    private void CheckIfMissionComplete()
    {
        if(NumOfPlatesToSet <= 0 && NumOfKnifesToSet <= 0
            && NumOfForksToSet <= 0 && NumOfCupsToSet <= 0)
        {
            //Mission Complete
            //Foods.isStatic = false;
            FinishedMissionUI.SetActive(true);
            //this.gameObject.SetActive(false);
        }
        else
        {
            //Foods.isStatic = false;
            //Mission Not Complete
            //  NextMission.SetActive(false);
        }
    }
}
