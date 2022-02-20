using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSteamCollisionScript : MonoBehaviour
{
    public GameObject FireMission;
    public GameObject NextMission;
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
            GameStatus.FireMissionComplete = true;
            GameStatus.finishTimeFireMission = Time.realtimeSinceStartup;
            GameStatus.TotalTimeFireMission = GameStatus.finishTimeFireMission - GameStatus.StartTimeFireMission;
            WildFire.SetActive(false);

            fireMusic.Stop();
            SuccessSound.Play();


            //Activate Next mission (fire mission)
            NextMission.SetActive(true);
        }
    }
}
