using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMover1 : MonoBehaviour
{
    protected Vector3 saveStep;
    protected Vector3 NewPosition()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            saveStep = Vector3.left;
            return transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            saveStep = Vector3.right;
            return transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            saveStep = Vector3.down;
            return transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            saveStep = Vector3.up;
            return transform.position;
        }
        else
        {
            return transform.position;
        }
    }


    void Update()
    {
        transform.position = NewPosition();
    }
}
