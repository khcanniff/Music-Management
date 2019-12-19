using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClass : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] tracks;

    // the below AudioSource is used for managing their own tracks. so for example, M1 should handle playing of the M1 tracks etc
    private AudioSource audio;


    int Counter = 0;
 

    // Start is called before the first frame update
    public void Setup()
    {
        audio = gameObject.AddComponent<AudioSource>();
        audio.clip = tracks[Counter];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool checkIfAudioIsPlaying()
    {
        return audio.isPlaying;
    }


    public void playNextSound()
    {
        if (!checkIfAudioIsPlaying() && Counter < tracks.Length)
        {
            audio.clip = tracks[Counter];
            Counter++;
        }
    }

}
