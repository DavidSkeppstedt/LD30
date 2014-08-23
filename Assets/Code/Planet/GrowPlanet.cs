using UnityEngine;
using System.Collections;

public class GrowPlanet : MonoBehaviour {

	private float delay = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		delay +=Time.deltaTime * 4f;
		float x = Mathf.Lerp (0, 3, delay);
		transform.localScale = new Vector3(x,x,x);

		if (delay > 1) {
			Destroy(this);
		}
	}
}