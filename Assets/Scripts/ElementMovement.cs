using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementMovement : MonoBehaviour {
    private float speed = 3f;
    private float acceleration = 3f;
    void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = Vector3.MoveTowards(transform.position, objectPos, speed*Time.deltaTime);
        speed += Time.deltaTime * acceleration;
    }
    private void OnMouseUp()
    {
        speed = 3f;
    }
    void Update()
    {
        Vector3 screenBorder = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (transform.position.x > screenBorder.x + 0.1 || transform.position.y > screenBorder.y + 0.1 || transform.position.x < -screenBorder.x - 0.1 || transform.position.y < -screenBorder.y - 0.1)
            Destroy(gameObject);
    }
}
