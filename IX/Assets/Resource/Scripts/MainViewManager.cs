using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainViewManager : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start () {
        if (text!= null) {
            text.text = "你好，老大~";
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
