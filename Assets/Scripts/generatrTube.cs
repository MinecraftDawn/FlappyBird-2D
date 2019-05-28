using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatrTube : MonoBehaviour {
    public GameObject tube;

    private void OnEnable() {
        InvokeRepeating("generate", 1, 1);
    }

    private void generate() {
        GameObject tubeInstance = Instantiate(tube);
        tubeInstance.transform.position =
            new Vector2(tubeInstance.transform.position.x, UnityEngine.Random.Range(-3f, 3f));
    }

}