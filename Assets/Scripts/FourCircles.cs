using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourCircles : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;

    private List<GameObject> colors = new List<GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Fill(string color) {
        Debug.Log("color " + color);
        GameObject current = Instantiate(getForName(color), this.transform, false);
        float x = -2.9f + (1.95f * colors.Count);
        current.transform.localPosition = new Vector3(x, 0.0f);
        colors.Add(current);
    }

    private GameObject getForName(string color) {
        if (color.Contains("Red")) {
            return red;
        }
        return blue;
    }
}
