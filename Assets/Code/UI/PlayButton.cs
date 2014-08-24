using UnityEngine;

using System.Collections;

public class PlayButton : MonoBehaviour {

	void PlayGame() {
		Statemanager.STATE = Statemanager.states.PLAY;
		this.gameObject.SetActive(false);
	}

}
