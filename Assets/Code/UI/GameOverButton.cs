using UnityEngine;
using System.Collections;

public class GameOverButton : MonoBehaviour {

	

	void RestartButton() {
		Statemanager.reset ();
	}
}
