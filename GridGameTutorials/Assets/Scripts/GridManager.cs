using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [HideInInspector]
    public GameObject gridHolder;
    GameObject squarePrefab;
    public float startX = 0;
    public float startY = 0;
    public int rows;
    public int cols;
    float spacer = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        squarePrefab = Resources.Load<GameObject>("Prefabs/Square");
        InitGridHolder();
        BuildGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
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
                GameObject square = Instantiate(squarePrefab, gridHolder.transform);
                Vector2 newPos = new Vector2(j + (spacer * j), i + (spacer * i));
                square.transform.localPosition = newPos;
                square.name = "Square_" + i + "_" + j;
            }
        }
    }
}
