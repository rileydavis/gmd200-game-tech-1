using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReposition : MonoBehaviour
{
    Vector2 origPlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
        origPlayerPosition = transform.localPosition;
    }

    public void RepositionPlayer()
    {
        transform.localPosition = origPlayerPosition;
        //GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
    }
}
