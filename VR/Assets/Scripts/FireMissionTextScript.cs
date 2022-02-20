using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireMissionTextScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public Text FireMissionText;

    // Start is called before the first frame update
    void Start()
    {
        FireMissionText.text = FireMissionText.text + GameStatus.TotalTimeGarbageMission;
    }
}
