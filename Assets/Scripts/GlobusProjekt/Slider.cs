using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
    public MeshRenderer[] cows;
    public MeshRenderer[] trees;
    private int cowindex = -1;
    private int treeindex = -1;
    public ParticleSystem atmosphere;
    public Text degree;


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
            cowindex++;
            Debug.Log("Erste If Abfrage, cowindex ist: " + cowindex);
            for (int i = 0; i <= cowindex; i++)
            {
                cows[i].enabled = increment;
            }
            Debug.Log("Schleife hinzufügen, cowindex ist: " + cowindex + "increment ist: " + increment);
        }
        else
        {
            cowindex--;
            Debug.Log("Erster Else fall, cowindex ist: " + cowindex);
            for(int i = cows.Length - 1; i > cowindex; i--)
            {
                cows[i].enabled = increment;
            }
        }

        
    }

    public void UpdateTreeIndex(bool increment)
    {
        if (increment)
        {
            treeindex++;
            Debug.Log("Erste If Abfrage, treeindex ist: " + treeindex);
            for (int i = 0; i <= treeindex; i++)
            {
                trees[i].enabled = increment;
            }
            Debug.Log("Schleife hinzufügen, treeindex ist: " + treeindex + "increment ist: " + increment);
        }
        else
        {
            treeindex--;
            Debug.Log("Erster Else fall, treeindex ist: " + treeindex);
            for (int i = trees.Length - 1; i > treeindex; i--)
            {
                trees[i].enabled = increment;
            }
        }
    }

    public void ChangeAtmosphere (Color color)
    {
        ParticleSystem.MainModule settings = atmosphere.main;
        settings.startColor = new ParticleSystem.MinMaxGradient(color);
        Debug.Log("Atmosphäre wird geändert" + color);
    }

    public void ChangeDegree (string text)
    {
        Debug.Log("Gradzahl wird geändert");
        degree.text = text;
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
