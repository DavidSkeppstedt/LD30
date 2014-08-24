using UnityEngine;
using System.Collections;

public class FlameEmitter : MonoBehaviour {


	private ParticleSystem flame;

	// Use this for initialization
	void Start () {
		flame = GetComponent<ParticleSystem> ();
		GetComponent<ParticleSystem> ().renderer.sortingOrder = -1;
	}

	public void PlayParticle() {
		flame.Play ();
	}
	

}
