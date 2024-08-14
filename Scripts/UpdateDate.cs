
using System;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class UpdateDate : UdonSharpBehaviour
{
    [SerializeField]private TextMeshProUGUI targetObject;
    void Start()
    {
        targetObject.text = DateTime.Now.ToString("yyyy/MM/dd");
    }
    void Update(){
        targetObject.text = DateTime.Now.ToString("yyyy/MM/dd");

    }
}
