using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cylinder : Shape
{
    //POLYMORPHISM
    protected override void DisplayInfos()
    {
        InfosText.text = "This is a cylinder with a 2*PI*r*h + 2*PI*r^2 area";
    }
}
