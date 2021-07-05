using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public float temperature = 3.6f;
    public MeshRenderer[] cows;
    public MeshRenderer[] trees;
    private int cowindex = -1;
    private int treeindex = -1;


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
            cowindex += 1;
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
    }

    public void UpdateTreeIndex(bool increment)
    {

        if (increment)
        {
            treeindex += 1;
        }
        else treeindex -= 1;

        if (treeindex < 0)
        {
            treeindex = 0;
        }
        trees[treeindex].enabled = increment;
    }


    //UpdateCowIndex
    //globeinstanz.transform.GetChild(1).GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = true;
}
