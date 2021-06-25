using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGlobe : MonoBehaviour
{

    public GameObject globe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
           Debug.Log("Button wurde gedrückt");
            // this.globe.transform.position = new Vector3(10, 2, 0);
            Instantiate(globe, new Vector3(11, 1, 3), Quaternion.identity);
        }

    }
}
