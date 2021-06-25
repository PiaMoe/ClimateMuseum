using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGlobe : MonoBehaviour
{
    private bool globestatus = false;
    private GameObject globeinstanz;
    public GameObject globe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && globestatus == false)
        {
            // this.globe.transform.position = new Vector3(10, 2, 0);
            //GameObject globeinstanz = Instantiate(globe, new Vector3(11, 1, 3), Quaternion.identity);
            CreatePrefab();
            globestatus = true;
        }
        else if (Input.GetMouseButtonUp(0) && globestatus == true)
        {
            Destroy(globeinstanz);
            globestatus = false;
        }

    }

    public void CreatePrefab()
        {
        globeinstanz = Instantiate(globe, new Vector3(11, 1, 3), Quaternion.identity);
        globeinstanz.SetActive(true);
        }

    public void DestroyPrefab()
        {
        Destroy(globeinstanz);
        }
}
