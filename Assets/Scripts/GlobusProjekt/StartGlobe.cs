using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGlobe : MonoBehaviour
{
    private bool globestatus = false;
    private Slider globeinstanz;
    public GameObject globe;
    private int indexCow = 0;
    private int indexTree = 0;


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
        Debug.Log("cownumber: " + cownumber);
        
        switch (cownumber)
        {
            default:  
                globeinstanz.UpdateCowIndex(false);
                indexCow = 0;
                Debug.Log("Keine Kuehe, index ist: " + indexCow);

                break;
            case 1:     
                if (cownumber >= indexCow)
                {
                    globeinstanz.UpdateCowIndex(true);
                    indexCow = 1;
                    Debug.Log("1 Kuh, index ist: " + indexCow);
                }
                else
                {
                    globeinstanz.UpdateCowIndex(false);
                    indexCow = 1;
                    Debug.Log("erster false fall");
                }            
                break;
            case 2:       
                if(cownumber >= indexCow)
                {
                    globeinstanz.UpdateCowIndex(true);
                    indexCow = 2;
                    Debug.Log("2 Kuehe, index ist: " + indexCow);
                }
                else
                {
                    globeinstanz.UpdateCowIndex(false);
                    indexCow = 2;
                    Debug.Log("erster false fall");
                }
                break;
            case 3:
                if (cownumber >= indexCow)
                {
                    globeinstanz.UpdateCowIndex(true);
                    indexCow = 3;
                    Debug.Log("3 Kühe, index ist: " + indexTree);
                }
                break;
        }
    }

    public void Plant(float plantnumber)
    {
        if (globeinstanz == null) return;
        Debug.Log("plantnumber: " + plantnumber);

        switch (plantnumber)
        {
            default:
                globeinstanz.UpdateTreeIndex(false);
                indexTree = 0;
                Debug.Log("Keine Bäume, index ist: " + indexTree);

                break;
            case 1:
                if (plantnumber >= indexTree)
                {
                    globeinstanz.UpdateTreeIndex(true);
                    indexTree = 1;
                    Debug.Log("1 Baum, index ist: " + indexTree);
                }
                else
                {
                    globeinstanz.UpdateTreeIndex(false);
                    indexTree = 1;
                    Debug.Log("erster false fall");
                }
                break;
            case 2:
                if (plantnumber >= indexTree)
                {
                    globeinstanz.UpdateTreeIndex(true);
                    indexTree = 2;
                    Debug.Log("2 Bäume, index ist: " + indexTree);
                }
                else
                {
                    globeinstanz.UpdateTreeIndex(false);
                    indexTree = 2;
                    Debug.Log("zweiter false Fall");
                }
                break;
            case 3: 
                if (plantnumber >= indexTree)
                {
                    globeinstanz.UpdateTreeIndex(true);
                    indexTree = 3;
                    Debug.Log("3 Bäume, index ist: " + indexTree);
                }
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




    //Cow Methode:
    //GameObject Kuh = this.gameObject.transform.GetChild(1).GetChild(0).gameObject;
    //Kuh.SetActive(true);
    // this.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
    //StartGlobe.globeinstanz
    //Instantiate(cow, new Vector3(0, 0.8f, -0.5f), Quaternion.Euler(-34.5f, 0, 0), this.gameObject.transform);
}
