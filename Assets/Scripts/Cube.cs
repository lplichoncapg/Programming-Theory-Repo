using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cube : Shape
{
    //POLYMORPHISM
    protected override void DisplayInfos()
    {
        InfosText.text = "This is a cube with a 6*L^2 area";
    }
}
