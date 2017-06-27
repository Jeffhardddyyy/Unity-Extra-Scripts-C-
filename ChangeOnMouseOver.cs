using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOnMouseOver : MonoBehaviour {
    //attach to a game object that you want to change colour

    public Material MouseOver;      //When the Mmouse is on the gameObject, what color do you want it to be?
    public Material MouseAway;      //When the mouse is NOT on the gameObject, what color do you want it to be?
    private Renderer Material;      //ignore


    void Start()
    {//on start
        Material = gameObject.GetComponent<Renderer>();     //ignore
    }


    void OnMouseOver()
    {//When the mouse hovers over the gameObject
        Material.material = MouseOver;  //change the material to the material of "MouseOver"
    }

    void OnMouseExit()
    {//When the mouse is NOT on the gameObject
        Material.material = MouseAway;  //change the material to the material of "MouseAway"
    }
}
