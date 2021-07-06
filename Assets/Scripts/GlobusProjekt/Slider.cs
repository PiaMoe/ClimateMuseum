using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public GameObject cow;
    public MeshRenderer[] cows = new MeshRenderer[2];
    private int cowindex = -1;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void UpdateCowIndex(bool increment)
    {
        if (increment)
        {
            cowindex = cowindex + 1;
            Debug.Log("Erste If Abfrage, cowindex ist: " + cowindex);
            for (int i = 0; i <= cowindex; i++)
            {
                cows[i].enabled = increment;
            }
            Debug.Log("Schleife hinzufügen, cowindex ist: " + cowindex + "increment ist: " + increment);
        }
        else
        {
            cowindex = cowindex - 1;
            Debug.Log("Erster Else fall, cowindex ist: " + cowindex);
            for(int i = cows.Length - 1; i > cowindex; i--)
            {
                cows[i].enabled = increment;
            }
        }

        
    }



    // if (cowindex< 0)
     //   {
       //     cowindex = -1;
       //     Debug.Log("Zweite If Abfrage, cowindex ist: " + cowindex);
       // }
    //cows[cowindex].enabled = increment;
    //UpdateCowIndex
    //globeinstanz.transform.GetChild(1).GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = true;
}
