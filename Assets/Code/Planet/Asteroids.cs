using UnityEngine;
using System.Collections;

public class Asteroids : MonoBehaviour {


	private Vector2 startPos, endPos;
	private int size;
	private GameObject go;
	public GameObject prefab;
	private static bool spawn;

	void Start (){
		spawn = true; 
	}
	// Use this for initialization
	void Update () {
		if(spawn){
			for (int i = 0; i < 6; i++) {
				addAteroids();
			}
		}
		spawn = false; 
	}
	
	private void addAteroids(){
		size = Random.Range (20, 30); 
		
		
		startPos = new Vector2( Random.Range (-4000, 4000), Random.Range (-4000, 4000));
		
		if (Random.Range (0, 2) == 1) {
			//X 
			
			endPos = new Vector2(startPos.x,Random.Range(startPos.y+1000,startPos.y+3000));
		} else {
			//Y
			endPos = new Vector2(Random.Range(startPos.x+1000,startPos.x+3000),startPos.y);
		}
		
		
		
		
		Vector3 pos;
		
		for(int i = 0; i  < size;i++){
			
			pos = new Vector3(Random.Range(startPos.x,endPos.x),Random.Range(startPos.y,endPos.y),0);
			
			go = Instantiate (prefab, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity) as GameObject;
			go.transform.Translate(0,0,10);
			go.transform.parent = this.gameObject.transform;
			go.rigidbody2D.AddForce(new Vector2(Random.Range(0,2),Random.Range(0,2))* 1000000);
			
		}
	}
}
