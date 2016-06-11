using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

    public GameObject player;
    public GameObject asteroid;
    public float Count = 0f;
    public float First_Position = 50f;
    public float Last_Position = 9000f;
    public float Min_Distance_Z = 50f;
    public float Max_Distance_Z = 80f;

    public float Spawning_Rate = 3f;

	void Start () {
        InvokeRepeating("Spawn", 0, Spawning_Rate);
	}

    void Spawn()
    {
        float treshold = player.transform.position.z;
        float NextPosition = First_Position;
        float x = asteroid.transform.position.x;
        float y = asteroid.transform.position.y;
        float z = NextPosition + Random.Range(treshold + Min_Distance_Z, treshold + Max_Distance_Z);
        NextPosition = NextPosition + Random.Range(Min_Distance_Z, Max_Distance_Z);
        if (z < Last_Position)
        {
            Instantiate(asteroid, new Vector3(x, y, z), Random.rotation);
        }
    }

}
