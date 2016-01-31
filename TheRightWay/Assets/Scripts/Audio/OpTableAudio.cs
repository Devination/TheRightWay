using UnityEngine;
using System.Collections;

public class OpTableAudio : MonoBehaviour {
	AudioSource _audio;
	// Use this for initialization
	void Start () {
		_audio = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public AudioClip laserLoop;
    public void playLaserLoop() {
		_audio.clip = laserLoop;
		_audio.loop = true;
		_audio.Play();
    }

    public AudioClip laserStart;
    public void playLaserStart() {
		_audio.clip = laserStart;
		_audio.loop = false;
		_audio.Play();
	}
	public void StopSound()
	{
		_audio.Stop();
	}
}
