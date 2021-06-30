using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public float temperature = 3.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(temperature);
    }

    public void Cow(float cownumber)
    {
        switch (cownumber) {

            default:
                Debug.Log("Keine Kühe");
                break;
            case 1:
                // GameObject Kuh = this.gameObject.transform.GetChild(1).GetChild(0).gameObject;
                // Kuh.SetActive(true);
                // this.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
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

    
}
