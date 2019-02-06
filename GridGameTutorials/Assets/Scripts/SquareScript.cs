using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{

    void OnMouseOver()
    {
        Debug.Log(gameObject.name);
        GridInfoScript.instance.UpdateUI(gameObject);
        // notice that "gameObject" is a convenience
        // gameObject will always return the object that this component (script)
        // is attached to...
    }

    void OnMouseExit()
    {
        GridInfoScript.instance.UpdateUI();
    }
}
