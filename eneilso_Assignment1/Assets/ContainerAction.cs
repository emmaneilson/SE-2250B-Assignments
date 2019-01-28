using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerAction : MonoBehaviour
{
    public Quaternion moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
       
            
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(2, 0, 2);
        }
           
    }
}
