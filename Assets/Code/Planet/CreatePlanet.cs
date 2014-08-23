using UnityEngine;
using System.Collections;

public class CreatePlanet : MonoBehaviour {

	public GameObject planet;
	public Sprite [] sprites;
	public GameObject player;
	public GameObject spawnedPlanets;

	void Start () {
		spawnedPlanets = GameObject.Find ("SpawnedPlanets");
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonUp (1) && player.GetComponent<PlayerToggle>().inOrbit == false) {

			Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector3 playerPos= player.transform.position;
			Vector3 res = mouse - playerPos;
			Debug.Log(Mathf.Abs(res.x * res.x + res.y* res.y));

			if (Mathf.Abs(res.x * res.x + res.y* res.y) < 150) {
				return;
			} else {
				GameObject go = Instantiate(planet,Camera.main.ScreenToWorldPoint(Input.mousePosition),Quaternion.identity) as GameObject;
				go.transform.parent = spawnedPlanets.transform;
				go.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0,sprites.Length)];
				go.transform.Translate(0,0,10);
			}
		}

	}
}