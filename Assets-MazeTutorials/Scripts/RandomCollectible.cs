﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{
     void RepositionCollectible()
    {
        float newX = Random.Range (-5, 5);
        float newY = Random.Range (-3, 3);
        Vector2 newPos = new Vector2 (newX, newY);
        transform.position = newPos;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        RepositionCollectible();
	GameObject.Find ("Score_Canvas").GetComponent<ScoreScript> ().AddScore ();
    }
}