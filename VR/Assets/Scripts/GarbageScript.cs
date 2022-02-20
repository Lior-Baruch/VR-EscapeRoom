using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public GameObject NextMission;
    public GameObject Door;
    public GameObject Effect;
    public GameObject AudioSorceObject;
    public int AmountOfGarbageToPickUp;

    private new ParticleSystem particleSystem;
    private AudioSource garbageInTrashAudioSource;
    //private Animator doorAnimation;

    // Start is called before the first frame update
    void Start()
    {
        GameStatus.StartTimeGarbageMission = Time.realtimeSinceStartup;
        particleSystem = Effect.GetComponent<ParticleSystem>();
        garbageInTrashAudioSource = AudioSorceObject.GetComponent<AudioSource>();
        particleSystem.Stop();
        //doorAnimation = Door.GetComponent<Animator>();
        //doorAnimation.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        //Garbage put in trash
        if (other.CompareTag("Garbage"))
        {
            //logic
            other.gameObject.SetActive(false);
            AmountOfGarbageToPickUp--;
            //effects
            particleSystem.Stop();
            particleSystem.Play();
            garbageInTrashAudioSource.Play();
        }

        if(AmountOfGarbageToPickUp == 0 && !GameStatus.GarbageMissionComplete)
        {
            //Garbage Mission Complete
            GameStatus.GarbageMissionComplete = true;
            GameStatus.finishTimeGarbageMission = Time.realtimeSinceStartup;
            GameStatus.TotalTimeGarbageMission = GameStatus.finishTimeGarbageMission - GameStatus.StartTimeGarbageMission;
            //Open Door
            Door.transform.Rotate(new Vector3(0, 90, 0));
            //Activate Next mission (fire mission)
            NextMission.SetActive(true);
        }
    }
}
