using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] int width; // width of the grid dimension
    [SerializeField] int height; // height of the grid dimension
    [SerializeField] int cellSize; // size per cell

    [SerializeField] Tile tilePrefab; // tile prefab of this grid

    Vector3 originPosition; // origin starting position

    GameObject[,] gridArray; // array to contain grids

    List<Tile> tileList; // list of instantiated tiles

    #region monobehaviour events
    private void Awake()
    {
        originPosition = transform.position; // initialize origin position by curren position
        ConstructGrid(); // contruct grid only once at awake
    }
    #endregion

    #region private functions
    void ConstructGrid() // funtion to construct grid
    {
        gridArray = new GameObject[width, height]; // initialize grid array's size

        for (int i =0; i < gridArray.GetLength(0); i++) // loop for x dimension of the grid
        {
            for(int j = 0; j < gridArray.GetLength(1); j++) // loop for y dimension of grid
            {
                // Instantiate Tile
                InstantiateTile(i, j);
            }
        }
    }

    void InstantiateTile(int _x, int _y) // instantiate a tile of the grid
    {
        Instantiate(tilePrefab, transform).GetComponent<Tile>().Init(_x, _y, cellSize); // instantiale a tile and then init it with coordinat value and cell size
    }
    #endregion
}
