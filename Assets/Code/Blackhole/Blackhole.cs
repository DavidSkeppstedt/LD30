using UnityEngine;
using System.Collections;

public class Blackhole : MonoBehaviour {

	public GameObject player;
	private GameStatus gamestatus;
	private Transform playerPos;
	public Sprite[] blackhole;
	private SpriteRenderer sr;
	public float distance = 0;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = blackhole [Random.Range(0,blackhole.Length)];
		playerPos = player.transform;
		gamestatus = GameObject.Find ("Controllers").GetComponent<GameStatus> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!gamestatus.inOrbit && Statemanager.STATE == Statemanager.states.MENU)
			gravitationOnPlayer ();



	}



	public void gravitationOnPlayer() {

		Vector3 position= transform.position;
		Vector2 result = position - playerPos.position;

		 distance = Mathf.Abs (Mathf.Sqrt (result.x * result.x + result.y * result.y));




		if (distance < 50) {
			player.rigidbody2D.AddForce(result * 20000);
			Debug.Log("True");
		}

		if (distance < 20) {
			Statemanager.STATE = Statemanager.states.DEAD;
			Destroy(player.gameObject);
		}


	}

	public Vector3 getPos(){
		return this.transform.position;
	}

}



