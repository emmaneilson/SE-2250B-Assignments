using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour
{
    public Vector3 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = gameObject.transform.position;
    }

    public void OnMouseOver()
    {

        if (Input.GetMouseButton(1)) //right click detection
        {
            gameObject.transform.position = startPoint;
        }

    }

}
