using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Slider : MonoBehaviour
{
    public MeshRenderer[] cows;
    public MeshRenderer[] trees;
    private int cowindex = 4;
    private int treeindex = 1;

    // Atmosphere
    public ParticleSystem atmosphere;
    private int currentColorAtmo = 115;
    private int colorAtmoInfluence = 14;

    // Grass Color
    public Material EarthColor;
    private int currentColorGrass = 96;
    private int colorGrassInfluence = 8;

    // Water Color
    public Material WaterColor;
    private int currentGValueWater = 70;
    private int currentBValueWater = 150;
    private int G_WaterInfluence = 4;
    private int B_WaterInfluence = 7;


    // Temperature
    public TMP_Text degree;
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
            ChangeDegree(TempInfluenceCow);
            ChangeAtmosphere(-colorAtmoInfluence);
            ChangeGrassColor(colorGrassInfluence);
            ChangeWaterColor(-G_WaterInfluence, -B_WaterInfluence);

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
            ChangeDegree(-TempInfluenceCow);
            ChangeAtmosphere(colorAtmoInfluence);
            ChangeGrassColor(-colorGrassInfluence);
            ChangeWaterColor(G_WaterInfluence, B_WaterInfluence);

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
            ChangeAtmosphere(colorAtmoInfluence);
            ChangeGrassColor(-colorGrassInfluence);
            ChangeWaterColor(G_WaterInfluence, B_WaterInfluence);

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
            ChangeAtmosphere(-colorAtmoInfluence);
            ChangeGrassColor(colorGrassInfluence);
            ChangeWaterColor(-G_WaterInfluence, -B_WaterInfluence);

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
        currentColorAtmo += colorValue;
        byte RGB = (byte) currentColorAtmo;
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

    public void ChangeGrassColor (int colorValue)
    {
        currentColorGrass += colorValue;
        Debug.Log("Grass Color R-Value int: " + currentColorGrass);
        byte R = (byte)currentColorGrass;
        Color color = new Color32(R, 147, 65, 255);
        EarthColor.color = color;
        Debug.Log("Grass Color R-Value byte: " + R);
    }

    public void ChangeWaterColor (int colorValueG, int colorValueB)
    {
        currentGValueWater += colorValueG;
        currentBValueWater += colorValueB;

        byte G = (byte)currentGValueWater;
        byte B = (byte)currentBValueWater;
        
        Color color = new Color32(0, G, B, 255);
        WaterColor.color = color;
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
