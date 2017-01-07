using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E))
        {
            //hammer_changing_color.SetColor("_Color", Color.white);
            Application.Quit();
        }
    }
}
