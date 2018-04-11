using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public bool explosionFlag;
    public GameObject elementsPanel;
	// Use this for initialization
	void Start () {
        Vector3 panelPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,this.gameObject.transform.position.z));
        Instantiate(elementsPanel, panelPos, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}

    public GameObject explosion;

    private void OnMouseDown()
    {
        if (explosionFlag == false)
        {
            Vector3 pos = new Vector3(0, 0, this.gameObject.transform.position.z+1);
            Instantiate(explosion, pos, Quaternion.identity);
            explosionFlag = true;
        }
    }
}
