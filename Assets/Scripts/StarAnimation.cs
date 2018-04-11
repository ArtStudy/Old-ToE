using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour {
    private float delta;
    private SpriteRenderer star;
    void Start()
    {
        float scale = Random.Range(0.1f, 0.5f);
        this.transform.localScale = new Vector3(scale, scale, scale);
        delta = Random.Range(0, 10);
        star = GetComponent<SpriteRenderer> ();
        Destroy(gameObject, 300f);
    }
    void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong((Time.time+delta)/150f, 1.0f)); 
    }
}
