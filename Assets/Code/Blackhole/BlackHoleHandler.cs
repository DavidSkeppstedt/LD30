using UnityEngine;
using System.Collections;

public class BlackHoleHandler : MonoBehaviour {

	private GameObject go;
	public GameObject prefab;
	public int amount = 10; 
	Vector2 pos; 


	// Use this for initialization
	void Start () {
		for (int i = 0; i < amount; i++) {
			addBlackHole();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void addBlackHole(){


		pos = new Vector3(Random.Range (-2000, 2000),Random.Range (-2000, 2000),0);
		
		go = Instantiate (prefab, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity) as GameObject;
		go.transform.Translate(0,0,10);
		go.transform.parent = this.gameObject.transform;


	}
}
