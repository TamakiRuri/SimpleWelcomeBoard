
using System;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace com.rurinya.welcomeboard
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class UpdateTime : UdonSharpBehaviour
    {
        [SerializeField]private TextMeshProUGUI targetObject;
        void Start()
        {
            targetObject.text = DateTime.Now.ToString("HH:mm:ss");
        }
        void Update(){
            targetObject.text = DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
