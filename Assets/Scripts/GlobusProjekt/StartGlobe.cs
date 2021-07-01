using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGlobe : MonoBehaviour
{
    private bool globestatus = false;
    private Slider globeinstanz;
    public GameObject globe;
    public float temperature = 3.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Cow(float cownumber)
    {

        if (globeinstanz == null) return;

        switch (cownumber)
        {

            default:
                Debug.Log("Keine Kühe");
                break;
            case 1:
                //GameObject Kuh = this.gameObject.transform.GetChild(1).GetChild(0).gameObject;
                //Kuh.SetActive(true);
                // this.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
                //StartGlobe.globeinstanz
                //Instantiate(cow, new Vector3(0, 0.8f, -0.5f), Quaternion.Euler(-34.5f, 0, 0), this.gameObject.transform);
                this.CreateCow();
                Debug.Log("1 Kuh");
                temperature += 1f;
                break;
            case 2:
                Debug.Log("2 Kühe");
                temperature += 2f;
                break;
        }
    }

    public void Plant(float plantnumber)
    {
        if (globeinstanz == null) return;
        switch (plantnumber)
        {
            default:
                Debug.Log("Keine Pflanzen");
                break;
            case 1:
                Debug.Log("1 Pflanze");
                temperature -= 1f;
                break;
            case 2:
                Debug.Log("2 Pflanzen");
                temperature -= 2f;
                break;
        }

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
        globeinstanz = Instantiate(globe, new Vector3(11, 1, 3), Quaternion.identity).GetComponent<Slider>();
        }

    public void DestroyPrefab()
        {
        Destroy(globeinstanz.gameObject);
        }

    public void CreateCow() //updateCowwIndex
    {
       Debug.Log("Kuh wird erstellt");
       //globeinstanz.transform.GetChild(1).GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
