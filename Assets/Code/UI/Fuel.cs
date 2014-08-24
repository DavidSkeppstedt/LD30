using UnityEngine;
using System.Collections;

public class Fuel : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<UnityEngine.UI.Text> ().text = "Fuel: "+GameStatus.getFuel ();
	}
}
