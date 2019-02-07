using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GridManager : MonoBehaviour
{
    [HideInInspector]
    public GameObject gridHolder;
    public Square squarePrefab; //assign in Inspector on Grid_Manager to Assets/Prefabs/Square
    public float startX = 0;
    public float startY = 0;
    public int rows;
    public int cols;
    readonly float spacer = 0.1f;

    // how to set this up without a public singleton.
    // this will appear to be a public static class.
    public Text nameTF;
    public Text rowTF;
    public Text colTF;

    private static GridManager instance;

    // Start is called before the first frame update
    void Start()
    {
        //squarePrefab = Resources.Load<Square>("Prefabs/Square");
        // avoid using Resources if you want to build the project see:
        // https://unity3d.com/learn/tutorials/topics/best-practices/resources-folder

        InitGridHolder();
        BuildGrid();
        instance = this;
    }

    void InitGridHolder()
    {
        gridHolder = new GameObject();
        gridHolder.name = "Grid_Holder";
        gridHolder.transform.position = new Vector2(startX, startY);
    }

    void BuildGrid()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Square square = Instantiate(squarePrefab, gridHolder.transform);
                Vector2 newPos = new Vector2(j + (spacer * j), i + (spacer * i));
                square.transform.localPosition = newPos;
                square.name = "Square_" + i + "_" + j;
                square.gridPosition = new Vector2Int(i, j);
            }
        }
    }

    // note that wiring these up in the Inspector can sometimes be fragile:
    // if you change the variable type or set them to static, then
    // you may need to rewire these.

    public static void UpdateUI(Square square = null)
    {
        if (square == null)
        {
            instance.nameTF.text = "---";
            instance.rowTF.text = "---";
            instance.colTF.text = "---";
            return;
        }

        instance.nameTF.text = square.name;
        instance.colTF.text = square.gridPosition.x.ToString();
        instance.rowTF.text = square.gridPosition.y.ToString();
    }
}
