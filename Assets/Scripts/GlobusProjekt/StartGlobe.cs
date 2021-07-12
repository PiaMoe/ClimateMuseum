using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGlobe : MonoBehaviour
{
    private bool globestatus = false;
    private bool globeCreation = false;
    private Slider globeinstanz;
    public GameObject globe;
    private int indexCow = 0;
    private int indexTree = 0;

    //Instructions:
    public GameObject instruction;
    public GameObject DefInstr;
    public GameObject MetInstr;
    private bool DefInstructionsOn = false;
    private bool MetInstructionsOn = false;

    //Colors:
    private Color black = new Color32(60, 60, 60, 200);
    private Color dark_grey = new Color32(120, 120, 120, 255);
    private Color light_grey = new Color32(170, 170, 170, 255);
    private Color white = new Color32(255, 255, 255, 100);



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
                globeinstanz.UpdateCowIndex(false);
                indexCow = 0;
                globeinstanz.ChangeAtmosphere(white);
                Debug.Log("Keine Kuehe, index ist: " + indexCow);

                break;
            case 1:
                globeinstanz.ChangeAtmosphere(light_grey);
                //globeinstanz.ChangeDegree("3,6°");
                
                Debug.Log("2 Kuhe, index ist: " + indexCow);
                if (MetInstructionsOn)
                {
                    MetInstr.SetActive(false);
                    MetInstructionsOn = false;
                }
                if (cownumber >= indexCow)
                {
                    globeinstanz.UpdateCowIndex(true);
                    globeinstanz.UpdateCowIndex(true);
                }
                else
                {
                    globeinstanz.UpdateCowIndex(false);
                }
                indexCow = 1;
                break;
            case 2:
                globeinstanz.ChangeAtmosphere(dark_grey);
                //globeinstanz.ChangeDegree("3,7°");
               
                Debug.Log("3 Kuhe, index ist: " + indexCow);
                if (cownumber >= indexCow)
                {
                    globeinstanz.UpdateCowIndex(true);
                }
                else
                {
                    globeinstanz.UpdateCowIndex(false);
                    globeinstanz.UpdateCowIndex(false);
                }
                indexCow = 2;
                break;
            case 3:
                globeinstanz.ChangeAtmosphere(black);
               // globeinstanz.ChangeDegree("3,8°");
                
                Debug.Log("5 Kuhe, index ist: " + indexCow);
                if (cownumber >= indexCow)
                {
                    globeinstanz.UpdateCowIndex(true);
                    globeinstanz.UpdateCowIndex(true);
                }
                indexCow = 3;
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
                globeinstanz.UpdateTreeIndex(false);
                indexTree = 0;
                Debug.Log("Keine B?ume, index ist: " + indexTree);

                break;
            case 1:
                if (DefInstructionsOn)
                {
                    DefInstr.SetActive(false);
                    DefInstructionsOn = false;
                }
                if (plantnumber >= indexTree)
                {
                    globeinstanz.UpdateTreeIndex(true);
                    globeinstanz.UpdateTreeIndex(true);
                    indexTree = 1;
                    Debug.Log("2 Baum, index ist: " + indexTree);
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
                    Debug.Log("3 B?ume, index ist: " + indexTree);
                }
                else
                {
                    globeinstanz.UpdateTreeIndex(false);
                    globeinstanz.UpdateTreeIndex(false);
                    indexTree = 2;
                    Debug.Log("zweiter false Fall");
                }
                break;
            case 3: 
                if (plantnumber >= indexTree)
                {
                    globeinstanz.UpdateTreeIndex(true);
                    globeinstanz.UpdateTreeIndex(true);
                    indexTree = 3;
                    Debug.Log("5 B?ume, index ist: " + indexTree);
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

            instruction.SetActive(false);
            DefInstr.SetActive(true);
            MetInstr.SetActive(true);
            DefInstructionsOn = true;
            MetInstructionsOn = true;
          
        }
        else if(globestatus == true)
        {
            DestroyPrefab();
            globestatus = false;

            instruction.SetActive(true);
           // DefInstr.SetActive(false);
            // MetInstr.SetActive(false);
        }
    }


    public void CreatePrefab()
        {
        if (globeCreation == false)
        {
            globeinstanz = Instantiate(globe, new Vector3(11, 1, 3), Quaternion.identity).GetComponent<Slider>();
            globeCreation = true;
        } 
        else
        {
            globeinstanz.gameObject.SetActive(true);
        }
    }

    public void DestroyPrefab()
    {
       globeinstanz.gameObject.SetActive(false);
    }




    //Cow Methode:
    //GameObject Kuh = this.gameObject.transform.GetChild(1).GetChild(0).gameObject;
    //Kuh.SetActive(true);
    // this.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
    //StartGlobe.globeinstanz
    //Instantiate(cow, new Vector3(0, 0.8f, -0.5f), Quaternion.Euler(-34.5f, 0, 0), this.gameObject.transform);
}
