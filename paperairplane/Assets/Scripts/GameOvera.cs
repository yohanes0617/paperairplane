using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOvera : MonoBehaviour {
    private float _time;
    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private Text gameOver;
    [SerializeField]
    private Text retry;
    //[SerializeField]再表示が上手くいかないためボタンを隅っこに常駐
   // private GameObject titol;
   // [SerializeField]
   // private GameObject retry;
    void Update()
    {
        if (_player == null) {
            gameOver.enabled = true;
            retry.enabled = true;
           // titol.SetActive(true);
            //retry.SetActive(true);
        }
    }
    }
