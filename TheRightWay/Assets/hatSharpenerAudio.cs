using UnityEngine;
using System.Collections;

public class hatSharpenerAudio : MonoBehaviour {

	AudioSource _audio;
	// Use this for initialization
	void Start()
	{
		_audio = this.GetComponent<AudioSource>();
	}

	public AudioClip grinderLoop;
	public void playGrinderLoop()
	{
		_audio.clip = grinderLoop;
		_audio.loop = false;
		_audio.Play();
	}
	public void StopSound()
	{
		_audio.Stop();
	}
}
