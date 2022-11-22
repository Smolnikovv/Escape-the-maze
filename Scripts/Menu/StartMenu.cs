using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Easy()
    {
        System.Random rnd = new System.Random();
        int r = rnd.Next(2);
        if(r==1)
        {
            SceneManager.LoadScene("Easy_1");
        }
        else
        {
            SceneManager.LoadScene("Easy_2");
        }
    }
    public void Hard()
    {
        System.Random rnd = new System.Random();
        int r = rnd.Next(2);
        if (r == 1)
        {
            SceneManager.LoadScene("Hard_1");
        }
        else
        {
            SceneManager.LoadScene("Hard_2");
        }
    }

}
