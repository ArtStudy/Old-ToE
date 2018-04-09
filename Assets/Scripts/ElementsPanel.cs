using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0;i<10;i++)
        {
            Vector3 pos = new Vector3(this.gameObject.transform.position.x,5 - i, 0);
            Instantiate(elements[0], pos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        //OnMouseEnter();
	}
    public GameObject[] elements;
    
}
