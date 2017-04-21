using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIWindowManager.Instance.Initialize();
		UIWindowManager.Instance.ShowWindow<UIMenuCtrl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
