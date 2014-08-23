using UnityEngine;
using System.Collections;

public class Compass : MonoBehaviour {

	public Earth earth;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 Target = earth.getPos ();

		float dx = transform.position.x-Target.x;
		float dy = transform.position.y-Target.y;
		float degrees = Mathf.Atan2(dy,dx)* Mathf.Rad2Deg+180;
		transform.localEulerAngles = new Vector3 (0, 0, degrees);;

	}

}
