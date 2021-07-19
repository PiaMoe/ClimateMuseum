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
    private float indexCow = 5;
    private float indexTree = 2;

    //Instructions:
    public GameObject instruction;
    public GameObject DefInstr;
    public GameObject MetInstr;
    private bool DefInstructionsOn = false;
    private bool MetInstructionsOn = false;


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

        if (MetInstructionsOn)
        {
            MetInstr.SetActive(false);
            MetInstructionsOn = false;
        }

        if (cownumber >= indexCow)
        {
            globeinstanz.UpdateCowIndex(true);
        }
        else
        {
            globeinstanz.UpdateCowIndex(false);
        }
        indexCow = cownumber;
    }

    public void Plant(float plantnumber)
    {
        if (globeinstanz == null) return;
        Debug.Log("plantnumber: " + plantnumber);

        if (DefInstructionsOn)
        {
            DefInstr.SetActive(false);
            DefInstructionsOn = false;
        }

        if (plantnumber >= indexTree)
        {
            globeinstanz.UpdateTreeIndex(true);
        }
        else
        {
            globeinstanz.UpdateTreeIndex(false);
        }
        indexTree = plantnumber;
    }


    void OnMouseDown()
    {
        if (globestatus == false)
        {
            CreatePrefab();
            globestatus = true;

            instruction.SetActive(false);
            DefInstr.SetActive(true);
            MetInstr.SetActive(true);
            DefInstructionsOn = true;
            MetInstructionsOn = true;

        }
        else if (globestatus == true)
        {
            DestroyPrefab();
            globestatus = false;

            instruction.SetActive(true);
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

}


    //Cow Methode:
    //GameObject Kuh = this.gameObject.transform.GetChild(1).GetChild(0).gameObject;
    //Kuh.SetActive(true);
    // this.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
    //StartGlobe.globeinstanz
    //Instantiate(cow, new Vector3(0, 0.8f, -0.5f), Quaternion.Euler(-34.5f, 0, 0), this.gameObject.transform);


    // neuer Code Ende

    /*   switch (cownumber)
       {
           default:  
               globeinstanz.UpdateCowIndex(false);
               indexCow = 0;
               Debug.Log("Keine Kuehe, index ist: " + indexCow);

               break;
           case 1:

               Debug.Log("1 Kuhe, index ist: " + indexCow);
               if (MetInstructionsOn)
               {
                   MetInstr.SetActive(false);
                   MetInstructionsOn = false;
               }
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               else
               {
                   globeinstanz.UpdateCowIndex(false);
               }
               indexCow = 1;
               break;
           case 2:
               Debug.Log("2 Kuhe, index ist: " + indexCow);
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               else
               {
                   globeinstanz.UpdateCowIndex(false);  
               }
               indexCow = 2;
               break;
           case 3:
               Debug.Log("3 Kuhe, index ist: " + indexCow);
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               else
               {
                   globeinstanz.UpdateCowIndex(false);
               }
               indexCow = 3;
               break;
           case 4:
               Debug.Log("4 Kuhe, index ist: " + indexCow);
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               else
               {
                   globeinstanz.UpdateCowIndex(false);
               }
               indexCow = 4;
               break;
           case 5:
               Debug.Log("5 Kuhe, index ist: " + indexCow);
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               else
               {
                   globeinstanz.UpdateCowIndex(false);
               }
               indexCow = 5;
               break;
           case 6:
               Debug.Log("6 Kuhe, index ist: " + indexCow);
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               else
               {
                   globeinstanz.UpdateCowIndex(false);
               }
               indexCow = 6;
               break;
           case 7:
               Debug.Log("7 Kuhe, index ist: " + indexCow);
               if (cownumber >= indexCow)
               {
                   globeinstanz.UpdateCowIndex(true);
               }
               indexCow = 7;
               break;
       }
   }
*/

    /*
          switch (plantnumber)
          {
              default:
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
                      Debug.Log("1 Baum, index ist: " + indexTree);
                  }
                  else
                  {
                      globeinstanz.UpdateTreeIndex(false);
                      Debug.Log("erster false fall");
                  }
                  indexTree = 1;
                  break;
              case 2:
                  if (plantnumber >= indexTree)
                  {
                      globeinstanz.UpdateTreeIndex(true);
                      Debug.Log("2 B?ume, index ist: " + indexTree);
                  }
                  else
                  {
                      globeinstanz.UpdateTreeIndex(false);
                      Debug.Log("zweiter false Fall");
                  }
                  indexTree = 2;
                  break;
              case 3:
                  if (plantnumber >= indexTree)
                  {
                      globeinstanz.UpdateTreeIndex(true);   
                      Debug.Log("3 B?ume, index ist: " + indexTree);
                  }
                  else
                  {
                      globeinstanz.UpdateTreeIndex(false);
                      Debug.Log("zweiter false Fall");
                  }
                  indexTree = 3;
                  break;
              case 4:
                  if (plantnumber >= indexTree)
                  {
                      globeinstanz.UpdateTreeIndex(true);
                      Debug.Log("4 B?ume, index ist: " + indexTree);
                  }
                  else
                  {
                      globeinstanz.UpdateTreeIndex(false);
                      Debug.Log("zweiter false Fall");
                  }
                  indexTree = 4;
                  break;
              case 5:
                  if (plantnumber >= indexTree)
                  {
                      globeinstanz.UpdateTreeIndex(true);
                      Debug.Log("5 B?ume, index ist: " + indexTree);
                  }
                  else
                  {
                      globeinstanz.UpdateTreeIndex(false);
                      Debug.Log("zweiter false Fall");
                  }
                  indexTree = 5;
                  break;
              case 6:
                  if (plantnumber >= indexTree)
                  {
                      globeinstanz.UpdateTreeIndex(true);
                      Debug.Log("6 B?ume, index ist: " + indexTree);
                  }
                  else
                  {
                      globeinstanz.UpdateTreeIndex(false);
                      Debug.Log("zweiter false Fall");
                  }
                  indexTree = 6;
                  break;
              case 7: 
                  if (plantnumber >= indexTree)
                  {
                      globeinstanz.UpdateTreeIndex(true);
                      indexTree = 7;
                      Debug.Log("7 B?ume, index ist: " + indexTree);
                  }
                  break;
          }
      }
          */


