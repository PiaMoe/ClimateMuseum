using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public float temperature = 3.6f;
    public GameObject cow;
    public MeshRenderer[] cows = new MeshRenderer[2];
    private int cowindex = 0;
    public GameObject[] cows2; //nur test Array


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test Startmethode");
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(temperature);
    }

    public void UpdateCowIndex(bool increment)
    {
        Debug.Log("Kuh wird erstellt");
        
        if (increment)
        {
            cowindex = cowindex + 1;
            Debug.Log("Erste If Abfrage");
        }
        else cowindex -= 1;

        if (cowindex < 0)
        {
            cowindex = 0;
            Debug.Log("Zweite If Abfrage");
        }
        Debug.Log(cowindex);
        cows[cowindex].enabled = increment;
        //cows2[cowindex].SetActive(increment);
    }


    //UpdateCowIndex
    //globeinstanz.transform.GetChild(1).GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = true;
}
