using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    //POLYMORPHISM
    protected override void DisplayInfos()
    {
        InfosText.text = "This is a sphere with a 4*PI*r^2 area";
    }
}
