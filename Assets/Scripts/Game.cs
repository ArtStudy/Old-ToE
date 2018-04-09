using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public bool explosionFlag;
	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {

	}

    public GameObject explosion;

    private void OnMouseDown()
    {
        if (explosionFlag == false)
        {
            Instantiate(explosion, explosion.transform.position, Quaternion.identity);
            explosionFlag = true;
        }
    }
}
