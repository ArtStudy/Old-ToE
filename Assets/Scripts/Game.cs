using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    private bool explosionFlag = false;
    public GameObject elementsPanel;
    public GameObject[] elementsIcons;
    public GameObject[] elements;
    public int amountOpenedElements=0;
    private Vector3[] elementsPos;
    private Vector2 screenSize;
    private float lastTime = 0f;
    void Start () {
        screenSize = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
	}

	void Update () {

	}

    public GameObject explosion;

    private void OnMouseDown()
    {
        if (explosionFlag == false)
        {
            Vector3 pos = new Vector3(0, 0, this.gameObject.transform.position.z+0.5f);
            Instantiate(explosion, pos, Quaternion.identity);
            pos.z -= 1f;
            Instantiate(elements[0],pos,Quaternion.identity);
            addUI();
            addComponent(0);
            explosionFlag = true;
        }
    }
    private void addComponent(int number)
    {
        Vector3 elementPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,1));
        elementPos += new Vector3(-0.5f,-0.5f-amountOpenedElements,0);
        //elementsPos[amountOpenedElements] = elementPos;
        amountOpenedElements++;
        Instantiate(elementsIcons[0], elementPos, Quaternion.identity);
    }
    private void addUI()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height/2, 2));
        pos += new Vector3(-0.5f, 0, 0);
        Instantiate(elementsPanel,pos,Quaternion.Euler(0,0,180));
        pos = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height/2,2));
        pos += new Vector3(+0.5f, 0, 0);
        Instantiate(elementsPanel, pos, Quaternion.identity);
    }
    private void iconToComponent()
    {

    }
    private void OnMouseDrag()
    {
        float colddown = 3f;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.gameObject.transform.position.z - 0.5f));
        int posY = Mathf.CeilToInt(mousePos.y );
        if (screenSize.x - mousePos.x < 1 && Time.time >(lastTime+colddown))
        {
            lastTime = Time.time;
            Instantiate(elements[5 - posY], mousePos, Quaternion.identity);
           // StartCoroutine(createElement(mousePos,posY));
            Debug.Log(posY);
        }
    }
    IEnumerator createElement(Vector3 mousePos,int posY)
    {
        Instantiate(elements[5 - posY], mousePos, Quaternion.identity);
        yield return new WaitForSeconds(10.0f);
    }
}
