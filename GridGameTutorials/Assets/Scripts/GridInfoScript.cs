using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridInfoScript : MonoBehaviour
{
    public Text nameTF;
    public Text rowTF;
    public Text colTF;
    // note that wiring these up in the Inspector can sometimes be fragile:
    // if you change the variable type or set them to static, then
    // you may need to rewire these later.

    // Use a singleton "instance" to access the existing object
    // where the array exists, not a copy of the object.

    public static GridInfoScript instance;

    void Start()
    {
       instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI(GameObject gameObject)
    {
        string name = gameObject.name;
        string[] nameArray = name.Split('_');
        string row = nameArray[1];
        string col = nameArray[2];
        nameTF.text = name;
        colTF.text = col;
        rowTF.text = row;
    }

    public void UpdateUI()
    {
        nameTF.text = "---";
        rowTF.text = "---";
        colTF.text = "---";
    }
}
