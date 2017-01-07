using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class drawLevels : MonoBehaviour {
    public GameObject t1_cube,t2_cube,t3_cube,red_cube,blue_cube,green_cube,invisible_cube,fps_controller;
    // Use this for initialization
    public Material hammer_changing_color;
    public static int K,N,L;
    int flag = 0;
    //GameObject[,,] map = new GameObject[10, 1, 10];
    //int[,,] map = new int[10, 1, 10];
    int[,,] map = new int [16,4,16];
    List<Vector3> empty_spaces = new List<Vector3>();
    Vector3[] empty_spaces_array;
    //int[,,] collision_map = new int[10, 1, 10];
    void Start()
    {
        hammer_changing_color.SetColor("_Color",Color.white);
        L = 0;
        N = 0;
        K = 0;
        Debug.Log(this.tag);
        // [,,] empty_spaces = new int[10,1,10];
//      float x = 0, y = 0, z = 0;
        string buffer = "";
        //GameObject[,,] map =new GameObject[10,1,10];
        //int [,,] collision_map = new int[10, 1, 10];
        string[] words;
        int counter = 0;
        int level = 0;
        string[] seperators = new string[] { " " };
        string[] seperators2 = new string[] { "L=" , "N=", "K="};
        string[] seperators3 = new string[] { "LEVEL " };
        int lx = 0, ly = 0, lz = 0;
        string path = @"C:\Users\SG\Desktop\maze.txt";
        //StreamReader sr = File.OpenText(path);
        TextReader sr = new StreamReader(path);
        /*if(counter == 3){
            /*GameObject[,,]*/ //map = new GameObject[N,L,N];//NxLxN
                               //}
                               //GameObject[,,] map = new GameObject[16];//NxLxN
                               //Debug.Log(sr.ReadLine());
                               //while ((buffer = sr.ReadLine()).Equals("END OF MAZE", StringComparison.Ordinal) == false)
                               //Instantiate(invisible_cube, new Vector3(0.5f , 0.5f , -0.5f), Quaternion.identity);
        while ((buffer = sr.ReadLine())!= null)
        {
            //Debug.Log("i am in");
            if (counter == 3 && flag==0)
            {
                /*GameObject[,,]*/
                //this.transform.x
                //this
                Debug.Log("am i in?");

                flag = 1;
                Debug.Log(N);
                map = new int[N, L, N];//NxLxN
                //empty_spaces = new int[N+1, L, N+1] ;
                
            }
            if (counter < 3)
            {
                //Debug.Log("i am in");
                //buffer = sr.ReadLine();
                words = buffer.Split(seperators2, StringSplitOptions.None);
                //Debug.Log(words[1]);
                if (counter == 0)
                {
                    //Debug.Log(words[1]);
                    L = Int32.Parse(words[1]);
                    counter++;
                    //Debug.Log(counter);
                }
                else if (counter == 1)
                {
                   // Debug.Log(words[1]);
                    N = Int32.Parse(words[1]);
                    counter++;
                    //Debug.Log(counter);
                }
                else if(counter ==2)
                {
                    //Debug.Log(words[1]);
                    K = Int32.Parse(words[1]);
                    counter++;
                    //Debug.Log(counter);
                }
            }
            else
            {
                //buffer = sr.ReadLine();
                words = buffer.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                //Debug.Log(words[0]);
                if (words[0].Equals("LEVEL", StringComparison.Ordinal))

                {
                    //Debug.Log(words[0
                    level = Int32.Parse(words[1]);
                    Debug.Log(lz);
                    lz = 0;
                    if (level > 1)
                    {
                        ly++;
                        lz = 0;
                        //Debug.Log(ly);
                    }
                }
                // string path = @"D:\maze.txt";
                //buffer = "";
                //string[] words;
                // FileStream maze = new FileStream("maze.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                //maze.Read
                else
                {
                    for (lx = 0; lx < words.Length; lx++)
                    {
                        //(invisible_cube,new Vector3(),Quaternion.identity);
                        if (level == 1)
                        {
                            //Debug.Log(lz);
                        }
                        //buffer = sr.ReadLine();
                        if (words[lx].Equals("R", StringComparison.Ordinal))
                        {

                             Instantiate(red_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity) ;
                            map[lx, ly, lz] = 0;
                            //Debug.Log(map[lx, ly, lz].tag);
                            //Instantiate(red_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity) ;
                            // collision_map[lx, ly, lz] = 0;
                        }
                        else if (words[lx].Equals("G", StringComparison.Ordinal))
                        {

                           // map[lx,ly,lz] = Instantiate(green_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            Instantiate(green_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            map[lx, ly, lz] = 0;
                            //collision_map[lx, ly, lz] = 0;
                        }
                        else if (words[lx].Equals("B", StringComparison.Ordinal))
                        {

                            //map[lx, ly, lz] = Instantiate(blue_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            map[lx, ly, lz] = 0;
                            Instantiate(blue_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            //collision_map[lx, ly, lz] = 0;
                        }
                        else if (words[lx].Equals("T1", StringComparison.Ordinal))
                        {
                            map[lx, ly, lz] = 0;
                            //map[lx, ly, lz] = Instantiate(t1_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            Instantiate(t1_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            //  collision_map[lx, ly, lz] = 0;
                        }
                        else if (words[lx].Equals("T2", StringComparison.Ordinal))
                        {
                            map[lx, ly, lz] = 0;
                            //map[lx, ly, lz] = Instantiate(t2_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            Instantiate(t2_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            //collision_map[lx, ly, lz] = 0;
                        }
                        else if (words[lx].Equals("T3", StringComparison.Ordinal))
                        {
                            map[lx, ly, lz] = 0;
                            //map[lx, ly, lz] = Instantiate(t3_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            Instantiate(t3_cube, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                            //collision_map[lx, ly, lz] = 0;
                        }
                        else
                        {
                            if (ly == 0) {
                                //Debug.Log("array index");
                                //Debug.Log(lx);
                                //Debug.Log(ly);
                                // Debug.Log(lz);
                                //fps_controller.transform.position = ;
                                //Instantiate(fps_controller, new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
                                //
                                Vector3 tempVector = new Vector3(0.5f+lx, 0.5f + ly, 0.5f + lz);
                                empty_spaces.Add(tempVector);
                                //flag = 1;
                            }
                            //Debug.Log("nothing happens");
                        }
                        //Instantiate(t1_cube, new Vector3(x + ly, 1, 5), Quaternion.identity);
                        //lx = 0;
                    }
                    
                    lz++;
                }
                //Debug.Log(lz);
        //Debug.Log(map[3].tag);
                //}
                //}
            }
        }
        empty_spaces_array = empty_spaces.ToArray();
        int array_length = empty_spaces_array.Length;
        Debug.Log(array_length);
        int num_of_space = UnityEngine.Random.Range(0,array_length-1);
        fps_controller.transform.position = empty_spaces_array[num_of_space];
        //Instantiate(fps_controller, empty_spaces_array[num_of_space], Quaternion.identity);
        /*for (int m = 0; m < N; m++)
        {
            for (int z = 0; z < N; z++)
            {

                Debug.Log(empty_spaces[z,0,m]);
            }
        }*/
        //num_of_derbis = Random.Range(4, 8);
        /*int posx = 0;
        int posz = 0;
        while (empty_spaces[posx, 0, posz] != 1)
        {
            posx++;
            posz++;
            fps_controller.transform.position = new Vector3(N - 0.5f, 0.5f, N - 0.5f);
            posx = UnityEngine.Random.Range(0, N - 1);
            posz = UnityEngine.Random.Range(0, N - 1);
        }*/
        //Instantiate(fps_controller ,new Vector3(0.5f + lx, 0.5f + ly, 0.5f + lz), Quaternion.identity);
        for (int m = 0; m < 4; m++)
        {
            for (int z = 0; z < 16; z++)
            {
                GameObject border = Instantiate(invisible_cube, new Vector3(0.5f + z, 0.5f + m, -0.5f), Quaternion.identity);
            }
        }
        for (int m = 0; m < 4; m++)
        {
            for (int z = 0; z < 16; z++)
            {
                GameObject border = Instantiate(invisible_cube, new Vector3(16.5f, 0.5f + m, 0.5f + z), Quaternion.identity);
            }
        }
        for (int m = 0; m < 4; m++)
        {
            for (int z = 0; z < 16; z++)
            {
                GameObject border = Instantiate(invisible_cube, new Vector3(-0.5f, 0.5f + m, 0.5f + z), Quaternion.identity);
            }
        }
        for (int m = 0; m < 4; m++)
        {
            for (int z = 0; z < 16; z++)
            {
                GameObject border = Instantiate(invisible_cube, new Vector3(0.5f + z, 0.5f + m, 16.5f), Quaternion.identity);
            }
        }
    }
        // Update is called once per frame
        void Update () {


        }
    public int[,,] getMap()
    {
        return map;
    }
    /*public int get_num_of_hammers()
    {
        return K;
    }*/
    /*public int[,,] getCollisionMap (){
    return collision_map;
    }*/
}