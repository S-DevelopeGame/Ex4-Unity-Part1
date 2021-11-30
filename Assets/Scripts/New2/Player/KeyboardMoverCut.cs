using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class KeyboardMoverCut : KeyboardMover1
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] AllowedTilesW allowedTiles;
    [Tooltip("The TileBase that allow to cut")] [SerializeField] TileBase[] AllowedCut;
    [Tooltip("The TileBase that will appear after you cut")] [SerializeField] TileBase afterCut;
    [Tooltip("the delay when you want to cut more time")] [SerializeField] float slow = 1f;
    private float currTime = 0f; // the current time
    private bool canCat = true; // allow to cut


    private TileBase TileOnPosition(Vector3 worldPosition)
    {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    void Update()
    {
        Vector3 newPosition = NewPosition();
        TileBase tileOnNewPosition = TileOnPosition(newPosition);
        if (allowedTiles.Contain(tileOnNewPosition))
        {
            transform.position = newPosition;
        }
        else
        {
            Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            TileBase tileOnDirPosition = TileOnPosition(transform.position + saveStep);
            if (Time.time > currTime + slow) 
            {
                currTime = Time.time;
                canCat = true;
            }
 

            if (AllowedCut.Contains(tileOnDirPosition) && canCat)
            {
                Vector3 playerPos = transform.position + saveStep;
                tilemap.SetTile(tilemap.WorldToCell(playerPos), afterCut);
            }

            canCat = false; //for the next frame, flag=false as default.
        }


    }
}
