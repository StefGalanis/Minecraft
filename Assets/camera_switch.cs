using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_switch : MonoBehaviour {
    //public GameObject MainCamera;
    //public Camera [] Cameras;
    //public GameObject firstPersonCamera,exploreCamera;.
    public Camera firstPersonCamera, exploreCamera;
    private bool check;
	// Use this for initialization
	void Start () {
        /*Debug.Log(this.GetComponent<Camera>());
        if (this.GetComponent<Camera>().tag == "outter_camera") {
            this.GetComponent<Camera>().enabled = true;
            other_camera.enabled = false;
        }*/
        firstPersonCamera.gameObject.active = false;
        exploreCamera.gameObject.active = true;
        check = true;

        //GetComponent<>();
	}

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.R))
        {

            // FpsCamera.enabled = false;
            //Camera360.enabled = true;
           // Camera360.transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
            //flag = true;
            //OutsideCamera.enabled = false;
            /*FpsCamera.enabled = !FpsCamera.enabled;
            MainCamera.enabled = !MainCamera.enabled;

        }*/
        if (Input.GetKeyDown(KeyCode.V))
        {
            //this_camera.enabled = !this_camera.enabled;
            //other_camera.enabled = !other_camera.enabled;
            //FirstPersonCharacter.enabled = !FirstPersonCharacter.enabled;
            //Camera360.enabled = !Camera360.enabled;
            if (check)
            {
                firstPersonCamera.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
                firstPersonCamera.gameObject.active = true;
                exploreCamera.gameObject.active = false;
            }
            else {
                firstPersonCamera.gameObject.active = false;
                //firstPersonCamera.GetComponentInParent<GameObject>().GetComponent<firstpersoncontroller>()
                exploreCamera.gameObject.active = true;
            }
            check = !check;


        }
    }
}
