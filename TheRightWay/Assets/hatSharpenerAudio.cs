using UnityEngine;
using System.Collections;

public class hatSharpenerAudio : MonoBehaviour
{

	AudioSource _audio;
	// Use this for initialization
	void Start()
	{
		_audio = this.GetComponent<AudioSource>();
	}

	public AudioClip grinder;
	public void playGrinder()
	{
		_audio.clip = grinder;
		_audio.Play();
	}
	public void StopSound()
	{
		_audio.Stop();
	}
}
