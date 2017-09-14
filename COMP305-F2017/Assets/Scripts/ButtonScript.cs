using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public float buttonNumber;
    void Start()
    {

    }

    void Update()
    {
    }
    private void OnMouseDown()
    {
        ClothingChangeScript.styleChange = buttonNumber;
        Debug.Log("Left Click by " + buttonNumber);
    }
}
