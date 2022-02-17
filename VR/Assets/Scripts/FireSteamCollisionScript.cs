using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSteamCollisionScript : MonoBehaviour
{
    public GameObject WildFire;

    private void OnParticleCollision(GameObject other)
    {
        //Fire Mission Complete
        if (other.CompareTag("FireOrigin"))
        {
            WildFire.SetActive(false);
        }
    }
}
