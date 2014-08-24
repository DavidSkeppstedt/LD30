using UnityEngine;
using System.Collections;

public class SpaceCraft : MonoBehaviour {

	private GameObject go;
	public GameObject prefab;
	private Vector3 pos;
	private bool spawn; 

	// Use this for initialization
	void Start () {
		spawn = true; 
	}
	
	// Update is called once per frame
	void Update () {
		if (GameStatus.getFuel () <= 40 && spawn) {

			int sX = (int)this.gameObject.transform.position.x;
			int sY = (int)this.gameObject.transform.position.y;
			
			int rangeMin = 100; 
			int rangeMax = 300;


			if(Random.Range(0,2) == 1){

				pos = new Vector3 (sX + Random.Range (rangeMin, rangeMax), sY + Random.Range (rangeMin, rangeMax), 0);
				go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
		

				pos = new Vector3 (sX + Random.Range (rangeMin, rangeMax), sY - Random.Range (rangeMin, rangeMax), 0);
				go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
		

			}else{

				pos = new Vector3(sX-Random.Range(rangeMin,rangeMax),sY+Random.Range(rangeMin,rangeMax),0);
				go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;


				pos = new Vector3(sX-Random.Range(rangeMin,rangeMax),sY-Random.Range(rangeMin,rangeMax),0);
				go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;

			}
			spawn = false; 
		}else if(GameStatus.getFuel() > 40){
			spawn = true; 

		}

	}
}
