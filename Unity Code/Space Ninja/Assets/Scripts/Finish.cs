using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Time.timeScale = 0;
    }

}
