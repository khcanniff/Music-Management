using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Voice))]
public class AudioManagement : MonoBehaviour
{
    // there should be an audio class for each voice
    private Voice[] voices; 

    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        voices = this.GetComponents<Voice>();
        foreach (Voice voice in voices)
        {
            voice.Setup();
        }

    }

    // Update is called once per frame
    void Update() 
    {
        
    }

    public void playSounds()
    {
        foreach (Voice voice in voices)
        {
            voice.playNextSound();
            
        }
    }
}
