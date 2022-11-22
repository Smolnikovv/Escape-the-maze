using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Menu");
    }
    private void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene("Menu");
    }
}
