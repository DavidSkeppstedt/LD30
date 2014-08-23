using UnityEngine;
using System.Collections;

public class DistanceToPlayer : MonoBehaviour {

	public GameObject player;
	private float playerMass = 0;
	public bool orbit = false;
	public float force =0 ;
	public float distance = 0;
	private float G = 6.676f * Mathf.Pow (10, -11);
	private float planetMass = 0;
	private Vector3 position;

	// Use this for initialization
	void Start () {
		position = this.transform.position;
		playerMass = player.rigidbody2D.mass;
		planetMass = 100*Mathf.Pow (10, 10);



	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z + 1);

		Vector3 result = position - player.transform.position;
		distance = Mathf.Abs (Mathf.Sqrt(result.x * result.x + result.y * result.y));
		if (distance > 10 && 25 > distance) {
						force = G * (playerMass*planetMass) /(distance*distance);
						player.gameObject.rigidbody2D.AddForce (result * force);
		} else {

			if (distance < 10) {
				player.gameObject.rigidbody2D.velocity = new Vector3(0,0,0);
				orbit = true;
			}
		}



		if (orbit) {
			player.transform.parent = this.gameObject.transform;

		
		}



		if (Input.GetMouseButton(0) && orbit) {
			orbit = false;
			player.transform.parent = null;
			player.rigidbody2D.AddForce(result * -693352.3f * 100);
		
		}

		Debug.DrawLine (player.transform.position, player.transform.forward);



	}
}
