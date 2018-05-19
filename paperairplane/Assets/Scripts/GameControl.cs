using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
	public enum GameState
	{
		GamePlay,
		GameOvera
	}
	public GameState game;

	void start(){
		game = GameState.GamePlay;
	}
}
