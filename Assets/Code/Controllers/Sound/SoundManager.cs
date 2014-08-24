using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip explosion, fly;
	private AudioSource player;

	void Start() {
		player = GetComponent<AudioSource> ();
	}


	public void PlayExplosion() {
		play (explosion);
	}

	public void PlayFly() {
		play (fly);
	}


	private void play(AudioClip sndEfc) {
		if (!player.isPlaying)
			player.PlayOneShot (sndEfc);



	}



}
