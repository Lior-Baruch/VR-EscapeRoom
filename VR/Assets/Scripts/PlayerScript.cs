using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public void RestartEscapeRoom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
