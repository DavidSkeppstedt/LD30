using UnityEngine;
using System.Collections;

public class BlackHoleHandler : MonoBehaviour {

	private GameObject go;
	public GameObject prefab;
	private int amount = 200; 
	Vector2 pos; 

	private GameObject spaceCraft; 

	// Use this for initialization 
	void Start () {


		spaceCraft = GameObject.Find ("SpaceCraft");

		for (int i = 0; i < amount; i++) {
			spawnBlackHole();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void spawnBlackHole(){

		float spaceCraftX = spaceCraft.transform.position.x;
		float spaceCraftY = spaceCraft.transform.position.y;

		int x = 0, y = 0;

		do{
			x = (int)Random.Range (spaceCraftX,spaceCraftX + 3000);
			y = (int)Random.Range (spaceCraftY,3000);
		}while(Mathf.Sqrt(x*x+y*y) <= 100);


		if(Random.Range(0,2)==1){
			x *= -1;
		}
		if (Random.Range (0,2) == 1) {
			y *= -1;
		}

		pos = new Vector3(x,y,0);
		
		go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
		go.transform.Translate(0,0,10);
		go.transform.parent = this.gameObject.transform;



	}
}
