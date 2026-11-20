
using System;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace com.rurinya.welcomeboard
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
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
}

