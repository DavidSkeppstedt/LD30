using UnityEngine;
using System.Collections;

public class DistanceToPlayer : MonoBehaviour {
	private SoundManager soundManager;
	public ZoomTween cameraZoom;
	public GameObject background;
	public GameObject controller;
	public GameObject player;
	private float playerMass = 0;
	public bool orbit = false;
	public float force =0 ;
	public float distance = 0;
	private float G = 6.676f * Mathf.Pow (10, -11);
	private float planetMass = 0;
	private Vector3 position;
	private float radius = 50;
	private float escapeDistance = 100;
	private bool rotate = false;
	private bool shoot = false;
	private bool left = false;
	private float forceMulti = 40;
	private float delay = 0;
	// Use this for initialization
	void Start () {
		cameraZoom = Camera.main.GetComponent<ZoomTween> ();
		background = GameObject.Find("Background");
		controller = GameObject.Find("Controllers");
		soundManager = controller.GetComponent<SoundManager> ();
		player = GameObject.FindWithTag("Player");
		position = this.transform.position;


		if (player == null) {
			return;
		}

		playerMass = player.rigidbody2D.mass;
		planetMass = 1000*Mathf.Pow (10, 10);



	}
	
	// Update is called once per frame
	void FixedUpdate () {



		if (player == null) {
			return;
		}


		transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z + 1);

		Vector3 result = position - player.transform.position;
		distance = Mathf.Abs (Mathf.Sqrt(result.x * result.x + result.y * result.y));


		if (distance > radius && escapeDistance > distance && !shoot) {
							
						if (!controller.GetComponent<GameStatus>().inOrbit) {
							force = G * (playerMass*planetMass) /(distance*distance) * forceMulti;	
							player.gameObject.rigidbody2D.AddForce (result * force);
						}

		} else {

			if (distance < radius && !controller.GetComponent<GameStatus>().inOrbit && !shoot) {
				player.gameObject.rigidbody2D.velocity = new Vector3(0,0,0);
				orbit = true;
				controller.GetComponent<GameStatus>().inOrbit = true;
				force = 0;

				//cameraZoom.ZoomOut();
				Camera.main.GetComponent<FollowPlayer>().enabled = false;
		
			}
		}



		if (orbit && !rotate && !shoot) {
			player.transform.parent = this.gameObject.transform;
			player.transform.eulerAngles = new Vector3(0,0,player.transform.eulerAngles.z  -90);
			rotate = true;
		}



		if (Input.GetMouseButton(0) && orbit && GameStatus.getFuel() >= 20) {
			soundManager.PlayFly();
			orbit = false;
			controller.GetComponent<GameStatus>().inOrbit = false;
			player.transform.parent = null;
			rotate = false;

			Vector2 shotDirection = new Vector2(player.transform.right.x,player.transform.up.y);
			//Debug.Log(shotDirection);

			player.rigidbody2D.AddForce(new Vector2(player.transform.right.x,player.transform.right.y) *5000000);
			shoot = true;
			force  = 0;
			left = true;
			//cameraZoom.ZoomIn();
			Camera.main.GetComponent<FollowPlayer>().enabled = true;


			if (GameStatus.planetList.Count >2) {
				GameObject g = GameStatus.planetList[0] as GameObject;
				GameStatus.planetList.RemoveAt(0);
				Destroy(g);

			}

			GameStatus.setFuel((GameStatus.getFuel()-20));


		}else if(GameStatus.getFuel() <= 0 && Input.GetMouseButton(0) && orbit){
			print("no fuel"); 
			Statemanager.STATE = Statemanager.states.DEAD;
		}

		//Debug.DrawLine (player.transform.position, player.transform.forward);
		if (shoot) {
			delay+=Time.deltaTime;

			if (delay > 2) {
				shoot = false;
				delay = 0;
				forceMulti *=0.5f; 
			}
		}


	}
}
