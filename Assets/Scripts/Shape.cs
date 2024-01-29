using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    //ENCAPLSULATION
    [SerializeField] private Text infosText;
    protected Text InfosText{get => infosText;}

    void OnMouseDown(){
        DisplayInfos();
    }

    //ABSTRACTION
    protected virtual void DisplayInfos(){
        InfosText.text = "This is a shape !";
    }
}
