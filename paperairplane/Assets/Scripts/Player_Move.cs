using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {
	
	private Rigidbody2D rb2D;
	private float jump = 10.0f;
	private GameObject player;
	private GameControl GameControlScript;
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player");
		GameControlScript = player.GetComponent<GameControl> ();
	}
	void Update () {
		//Debug.Log (GameControlScript.game);
		//if (GameControlScript.game == GameControl.GameState.GameOvera) {
		//	return ;
		//}
		//列挙型の参照が上手く行かなかったためひとまず、消しておく
		//if (GameControlScript.game == GameControl.GameState.GamePlay) {
			if (Input.GetMouseButtonDown (0)) {rb2D.velocity = new Vector2 (rb2D.velocity.x, jump);}
		//}
	}

	}

