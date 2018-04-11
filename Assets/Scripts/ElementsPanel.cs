using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsPanel : MonoBehaviour {
    RectTransform rectTransform;
	// Use this for initialization
	void Start () {
        /*	for (int i=0;i<10;i++)
            { 
                Vector3 pos = new Vector3(this.gameObject.transform.position.x,4.5f - i, this.gameObject.transform.position.z);
                if (i+1<elements.Length)
                    Instantiate(elements[1], pos, Quaternion.identity);
                else
                    Instantiate(elements[0], pos, Quaternion.identity);
            }*/
        ResizePanel();
	}
	
	// Update is called once per frame
	void Update () {
        //OnMouseEnter();
	}

    void ResizePanel()
    {
        rectTransform = GetComponent<RectTransform>();
        Vector3 newScale = new Vector3(1, 1, this.gameObject.transform.position.z);
        this.transform.localScale = newScale;
    }
    public GameObject[] elements;
    
}
