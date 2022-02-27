using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStartMenuScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public Text textID;

    public Toggle ToggleMusic;
    // Start is called before the first frame update
    void Start()
    {
        textID.text = textID.text + GameStatus.UserID;

        ToggleMusic.isOn = true;
    }
}
