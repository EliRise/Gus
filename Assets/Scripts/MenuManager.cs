using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;



public class MenuManager : MonoBehaviourPunCallbacks
{
    public InputField creatInput;
    public InputField joinInput;

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(creatInput.text, roomOptions);
    }

    // Update is called once per frame
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text); 
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
