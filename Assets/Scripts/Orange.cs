using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour {

    private FourCircles fourCircles;

    // Start is called before the first frame update
    void Start() {
        fourCircles = GameObject.Find("FourCircles").GetComponent<FourCircles>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown() {
        Debug.Log("clicked " + this.name);
        fourCircles.Fill(this.name);
     
    }
}
