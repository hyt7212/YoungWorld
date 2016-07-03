using UnityEngine;
using System;
using System.Collections;
using ExitGames.Client.Photon;

public class GameClient : MonoBehaviour, IPhotonPeerListener {

	PhotonPeer peer;

	void Start () {
		peer = new PhotonPeer (this, ConnectionProtocol.Udp);
		peer.Connect ("192.168.31.153:5055", "MMoDemo");
	}

	void Update () {
		peer.Service ();
	}

	public void DebugReturn(DebugLevel level, string message) {
		throw new System.NotImplementedException ();
	}

	public void OnEvent(EventData eventData) {
		throw new System.NotImplementedException ();
	}

	public void OnOperationResponse(OperationResponse operationResponse) {
		throw new System.NotImplementedException ();
	}

	public void OnStatusChanged(StatusCode statusCode) {
		switch (statusCode) 
		{
			case StatusCode.Connect:
				Debug.Log("连接成功");
				break;
			case StatusCode.Disconnect:
				Debug.Log ("关闭连接");
				break;
			case StatusCode.ExceptionOnConnect:
				Debug.Log ("连接异常");
				break;
		}
	}
}