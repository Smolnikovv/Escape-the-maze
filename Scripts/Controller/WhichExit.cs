using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WhichExit : MonoBehaviour
{
    public GameObject possbileExit1;
    public GameObject possbileExit2;
    public GameObject exitSmoke1;
    public GameObject exitSmoke2;
    void Start()
    {
        System.Random rnd = new System.Random();
        int r = rnd.Next(2);
        if (r == 1)
        {
            possbileExit1.SetActive(false);
            exitSmoke1.SetActive(true);
        }
        else
        {
            possbileExit2.SetActive(false);
            exitSmoke2.SetActive(true);
        }
    }
}
