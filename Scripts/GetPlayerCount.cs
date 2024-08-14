
using System;
using System.Drawing.Text;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GetPlayerCount : UdonSharpBehaviour
{
    [SerializeField]private TextMeshProUGUI targetObject;
    private VRCPlayerApi testPlayer;
    private int playerCount;
    void Start()
    {
        if (testPlayer == null)
        {
            targetObject.text = "1";
            return;
        }
        playerCount=VRCPlayerApi.GetPlayerCount();
        targetObject.text = playerCount.ToString();
    }

    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        playerCount=VRCPlayerApi.GetPlayerCount();
        targetObject.text = playerCount.ToString();
    }

    public override void OnPlayerLeft(VRCPlayerApi player)
    {
        playerCount=VRCPlayerApi.GetPlayerCount();
        targetObject.text = (playerCount - 1).ToString();
    }
}
