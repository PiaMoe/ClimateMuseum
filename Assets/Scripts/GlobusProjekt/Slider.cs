using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Slider : MonoBehaviour
{
    public MeshRenderer[] cows;
    public MeshRenderer[] trees;
    private int cowindex = 4;
    private int treeindex = 1;

    // Atmosphere
    public ParticleSystem atmosphere;
    private int currentColor = 115;
    private int ColorInfluence = 14;

    // Temperature
    public Text degree;
    private float currentTemp = 3.6f;
    private float TempInfluenceCow = 0.08f;
    private float TempInfluenceTree = 0.02f;


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
            ChangeDegree(TempInfluenceCow);
            ChangeAtmosphere(-ColorInfluence);
            Debug.Log("Erste If Abfrage, cowindex ist: " + cowindex);
            for (int i = 0; i <= cowindex; i++)
            {
                cows[i].enabled = increment;
            }
            Debug.Log("Schleife hinzufügen, cowindex ist: " + cowindex + "increment ist: " + increment);
        }
        else
        {
            ChangeDegree(-TempInfluenceCow);
            ChangeAtmosphere(ColorInfluence);
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
            ChangeDegree(-TempInfluenceTree);
            ChangeAtmosphere(ColorInfluence);
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
            ChangeDegree(TempInfluenceTree);
            ChangeAtmosphere(-ColorInfluence);
            treeindex--;
            Debug.Log("Erster Else fall, treeindex ist: " + treeindex);
            for (int i = trees.Length - 1; i > treeindex; i--)
            {
                trees[i].enabled = increment;
            }
        }
    }

    public void ChangeAtmosphere (int colorValue)
    {
        currentColor += colorValue;
        byte RGB = (byte) currentColor;
        Color color = new Color32(RGB, RGB, RGB, 255);

        ParticleSystem.MainModule settings = atmosphere.main;
        settings.startColor = new ParticleSystem.MinMaxGradient(color);
        Debug.Log("Atmosphäre wird geändert" + color);
    }

    public void ChangeDegree (float change)
    {
        Debug.Log("Gradzahl wird geändert");
        currentTemp += change;
        double roundTemp = Math.Round(currentTemp, 1);
        Debug.Log("gerundete Temperatur: " + roundTemp);
        degree.text = "+" + roundTemp.ToString() + " °C";
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
