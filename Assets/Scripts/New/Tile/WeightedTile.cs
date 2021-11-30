using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WeightedTile : MonoBehaviour
{
    [SerializeField] public int weight;
    [SerializeField] public TileBase tile;
}
