using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTube : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        this.transform.Translate(Vector2.left * 0.1f);

        if (transform.position.x < -11) {
            Destroy(gameObject);
        }
    }
}