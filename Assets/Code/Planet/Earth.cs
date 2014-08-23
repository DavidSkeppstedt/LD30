using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour {

	private float posX, posY;


	// Use this for initialization
	void Start () {
	
		posX = 100; //Random the position
		posY = 100; //Random the position 

		this.transform.position = new Vector2 (posX, posY);

	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.collider.name.Equals("SpaceCraft")){
			Statemanager.STATE = Statemanager.states.WIN;
		}
	}

	public Vector2 getPos(){
		return new Vector2 (transform.position.x,transform.position.y);
	}
}
