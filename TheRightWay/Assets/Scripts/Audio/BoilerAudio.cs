using UnityEngine;
using System.Collections;

public class BoilerAudio : MonoBehaviour {

	AudioSource _audio;
	void Start()
	{
		_audio = this.GetComponent<AudioSource>();
	}

	public AudioClip lavaLoop;
    public void playLavaLoop() {
		if (!_audio.isPlaying)
		{
			_audio.clip = lavaLoop;
			_audio.Play();
		}
	}
	public void StopSound()
	{
		_audio.Stop();
	}
}
