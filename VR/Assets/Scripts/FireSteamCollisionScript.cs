using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSteamCollisionScript : MonoBehaviour
{
    public GameObject FireMission;
    public GameObject FinishedMissionUI;
    //public GameObject NextMission;
    //public GameObject Foods;
    public GameObject WildFire;
    public GameObject FireOrigin;
    public GameStateScriptableObjectScript GameStatus;

    private AudioSource fireMusic;
    private AudioSource SuccessSound;

    private void Start()
    {
        GameStatus.StartTimeFireMission = Time.realtimeSinceStartup;
        fireMusic = FireMission.GetComponent<AudioSource>();
        SuccessSound = FireOrigin.GetComponent<AudioSource>();
    }

    private void OnParticleCollision(GameObject other)
    {
        //Fire Mission Complete
        if (other.CompareTag("FireOrigin") && !GameStatus.FireMissionComplete)
        {
            WildFire.SetActive(false);
            //update GameStatus
            GameStatus.FireMissionComplete = true;
            GameStatus.FinishTimeFireMission = Time.realtimeSinceStartup;
            GameStatus.TotalTimeFireMission = GameStatus.FinishTimeFireMission - GameStatus.StartTimeFireMission;
            //sound and timeUI
            fireMusic.Stop();
            SuccessSound.Play();
            FinishedMissionUI.SetActive(true);
        }
    }
}
