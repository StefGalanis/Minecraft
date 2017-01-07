using System.Collections;
using System.Collections.Generic;
//using System.Object;
using UnityEngine;

public class hammerEventCollider : MonoBehaviour {
    public static Vector3 location;
    public GameObject red_cube_debris, blue_cube_debris, green_cube_debris,
                        t1_cube_debris, t2_cube_debris, t3_cube_debris, hammer_spawn;
    public Material  hammer_changing_color;
    private int[,,] map;
    public static int enter = 0;
    public static int exit = 0;
    public static int num_of_derbis;
    public static int num_of_hammers = 3,flag = 0;
    public static int hammer_durability = 0;
    public static int lastObjectHitted;
    /*public hammerEventCollider()
    {
       num_of_hammers = drawLevels.K;
    }*/
    void OnTriggerEnter(Collider other)

    {

        //int[,,] collision_map;
        //Random rnd = new Random();
        Debug.Log("on trigger enter");
        Debug.Log(other.transform.position);
        if (flag == 0)
        {
            num_of_hammers = drawLevels.K;
            flag = 1;
            drawLevels temp = new drawLevels();
            map = temp.getMap();
            Debug.Log(map[0,0,0]);
        }
        // other.gameObject.GetComponent<>();
        //Collision map = drawLevels.getCollisionMap();
        if (Input.GetButton("Fire1")&&(num_of_hammers>0))
        {
            lastObjectHitted = other.GetInstanceID();
            if (hammer_durability < 100)
            {
                hammer_durability += 10;
            }
            else if(hammer_durability == 100 && num_of_hammers >= 1)
            {
                num_of_hammers--;
                hammer_durability = 0;
            }
            //other.GetComponent<GameObject>.OnCollisionEnter;
            //hammer_changing_color.SetColor("_SpecColor",new Vector4(0,0,0,0));
            Debug.Log(hammer_durability);
            Debug.Log("num_of_hammers");
            Debug.Log(num_of_hammers);
            hammer_changing_color.SetColor("_Color",new Vector4(1 - hammer_durability * 0.01f, 1 - hammer_durability * 0.01f ,1 - hammer_durability * 0.01f , 1));
            //Debug.Log(num_of_hammers);
            location = other.transform.position;
            string cube_tag = other.tag;
            //Debug.Log(cube_tag);
            num_of_derbis = Random.Range(4,8);
            //Debug.Log(collision_counter.counter);
            //Debug.Log(num_of_derbis);
            //Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
            //Destroy(other.gameObject);
            //Instantiate(t1_cube_debris, new Vector3(location.x, location.y, location.z), Quaternion.identity
            //other.transform)
            int x, y, z;
            float tempx = other.transform.position.x -0.5f;
            float tempy = other.transform.position.y -0.5f;
            float tempz = other.transform.position.z -0.5f;
            x = (int)tempx;
            y = (int)tempy;
            z = (int)tempz;
            //Debug.Log(x);
            //Debug.Log(y);
            //Debug.Log(z);
            //Debug.Log(map[5, 1, 14]);
            map[x, y, z] += 1;
            if (cube_tag.Equals("red_cube", System.StringComparison.Ordinal)&&(map[x,y,z]==3))
            {
                Destroy(other.gameObject);
                int hammer_coin = UnityEngine.Random.Range(0, 10);
                if (hammer_coin > 5)
                {
                    Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                }
                else if (hammer_coin < 5)
                {
                    Debug.Log("nohammer");
                }
                while (num_of_derbis>0) {
                   
                    Instantiate(red_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x, location.y + 0.25f, location.z), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    Debug.Log(cube_tag);
                    num_of_derbis--;
                }
                

            }
            else if (cube_tag.Equals("green_cube", System.StringComparison.Ordinal) && (map[x, y, z] == 3))
            {
                Destroy(other.gameObject);
                int hammer_coin = UnityEngine.Random.Range(0, 10);
                if (hammer_coin > 5)
                {
                    Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                }
                else if (hammer_coin < 5)
                {
                    Debug.Log("nohammer");
                }
                while (num_of_derbis > 0)
                {

                    Instantiate(green_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x, location.y + 0.25f, location.z), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    Debug.Log(cube_tag);
                    num_of_derbis--;
                }
                

            }
            else if (cube_tag.Equals("blue_cube", System.StringComparison.Ordinal) && (map[x, y, z] == 3))
            {
                Destroy(other.gameObject);
                int hammer_coin = UnityEngine.Random.Range(0, 10);
                if (hammer_coin > 5)
                {
                    Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                }
                else if (hammer_coin < 5)
                {
                    Debug.Log("nohammer");
                }
                while (num_of_derbis > 0)
                {

                    Instantiate(blue_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x, location.y + 0.25f, location.z), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    Debug.Log(cube_tag);
                    num_of_derbis--;
                }
                //Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);


            }
            else if (cube_tag.Equals("t1_cube", System.StringComparison.Ordinal) && (map[x, y, z] == 3))
            {
                Destroy(other.gameObject);
                int hammer_coin = UnityEngine.Random.Range(0, 10);
                if (hammer_coin > 5)
                {
                    Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                }
                else if (hammer_coin < 5)
                {
                    Debug.Log("nohammer");
                }
                while (num_of_derbis > 0)
                {

                    Instantiate(t1_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x, location.y + 0.25f, location.z), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    Debug.Log(cube_tag);
                    num_of_derbis--;
                }


            }
            else if (cube_tag.Equals("t2_cube", System.StringComparison.Ordinal) && (map[x, y, z] == 3))
            {
                Destroy(other.gameObject);
                int hammer_coin = UnityEngine.Random.Range(0, 10);
                if (hammer_coin > 5)
                {
                    Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                }
                else if (hammer_coin < 5)
                {
                    Debug.Log("nohammer");
                }
                while (num_of_derbis > 0)
                {

                    Instantiate(t2_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x, location.y + 0.25f, location.z), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    Debug.Log(cube_tag);
                    num_of_derbis--;
                }


            }
            else if (cube_tag.Equals("t3_cube", System.StringComparison.Ordinal) && (map[x, y, z] == 3))
            {
                Destroy(other.gameObject);
                int hammer_coin = UnityEngine.Random.Range(0,10);
                if (hammer_coin > 5)
                {
                    Instantiate(hammer_spawn, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                }
                else if(hammer_coin < 5)
                {
                    Debug.Log("nohammer");
                }
                while (num_of_derbis > 0)
                {

                    Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x, location.y + 0.25f, location.z), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x + 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z + 0.25f), Quaternion.identity);
                    //Instantiate(t3_cube_debris, new Vector3(location.x - 0.25f, location.y + 0.25f, location.z - 0.25f), Quaternion.identity);
                    //Debug.Log(cube_tag);
                    num_of_derbis--;
                }


            }
            //Instantiate(GameObject)
            //Debug.Log(location);
            //Instantiate()
            //other.gameObject.get
            enter = 0;
            exit = 0;
        }

    }
    void OnTriggerStay(Collider other)
    {
        /*Debug.Log("on trigger stay");
        if (Input.GetButton("Fire1"))
        {
            location = other.transform.position;
            string cube_tag = other.tag;
            //Debug.Log(cube_tag);
            //Destroy(other.gameObject);
            if (tag.Equals("t3_cube", System.StringComparison.Ordinal))
            {
                Debug.Log(cube_tag);
            }
            //Instantiate(GameObject)
            Debug.Log(location);
            //Instantiate()
            //other.gameObject.get

        }*/
    }
        void OnTriggerExit(Collider other)
        {
            Debug.Log("on trigger exit");
        }
    void update()
    {
        
    }
    
    }


