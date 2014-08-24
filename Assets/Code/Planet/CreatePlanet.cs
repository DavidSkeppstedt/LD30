using UnityEngine;
using System.Collections;

public class CreatePlanet : MonoBehaviour {

	public GameObject planet;
	public Sprite [] sprites;
	public GameObject controller;
	public GameObject player;
	public GameObject spawnedPlanets;

	void Start () {
		spawnedPlanets = GameObject.Find ("SpawnedPlanets");
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (GameStatus.bigPlanetPlaced);
		if (player == null) {
			return;
		}


		if (Input.GetMouseButtonUp (1) && controller.GetComponent<GameStatus>().inOrbit == false) {
			if (GameStatus.placeBigPlanet()) {





				Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector3 playerPos= player.transform.position;
				Vector3 res = mouse - playerPos;


				if (Mathf.Abs(res.x * res.x + res.y* res.y) < 150) {
					return;
				} else {
					GameObject go = Instantiate(planet,Camera.main.ScreenToWorldPoint(Input.mousePosition),Quaternion.identity) as GameObject;
					go.transform.parent = spawnedPlanets.transform;
					go.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0,sprites.Length)];
					go.transform.Translate(0,0,10);
					GameStatus.planetList.Add(go);
				}

			}else {


			}
		}





		if (Input.GetMouseButtonUp (1) && controller.GetComponent<GameStatus> ().inOrbit) {
			if (GameStatus.planetList.Count > 1){
				GameObject g = GameStatus.planetList[0] as GameObject;
				GameStatus.planetList.RemoveAt(0);
				Destroy(g);
			}
		}



	}








}