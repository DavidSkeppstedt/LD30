using UnityEngine;
using System.Collections;

public class Asteroids : MonoBehaviour {


	private Vector2 startPos, endPos;
	private int amount;
	private GameObject go;
	public GameObject prefab;
	private GameObject spaceCraft;

	void Start (){
		amount = 100; 
		spaceCraft = GameObject.Find ("SpaceCraft");

		for (int i = 0; i < amount; i++) {
			spawnAteroids();
		}
	}
	// Use this for initialization
	void Update () {

	}



	private void spawnAteroids(){

		float spaceCraftX = spaceCraft.transform.position.x;
		float spaceCraftY = spaceCraft.transform.position.y;
		
		int x1 = 0, y1 = 0;
		int x2 = 0, y2 = 0;

		float dx, dy; 
		do{
			x1 = (int)Random.Range (spaceCraftX,spaceCraftX + 2200);
			y1 = (int)Random.Range (spaceCraftY,2200);

			dx = x1-spaceCraftX;
			dy = y1-spaceCraftY;


		}while(Mathf.Sqrt(dx*dx+dy*dy) <= 500);
		
		
		if(Random.Range(0,2)==1){
			x1 *= -1;
		}
		if (Random.Range (0,2) == 1) {
			y1 *= -1;
		}

		 
		
		

		
		if (Random.Range (0, 2) == 1) {
			//X 
			
			x2 = x1;
			y2 = Random.Range(y1+500,y1+1000);

		} else {
			//Y
			x2 = Random.Range(x1+500,x1+1000);
			y2 = y1;
		}
		
		
		
		int size = Random.Range (5, 15);

		Vector3 pos;
		
		for(int i = 0; i  < size;i++){
			
			pos = new Vector3(Random.Range(x1,x2),Random.Range(y1,y2),0);
			
			go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
			go.transform.Translate(0,0,10);
			go.transform.parent = this.gameObject.transform;
			go.rigidbody2D.AddForce(new Vector2(Random.Range(0,2),Random.Range(0,2))* 1000000);
			
		}
	}
}
