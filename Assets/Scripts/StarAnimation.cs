using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour {
    private float delta;
    private SpriteRenderer star;
    private float movementSpeed =0.1f;
    void Start()
    {
        float scale = Random.Range(0.1f, 0.5f);
        this.transform.localScale = new Vector3(scale, scale, scale);
        star = GetComponent<SpriteRenderer> ();
        StartCoroutine(lightStar());
        Destroy(gameObject, 60f);
    }
    void Update()
    {
        Vector3 topScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (transform.position.x > topScreen.x+0.3 || transform.position.y > topScreen.y+0.3 || transform.position.x < -topScreen.x-0.3 || transform.position.y < -topScreen.y-0.3)
            Destroy(gameObject);
            transform.position += transform.up * Time.deltaTime * movementSpeed;

    }
    IEnumerator lightStar()
    {
        while (star.color.a != 1.0f)
        {
            star.color = new Color(star.color.r, star.color.g, star.color.b, star.color.a + 0.3f*Time.deltaTime);
            yield return 0;
        }
        if (star.color.a >= 1.0f)
            StartCoroutine(lightOff());
    }
    IEnumerator lightOff()
    {
        while (star.color.a != 0f)
        {
            star.color = new Color(star.color.r, star.color.g, star.color.b, star.color.a - 0.3f*Time.deltaTime);
            yield return 0;
        }
    }
}
