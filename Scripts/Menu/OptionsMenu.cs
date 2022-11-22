using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Windows;

public class OptionsMenu : MonoBehaviour
{
    public void Validator()
    {
        try
        {
            Process.Start("Validate.exe");

            UnityEngine.Application.Quit();
        }
        catch
        {
            
        }
    }
}

