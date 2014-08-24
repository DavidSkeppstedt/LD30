using UnityEngine;
using System.Collections;

public class FuelTank : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.collider.name.Equals("SpaceCraft")){
			GameStatus.setFuel(GameStatus.getFuel()+40);
			Destroy(this.gameObject);
		}
	}
}
