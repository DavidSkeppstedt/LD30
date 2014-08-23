using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	public GameObject prefab;
	private GameObject go; 
	private GameObject background;
	private Vector3 pos; 
	public int stars; 
	 

	// Use this for initialization
	void Start () {

		background = GameObject.Find ("Background");

		for(int i = 0;i < stars; i++ ){
			pos = new Vector3(Random.Range(-17f,17f),Random.Range(-7f,7f),0);
			go = Instantiate (prefab, pos, Quaternion.identity) as GameObject;
			go.transform.parent = background.transform;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
