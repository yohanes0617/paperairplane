using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
    public AudioClip Gameplay;
    //public AudioClip Gameover;
    private AudioSource audioSource;
    [SerializeField]
    private GameObject _player;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = Gameplay;
        audioSource.Play();
    }
    private void Update()
    {
       // if (_player == null)
        //{
          //  audioSource.clip = Gameover;
            //audioSource.Play();
        //}
        
    }
}
