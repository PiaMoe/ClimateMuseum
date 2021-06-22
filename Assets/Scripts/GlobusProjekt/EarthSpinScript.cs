using UnityEngine;
using System.Collections;

public class EarthSpinScript : MonoBehaviour {
    public float speed = 10f;

    void Update() {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }

    public void spin(float newSpeed)
    {
        this.speed = newSpeed;
    }
}