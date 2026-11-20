
using System;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace com.rurinya.welcomeboard
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class UpdateLocalUserID : UdonSharpBehaviour
    {
        [SerializeField]private TextMeshProUGUI TextObject;
        private VRCPlayerApi playerapi;
        private String localPlayer;
        void Start()
        {
            localPlayer = Networking.LocalPlayer.displayName;
            TextObject.text = localPlayer;
        }
    }
}
