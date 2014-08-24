using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	private SoundManager soundManager;
	public AudioClip explosion, fly,victory;
	private AudioSource player;

	void Awake() {
		if (soundManager == null) {
						soundManager = this;
						DontDestroyOnLoad (soundManager);
		} else {
			Destroy(this.gameObject);		
		}
	}

	void Update () {
		if (Input.GetKey (KeyCode.M)) {
			if (GetComponents<AudioSource>()[1].isPlaying) {
				GetComponents<AudioSource>()[1].Stop();
			}else {
				GetComponents<AudioSource>()[1].Play();
			}
		}
	}

	void Start() {
		player = GetComponent<AudioSource> ();
	}


	public void PlayExplosion() {
		play (explosion);
	}

	public void PlayFly() {
		play (fly);
	}

	public void PlayVictory() {
		play (victory);
	}


	private void play(AudioClip sndEfc) {
		if (!player.isPlaying)
			player.PlayOneShot (sndEfc);



	}



}
