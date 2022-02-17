using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : MonoBehaviour
{
    public GameObject Effect;

    private new ParticleSystem particleSystem;

    public void Start()
    {
        particleSystem = Effect.GetComponent<ParticleSystem>();
        particleSystem.Stop();
    }
    public void OnActivate()
    {
        particleSystem.Play();
    }

    public void OnDeActivate()
    {
        particleSystem.Stop();
    }
}
