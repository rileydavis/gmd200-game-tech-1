using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTriggerScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.gameObject.GetComponent<PlayerReposition>().RepositionPlayer();
        }
    }
}
