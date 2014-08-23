using UnityEngine;
using System.Collections;

public class Blackhole : MonoBehaviour {

	public Sprite[] blackhole;
	private SpriteRenderer sr;
	// Use this for initialization
	void Start () {

		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = blackhole [Random.Range(0,blackhole.Length)];
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
