
using System;
using System.Drawing.Text;
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GetInstanceOwner : UdonSharpBehaviour
{
    [SerializeField]private TextMeshProUGUI targetObject;
    private VRCPlayerApi testPlayer;
    void Start()
    {
        var players = new VRCPlayerApi[VRCPlayerApi.GetPlayerCount()];
        VRCPlayerApi.GetPlayers(players);
        foreach (VRCPlayerApi player in players){
            if (player.isInstanceOwner){
                targetObject.text = player.displayName;
                return;
            }
        }
        targetObject.text = "ERR";
    }
}
