
using System;
using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using VRC.SDKBase;
using VRC.Udon;

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
