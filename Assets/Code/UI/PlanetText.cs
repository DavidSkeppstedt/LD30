using UnityEngine;
using System.Collections;

public class PlanetText : MonoBehaviour {
	private UnityEngine.UI.Text planetText;


	void Start() {
		planetText = GetComponent<UnityEngine.UI.Text> ();
		planetText.text = "Planets: "+ GameStatus.bigPlanetPlaced + " /4";

	}

	void Update (){
		planetText.text = "Planets: "+ GameStatus.bigPlanetPlaced + " /4";
	}






}
