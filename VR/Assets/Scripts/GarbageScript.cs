using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageScript : MonoBehaviour
{
    public GameObject NextMission;
    public GameObject Door;
    public GameObject Effect;
    public int AmountOfGarbageToPickUp;

    //private Animator doorAnimation;
    private new ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = Effect.GetComponent<ParticleSystem>();
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Garbage"))
        {
            other.gameObject.SetActive(false);
            AmountOfGarbageToPickUp--;
            
            particleSystem.Stop();
            particleSystem.Play();
        }

        if(AmountOfGarbageToPickUp == 0)
        {
            //Active Next mission (fire mission)
            NextMission.SetActive(true);

            //Open Door
            Door.transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}
