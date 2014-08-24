using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

	public GameStatus gamestatus;




	// Update is called once per frame
	void Update () {
		if (gamestatus.inOrbit) {
			rigidbody2D.velocity = Vector2.zero;
			if (Input.GetKey(KeyCode.A)) {
				transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z -2);

			}

			if (Input.GetKey(KeyCode.D)) {
				transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z +1);
				
			}
		}
	}
}
