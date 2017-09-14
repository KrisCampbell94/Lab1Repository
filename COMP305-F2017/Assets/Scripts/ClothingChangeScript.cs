using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingChangeScript : MonoBehaviour {
    //private GameObject buttonA;
    public static float styleChange = 1f;

    public Sprite clothingA;
    public Sprite clothingB;
    public Sprite clothingC;
	// Use this for initialization
	void Start ()
    {
	}

    // Update is called once per frame
    void Update()
    {
        if (styleChange == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = clothingA;
            Debug.Log("A");
        }
        else if (styleChange == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = clothingB;
            Debug.Log("B");
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = clothingC;
            Debug.Log("C");
        }
    }
}
