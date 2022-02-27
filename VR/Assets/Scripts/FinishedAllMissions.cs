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
        FinishText.text = "congratulations, you have passed all the missions." + System.Environment.NewLine +
            "Garbage time = " + GameStatus.TotalTimeGarbageMission + System.Environment.NewLine +
            "Fire time = " + GameStatus.TotalTimeFireMission + System.Environment.NewLine +
            "Dinner Time = " + GameStatus.TotalTimeDinnerMission + System.Environment.NewLine +
            "Total time = " + GameStatus.TotalTime;
    }
}
