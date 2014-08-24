using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	private GameObject spaceCraft;  
	private GameObject go; 
	public GameObject prefab; 
	// Use this for initialization
	void Start () {
		spaceCraft = GameObject.Find ("SpaceCraft");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.collider.name.Equals("SpaceCraft")){


			
			go = Instantiate (prefab, spaceCraft.transform.position, Quaternion.identity) as GameObject;
		
			go.particleSystem.renderer.sortingLayerName = "Default";
			go.particleSystem.renderer.sortingOrder = 5; 
			go.particleSystem.Play(true); 
			spaceCraft.SetActive(false);

			Statemanager.STATE = Statemanager.states.DEAD;
		}
	}
}
