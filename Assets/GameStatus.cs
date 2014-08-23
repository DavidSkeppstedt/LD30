using UnityEngine;
using System.Collections;

public class GameStatus : MonoBehaviour {

	private static bool alive; 

	public static int tinyPlanetMax;
	public static int bigPlanetMax;
	
	private static int tinyPlanetPlaced;
	private static int bigPlanetPlaced; 

	private static int fuel; //100% max 

	// Use this for initialization
	void Start () {
		reset ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void setAlive(bool a){
		alive = a;
	}
	public static bool isAlive(){
		return alive; 
	}

	public static bool placeTinyPlanet(){
		if (tinyPlanetPlaced + 1 > tinyPlanetMax) {
			return false; 
		} else {
			tinyPlanetPlaced++;
			return true;
		}
	}

	public static int getTinyPlanetPlaced(){
		return tinyPlanetPlaced;
	}

	public static bool placeBigPlanet(){
		if (bigPlanetPlaced + 1 > bigPlanetMax) {
			return false;
		} else {
			bigPlanetMax++;
			return true; 
		}
	}

	public static int getFuel(){
		return (fuel);
	}
	public static void setFuel(int f){
		if (f > 100) {
			f = 100;
		} else if (f < 0) {
			f = 0;	
		}
		fuel = f; 
	}

	public static void reset(){
		bigPlanetPlaced = 0;
		tinyPlanetPlaced = 0;

		fuel = 100; 

		alive = true; 
	}
}
