using UnityEngine;
using System.Collections;

public class Statemanager : MonoBehaviour {

	public enum states{
		MENU,
		PLAY,
		DEAD
	};

	public static states STATE;

	void Awake(){
		STATE = states.MENU;
	}

	// Use this for initialization
	void Start () {


	}


	// Update is called once per frame
	void Update () {
		if(STATE == states.MENU){
			//MENU
		}else if(STATE == states.PLAY){
			//PLAY		
		}else if(STATE == states.DEAD){
			//DEAD
		}

	}


	//Do all the reset here
	public static void reset(){
		GameStatus.reset();
	}
}
