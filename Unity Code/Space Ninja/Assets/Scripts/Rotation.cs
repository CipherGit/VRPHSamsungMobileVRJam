using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public int x;
    public int y;
    public int z;
    public int speed;
	
	void Update () {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
	}
}
