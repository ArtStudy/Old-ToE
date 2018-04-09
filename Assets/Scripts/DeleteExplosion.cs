using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExplosion : MonoBehaviour {

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
