using UnityEngine;
using System.Collections;

public class OtherAsteroidSpawner : MonoBehaviour {

    public GameObject player;
    public GameObject asteroid;
    public float Count = 0f;
    public float First_Position = 50f;
    public float Last_Position = 9000f;
    public float Min_Distance_X = -20f;
    public float Max_Distance_X = 20f;
    public float Min_Distance_Y = -20f;
    public float Max_Distance_Y = 20f;
    public float Min_Distance_Z = 1000f;
    public float Max_Distance_Z = 2000f;

    public float Spawning_Rate = 1f;

	void Start () {
        InvokeRepeating("Spawn", 0, Spawning_Rate);
	}

    void Spawn()
    {
        float treshold = player.transform.position.z;
        float x = Random.Range(Min_Distance_X, Max_Distance_Y);
        float y = Random.Range(Min_Distance_Y, Max_Distance_Y);
        float z = Random.Range(treshold + Min_Distance_Z, treshold + Max_Distance_Z);
        if (z < Last_Position)
        {
            Instantiate(asteroid, new Vector3(x, y, z), Random.rotation);
        }
        
    }

}
