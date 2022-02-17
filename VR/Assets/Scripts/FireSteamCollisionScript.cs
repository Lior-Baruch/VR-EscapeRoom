using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSteamCollisionScript : MonoBehaviour
{
    public GameObject FireMission;

    public GameObject NextMission;
    public ScriptableObjectTest GameStatus;
    public GameObject WildFire;
    public GameObject FireOrigin;

    private AudioSource fireMusic;
    private AudioSource SuccessSound;

    private void Start()
    {
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
            WildFire.SetActive(false);

            fireMusic.Stop();
            SuccessSound.Play();


            //Activate Next mission (fire mission)
            NextMission.SetActive(true);
        }
    }
}
