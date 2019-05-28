using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBird : MonoBehaviour {
    public GameObject end;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,3);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        end.SetActive(true);
    }


}
