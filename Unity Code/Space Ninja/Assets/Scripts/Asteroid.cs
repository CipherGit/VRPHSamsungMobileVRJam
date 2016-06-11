using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

    public GameObject player;

	void Update () {
        float distance = player.transform.position.z - this.transform.position.z;
        if (distance > 25)
        {
            Destroy(this.gameObject);
        }
	}
}
