using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0;i<10;i++)
        { 
            Vector3 pos = new Vector3(this.gameObject.transform.position.x,4.5f - i, 0);
            if (i+1<elements.Length)
                Instantiate(elements[1], pos, Quaternion.identity);
            else
                Instantiate(elements[0], pos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        //OnMouseEnter();
	}
    public GameObject[] elements;
    
}
