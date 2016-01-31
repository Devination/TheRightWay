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

	public AudioClip sawLoop;
	public void playSawLoop()
	{
		_audio.clip = sawLoop;
		_audio.loop = true;
		_audio.Play();
	}

	public AudioClip sawStart;
	public void playSawStart()
	{
		_audio.clip = sawStart;
		_audio.loop = false;
		_audio.Play();
	}

	public AudioClip bladesStart;
	public void playBladesStart()
	{
		_audio.clip = bladesStart;
		_audio.loop = false;
		_audio.Play();
	}

	public AudioClip bladesLoop;
	public void playBladesLoop()
	{
		_audio.clip = bladesLoop;
		_audio.loop = true;
		_audio.Play();
	}

	public void StopSound()
	{
		_audio.Stop();
	}
}
