using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    public GameStateScriptableObjectScript GameStatus;
    private const float timeToPrint = 5;
    private float timeRemainToPrint = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is device Active: " + XRSettings.isDeviceActive);
        Debug.Log("Device name is: " + XRSettings.loadedDeviceName);
        Debug.Log("ID is " + GameStatus.UserID);




    }

    // Update is called once per frame
    void Update()
    {

        //print every X seconds for debug
        timeRemainToPrint -= Time.deltaTime;
        if (timeRemainToPrint < 0)
        {
            //update remain time
            timeRemainToPrint = timeToPrint;
            //debug.log
            Debug.Log("ID is " + GameStatus.UserID);
        }
    }
}
