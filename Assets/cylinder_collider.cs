using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder_collider : MonoBehaviour {
    //int num_of_hammers;
    // Use this for initialization
    private int exit_once = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "hammer_spawn" && exit_once == 0)
        {
            Destroy(col.gameObject);
            int temp = hammerEventCollider.num_of_hammers +1;
            //num_of_hammers++;
            hammerEventCollider.num_of_hammers = temp;
            Debug.Log(hammerEventCollider.num_of_hammers);
            exit_once = 1;
        }

    }
    void OnCollisionExit(Collision col)
    {
        Debug.Log("onCollisionExit");
        if (col.gameObject.tag == "hammer_spawn" && exit_once == 1)
        {
            exit_once = 0;
            Debug.Log(exit_once);
        }
    }
}
