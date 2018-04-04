using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBeh : MonoBehaviour {

    public float speed1 = 50;
    public float speed2 = 50;
    float y, z;

    // Use this for initialization
    void Start () {
        y = Random.Range(20, 50);
        z = Random.Range(-10, 10);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.up * speed1 * Time.deltaTime);
        this.transform.RotateAround(Vector3.zero, new Vector3(0, y, z), speed2 * Time.deltaTime);
    }
}
