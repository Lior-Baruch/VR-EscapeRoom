using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GarbageFinishTextScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public TextMeshProUGUI FinishText;

    // Start is called before the first frame update
    void Start()
    {
        FinishText.text += GameStatus.TotalTimeGarbageMission;
    }
}
