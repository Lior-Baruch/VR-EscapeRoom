using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishedAllMissions : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public TextMeshProUGUI FinishText;

    // Start is called before the first frame update
    void Start()
    {
        FinishText.text = "Garbage time = " + GameStatus.TotalTimeGarbageMission +
            "-- Fire time = " + GameStatus.TotalTimeFireMission +
            "-- Dinner Time = " + GameStatus.TotalTimeDinnerMission +
            "-- Total time = " + GameStatus.TotalTime;
    }
}
