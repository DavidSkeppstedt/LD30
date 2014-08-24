using UnityEngine;
using System.Collections;

public class SetBackgroudLayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<ParticleSystem>().renderer.sortingLayerName = "BackgroundLayer";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
