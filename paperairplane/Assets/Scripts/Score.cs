using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private float _time;
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private Text _text;
    void Update()
    {
        if (_player == null) {
            _text.text = "貴方のスコアは" + Mathf.RoundToInt(_time) + "です";
            return; }
        _time += Time.deltaTime;
        _text.text = "[score]" + Mathf.RoundToInt(_time);
    }
}
