using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GarbageScript : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    public GameObject FinishedMissionUI;
    //public TextMeshProUGUI FinishMissionText;
    //public GameObject NextMission;
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
            GameStatus.FinishTimeGarbageMission = Time.realtimeSinceStartup;
            GameStatus.TotalTimeGarbageMission = GameStatus.FinishTimeGarbageMission - GameStatus.StartTimeGarbageMission;
            //Open Door
            Door.transform.Rotate(new Vector3(0, 90, 0));
           
            //Active UI Mission Time and write time of mission
            FinishedMissionUI.SetActive(true);
            
        }
    }
}
