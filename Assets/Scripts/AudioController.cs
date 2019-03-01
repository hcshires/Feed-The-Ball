using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    /* GameObjects */

    public AudioClip MusicClip; // Game Soundtrack
    public AudioSource MusicSource;

    // Use this for initialization
    void Start () {
        MusicSource.clip = MusicClip;
        MusicSource.volume = 0.3f;
        MusicSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
		if (MusicSource.isPlaying != true) // Loop soundtrack
        {
            MusicSource.Play();
        }
	}
}
