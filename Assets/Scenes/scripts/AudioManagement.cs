using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioClass))]
public class AudioManagement : MonoBehaviour
{
    private AudioClass M1;
    private AudioClass M2;
    private AudioClass M3;


    // Start is called before the first frame update
    void Start()
    {
        M1 = this.GetComponent<AudioClass>();
        M1.Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void M1Play()
    {
        M1.playNextSound();
    }
}
