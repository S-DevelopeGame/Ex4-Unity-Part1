using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMoverDijkstra : TargetMoverDijkstra
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 newTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SetTarget(newTarget);
        }
    }
}
