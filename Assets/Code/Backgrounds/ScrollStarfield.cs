using UnityEngine;
using System.Collections;

public class ScrollStarfield : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		GetComponent<ParticleSystem> ().renderer.sortingLayerName = "BackgroundLayer";
		GetComponent<ParticleSystem> ().renderer.sortingOrder = 1;
	}
	
	// Update is called once per frame
	void Update () {

		if (player == null) {
			return;
		}
		//Debug.Log (player.rigidbody2D.velocity);

		transform.position = new Vector2 (transform.position.x + -PosOrNeg(player.rigidbody2D.velocity.x) , transform.position.y + -PosOrNeg(player.rigidbody2D.velocity.y));

		if (transform.position.x +250< Camera.main.ViewportToWorldPoint (new Vector3(0,0,0)).x) {
			transform.position = new Vector3(player.transform.position.x + 350,player.transform.position.y,0);
		}

		if (transform.position.x -250 > Camera.main.ViewportToWorldPoint (new Vector3(1,0,0)).x) {
			transform.position = new Vector3(player.transform.position.x- 350,player.transform.position.y,0);
		}


		if (transform.position.y + 250 < Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0)).y) {
			transform.position = new Vector3(player.transform.position.x,player.transform.position.y + 300,0);
		}

		if (transform.position.y - 250 > Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, 0)).y) {
			transform.position = new Vector3(player.transform.position.x,player.transform.position.y - 300,0);
		}







	}



	int PosOrNeg(float ff) {
		int f = (int) ff;
		if (f > 0) {
			return 1;
		}

		if (f < 0) {
			return -1;
		}

		return 0;


	}




}
