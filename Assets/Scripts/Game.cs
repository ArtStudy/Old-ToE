using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    private bool explosionFlag = false;
    public GameObject elementsPanel;
    public GameObject[] elements;
    public int amountOpenedElements=0;
	void Start () {

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
            addComponent(0);
            explosionFlag = true;
        }
    }
    private void addComponent(int number)
    {
        Vector3 elementPos = new Vector3(elementsPanel.transform.position.x, 4.5f - amountOpenedElements, 1);
        amountOpenedElements++;
        Instantiate(elements[0], elementPos, Quaternion.identity);
    }
}
