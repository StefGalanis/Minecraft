using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer_script : MonoBehaviour {

    Animator anim;
    
	void Start () {
        anim = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        /* if (Input.GetButtonDown("Fire1"))
         {
             anim.SetBool("left_click", false);
             //Debug.Log("GetButton");
         }
         //else if (Input.GetMouseButtonUp(0))
         else if (Input.GetButtonUp("Fire1"))
         {
             //Debug.Log("GetButtonDown");
             anim.SetBool("left_click", true);
         }*/
        anim.SetBool("left_click", Input.GetButton("Fire1"));
        //float click = Input.GetKey("Fire1");
        //anim.SetBool("click",true);

    }
}
