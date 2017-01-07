using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class ChangeCameras : MonoBehaviour
{
    public GameObject target;
    public Camera FirstPersonCharacter;
    public Camera Camera360;
    private GameObject FPS;
    //public Camera OutsideCamera;
    private bool flag;
    // Use this for initialization
    void Start()
    {
        Camera360.enabled = true;
        FirstPersonCharacter.enabled = false;
        FPS = GameObject.Find("FPSController");
        FPS.GetComponent<FirstPersonController>().enabled = false;
        Camera360.transform.LookAt(target.transform);
        //OutsideCamera.enabled = true;
        //flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // FpsCamera.enabled = false;
            FirstPersonCharacter.enabled = false;
            Camera360.enabled = true;
            Camera360.transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
            flag = true;
            //OutsideCamera.enabled = false;
            /*FpsCamera.enabled = !FpsCamera.enabled;
            MainCamera.enabled = !MainCamera.enabled;*/

        }
        else if (Input.GetKeyDown(KeyCode.V))
        {

            Camera360.enabled = !Camera360.enabled;
            FirstPersonCharacter.enabled = !FirstPersonCharacter.enabled;
            FPS.GetComponent<FirstPersonController>().enabled = !FPS.GetComponent<FirstPersonController>().enabled;

            /*Camera360.enabled = false;
             if (flag == true)
             {
                 FirstPersonCharacter.enabled = true;
                 //OutsideCamera.enabled = false;
                 flag = false;

             }
             else
             {
                 FirstPersonCharacter.enabled = false;
                 //OutsideCamera.enabled = true;
                 flag = true;
             }*/


        }
    }
}
