using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeLineRendererBehavior : MonoBehaviour
{
    public float cameraDistanceToNodes;

    private LineRenderer lineR;

    

    private void Start()
    {
        lineR = GetComponent<LineRenderer>();
    }


    void OnMouseDown()
    {

    }


    private void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.x = newPos.x - gameObject.transform.position.x;
        newPos.y = newPos.y - gameObject.transform.position.y;
        newPos.z = cameraDistanceToNodes;
        if (Input.GetMouseButton(0))
        {
            lineR.SetPosition(1, newPos);
        }
        Debug.Log(newPos);
    }
}
