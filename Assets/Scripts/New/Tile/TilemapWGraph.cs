using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapWGraph : IWGraph<Vector3Int>
{
    private Dictionary<TileBase, int> w; //map of tilebases with weights
    private Tilemap tilemap;
    private AllowedTilesW allowedTiles;

    //same weights
    public TilemapWGraph(Tilemap tilemap1, AllowedTilesW allowedTiles1, int weight)
    {
        this.tilemap = tilemap1;
        this.allowedTiles = allowedTiles1;
    }


    
    public int getW(Vector3Int node)
    {
        TileBase tb = tilemap.GetTile(node);
       
        return allowedTiles.GetWeight(tb);
    }


    static Vector3Int[] directions = {
            new Vector3Int(-1, 0, 0),
            new Vector3Int(1, 0, 0),
            new Vector3Int(0, -1, 0),
            new Vector3Int(0, 1, 0),
    };

    public IEnumerable<Vector3Int> Neighbors(Vector3Int node)
    {
        foreach (var direction in directions)
        {
            Vector3Int neighborPos = node + direction;
            TileBase neighborTile = tilemap.GetTile(neighborPos);
            if (allowedTiles.Get().Contains(neighborTile))
                yield return neighborPos;
        }
    }



}
