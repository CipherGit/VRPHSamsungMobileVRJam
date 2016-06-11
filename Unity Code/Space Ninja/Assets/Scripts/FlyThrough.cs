using UnityEngine;
using System.Collections;

public class FlyThrough : MonoBehaviour {

    public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position += transform.forward * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}

}
