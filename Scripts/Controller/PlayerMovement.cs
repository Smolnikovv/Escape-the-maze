using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;

    private float posX;
    private float posY;
    private FileStream fs;
    private void Start()
    {
        if (Directory.Exists(@"ValidateLogs"))
        { }
        else
        {
            DirectoryInfo di = Directory.CreateDirectory(@"ValidateLogs");
        }
        fs = File.Create(@"ValidateLogs\Run" + DateTime.Now);
    }
    void Update()
    {
        posX = GameObject.Find(player.name).transform.position.x;
        posY = GameObject.Find(player.name).transform.position.y;
        
        AddText(fs,posX.ToString() + ';' + posY.ToString());
    }
    private static void AddText(FileStream fs, string value)
    {
        File.AppendAllText(fs.ToString(), value + Environment.NewLine);
    }
}
