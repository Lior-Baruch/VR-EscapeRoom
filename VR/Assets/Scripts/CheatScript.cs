using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;

    //Garbage mission
    public GameObject GarbageMission;
    public GameObject DoorGarbageMission;
    public GameObject FinishedMissionUIGarbage;

    //Fire mission
    public GameObject FireMission;
    public GameObject FinishedMissionUIFire;
    public GameObject WildFire;
    public GameObject FireOrigin;
    private AudioSource fireMusic;
    private AudioSource SuccessSound;

    //DinnerMission mission
    public GameObject DinnerMission;
    public GameObject FinishedMissionUIDinner;

    // Start is called before the first frame update
    void Start()
    {
        fireMusic = FireMission.GetComponent<AudioSource>();
        SuccessSound = FireOrigin.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            skipMission();
        }

    }

    private void skipMission()
    {

        if (!GameStatus.GarbageMissionComplete)
        {
            skipGarbageMission();
        }
        else if (!GameStatus.FireMissionComplete)
        {
            skipFireMission();
        }
        else if (!GameStatus.DinnerMissionComplete)
        {
            skipDinnerMission();
        }
    }

    private void skipDinnerMission()
    {
        GameStatus.FinishTimeDinnerMission = Time.realtimeSinceStartup;
        GameStatus.TotalTimeDinnerMission = GameStatus.FinishTimeDinnerMission - GameStatus.StartTimeDinnerMission;

        FinishedMissionUIDinner.SetActive(true);
    }

    private void skipFireMission()
    {
        WildFire.SetActive(false);
        //update GameStatus
        GameStatus.FireMissionComplete = true;
        GameStatus.FinishTimeFireMission = Time.realtimeSinceStartup;
        GameStatus.TotalTimeFireMission = GameStatus.FinishTimeFireMission - GameStatus.StartTimeFireMission;
        //sound and timeUI
        fireMusic.Stop();
        SuccessSound.Play();
        FinishedMissionUIFire.SetActive(true);
    }

    private void skipGarbageMission()
    {
        // update gameStatus
        GameStatus.GarbageMissionComplete = true;
        GameStatus.FinishTimeGarbageMission = Time.realtimeSinceStartup;
        GameStatus.TotalTimeGarbageMission = GameStatus.FinishTimeGarbageMission - GameStatus.StartTimeGarbageMission;
        //Open Door
        DoorGarbageMission.transform.Rotate(new Vector3(0, 90, 0));
        //Active UI Mission Time and write time of mission
        FinishedMissionUIGarbage.SetActive(true);
    }
}
