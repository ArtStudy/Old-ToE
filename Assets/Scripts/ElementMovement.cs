using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementMovement : MonoBehaviour {
    void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objectPos;
    }
}
