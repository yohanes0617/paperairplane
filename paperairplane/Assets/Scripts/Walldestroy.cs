using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walldestroy : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "walldestroy")
        {
            Destroy(gameObject);

        }

    }
}
