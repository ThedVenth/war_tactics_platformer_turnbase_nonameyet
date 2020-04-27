using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    int x, y; // coordinat of this tile in the grid
    float tileSize; // size of this tile

    public void Init(int _x, int _y, float _tileSize) // initilaize tile with coordinat value and cellsize
    {
        // assign coordinat values
        x = _x;
        y = _y;

        //assign tile size
        tileSize = _tileSize;

        // place tile to coordinat position, use local position for easeness
        transform.localPosition = new Vector3(x, 0, y) * tileSize;

        // resize the tile according to size
        transform.localScale = new Vector3(tileSize, 1, tileSize);

        //tesr
    }
}
