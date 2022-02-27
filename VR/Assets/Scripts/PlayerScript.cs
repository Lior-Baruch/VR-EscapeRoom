using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public GameObject XRDeviceSimulator;

    private void Start()
    {
#if UNITY_EDITOR
        XRDeviceSimulator.SetActive(true);
#endif
    }
    public void RestartEscapeRoom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameStatus.GarbageMissionComplete = false;
        GameStatus.FireMissionComplete = false;
        GameStatus.DinnerMissionComplete = false;

    }

    public void SaveMissionTime()
    {
        PlayerPrefs.SetFloat(GameStatus.UserID + "GarbageMission", GameStatus.TotalTimeGarbageMission);
        PlayerPrefs.SetFloat(GameStatus.UserID + "FireMission", GameStatus.TotalTimeFireMission);
        PlayerPrefs.SetFloat(GameStatus.UserID + "DinnerMission", GameStatus.TotalTimeDinnerMission);
        PlayerPrefs.SetFloat(GameStatus.UserID + "EscapeRoomMission", GameStatus.TotalTime);
        //save stored values in disk
        PlayerPrefs.Save();
    }
}
