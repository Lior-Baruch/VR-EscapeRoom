using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageScript : MonoBehaviour
{
    public ScriptableObjectTest GameStatus;
    public GameObject NextMission;
    public GameObject Door;
    public GameObject Effect;
    public GameObject AudioSorceObject;
    public int AmountOfGarbageToPickUp;

    private new ParticleSystem particleSystem;
    private AudioSource garbageInTrashAudioSource;
    private Animator doorAnimation;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = Effect.GetComponent<ParticleSystem>();
        garbageInTrashAudioSource = AudioSorceObject.GetComponent<AudioSource>();
        particleSystem.Stop();
        doorAnimation = Door.GetComponent<Animator>();
        doorAnimation.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Garbage put in trash
        if (other.CompareTag("Garbage"))
        {
            other.gameObject.SetActive(false);
            AmountOfGarbageToPickUp--;
            
            particleSystem.Stop();
            particleSystem.Play();
            garbageInTrashAudioSource.Play();
        }

        if(AmountOfGarbageToPickUp == 0 && !GameStatus.GarbageMissionComplete)
        {
            //Garbage Mission Complete
            GameStatus.GarbageMissionComplete = true;
            GameStatus.finishTimeGarbageMission = Time.realtimeSinceStartup;
            //Activate Next mission (fire mission)
            NextMission.SetActive(true);
            GameStatus.StartTimeFireMission = Time.realtimeSinceStartup;
            //Open Door
            Door.transform.Rotate(new Vector3(0, 90, 0));
          
          

        }
    }
}
