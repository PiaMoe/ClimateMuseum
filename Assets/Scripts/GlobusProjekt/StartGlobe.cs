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
     
    }

    void OnMouseDown()
    {
        if(globestatus == false)
        {
            CreatePrefab();
            globestatus = true;
        }
        else if(globestatus == true)
        {
            DestroyPrefab();
            globestatus = false;
        }
    }


    public void CreatePrefab()
        {
        globeinstanz = Instantiate(globe, new Vector3(11, 1, 3), Quaternion.identity);
        //globeinstanz.SetActive(true);
        }

    public void DestroyPrefab()
        {
        Destroy(globeinstanz);
        }
}
