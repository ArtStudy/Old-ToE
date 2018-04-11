using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLight : MonoBehaviour {

    public GameObject[] stars;
    
	// Use this for initialization
	void Start () {
        StartCoroutine(spawnStars());

	}
    IEnumerator spawnStars()
    {
        while(true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane/5));
            Instantiate(stars[Random.Range(0, stars.Length)], pos,Quaternion.Euler(0,0,Random.Range(0,360)));
            yield return new WaitForSeconds(Random.Range(1f,3f));
        }
    }
}
