using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detect : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        if (!(col.gameObject.tag.ToString().Equals("terrain", System.StringComparison.Ordinal)))
        {
            Destroy(col.gameObject);
        }
        //Destroy(this.gameObject);
       Debug.Log(col.gameObject.tag.ToString());
    }
}
