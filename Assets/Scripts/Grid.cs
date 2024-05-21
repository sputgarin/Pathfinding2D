using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GridCell[] walkableGrid = new GridCell[100];
    public int width = 10;
    
    public bool IsWalkable(int x, int y)
    {
        return walkableGrid[y*width+x].walkable;
    }

    public GridCell GetCellForPosition(Vector3 position)
    {
        // for x = 0 < width
        //   for y = 0 < height
        //     if position.x is > [...] && x <= [...] && position.y > [...] && y <= [...]
        //        return that cell
        
        // can you not also calculate the index
        // 1.3 -> 1
        // 1 -> 1
        // 0.7 -> 1
        // 0.4 -> 0
        // 1.6 -> 2
        
        // xIndex positon.x * - + / something
        
        // example input: (x: 3, y: 4, z: 0)
        // example input: (x: 3, y: 4, z: 5)
        // example input: (x: 4.2, y: 2.3, z: 5)
        
        // what about?
        // example input: (x: -9, y: 4, z: 5)
        // example input: (x: 110, y: 4, z: 5)
        
        // remember: floats are inaccurate, so you can't do position.x == 4
        // how can you calculate the right x and y index for the Vector3 position?
        // then, return the cell at that index of the array
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
