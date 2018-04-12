using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementAnimation : MonoBehaviour {

    private SpriteRenderer element;
    void Start()
    {
        element = GetComponent<SpriteRenderer>();
        StartCoroutine(elementAnimation());
    }
    void Update()
    {
      
    }
    IEnumerator elementAnimation()
    {
        while(element.color.a!=1.0f)
        { 
            element.color = new Color(element.color.r,element.color.g,element.color.b,element.color.a+0.01f);
            yield return 0;
        }
    }
}
