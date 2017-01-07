using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_counter : MonoBehaviour {
    public static int counter = 0;
    public int[,,] map;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        //drawLevels temp = new drawLevels();
        //map = temp.getMap();
        /*if (col.gameObject.tag == "Hammer05_head")
        {
            Debug.Log("collisionEnter");
        }*/
        //if (Input.GetButton("Fire1"))
        //{
        //int i = (int)col.transform.position.x;
        Debug.Log(col.transform.position);
        int x, y, z;
        x = (int)col.transform.position.x; 
        y = (int)col.transform.position.y;
        z = (int)col.transform.position.z;
        
        //  Debug.Log("collisionEnter");
        //Debug.Log(col.GetInstanceID());
        //Debug.Log(map[x,y,z]);
            counter++;
          //  Debug.Log(counter);
        //}

    }
}
