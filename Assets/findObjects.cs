using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findObjects : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GameObject temp;
        temp = GameObject.Find("t1_cube");
        Debug.Log(temp.tag);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
