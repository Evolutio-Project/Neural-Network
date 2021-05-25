﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorTileGrid : MonoBehaviour
{
    
    public GameObject pixelSprite;
    public int size;

   
   GameObject[][] grid;
    public void Start()
    {
        
        //print(size);
        grid = new GameObject[size][];
        print(grid.Length);
        
        for (int i=0; i<grid.Length; i++)
        {
           grid[i] = new GameObject[size];

           for (int j=0; j<grid[i].Length; j++)
            {
                
                Vector2 pos = new Vector2((i*1)-size/2,(j*1)-size/2);
                grid[i][j] =  Instantiate(pixelSprite, pos, Quaternion.identity);
            } 
        }
        print(grid.Length);
    }
    public void FeedForwardUpdate(NeuralNetwork nn) 
    {

        
        for (int i=0; i<grid.Length; i++)
        {
           
           for (int j=0; j<grid[i].Length; j++)
            {
                float c = nn.weights[1].data[i][j];
                grid[i][j].GetComponent<SpriteRenderer>().color = new Color(c,c,c);
            } 
        }
    }
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            print(grid.Length);
        }
    }
}
