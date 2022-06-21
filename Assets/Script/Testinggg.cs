using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "SO_GameSettings")]
public class Testinggg : ScriptableObject
{
    //public SO_GameSettings scriptableObject;
    public string version;
    public int soundVolume;
    public float brightness;
    public bool fullscreen;

    void Start()
    {
        Debug.Log("Version: " + version + "\n");
        Debug.Log("Sound FX: " + soundVolume + "\n");
        Debug.Log("Brightness: " + brightness + "\n");
        Debug.Log("Fullscreen: " + fullscreen);
    }
}

