using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionsandconditions : MonoBehaviour
{ 
    // Stat is called before the first frame update
    
    
        float sum(float a, float b)
        {
            return a + b;
       
        }
        
        float prod(float a, float b)
        {
            return a * b;
           
        }
       
        float div(float a, float b)
        {


            if (b == 0)
            {
               Debug.Log("error");
               return -999;

            }
            else
            {
                return a / b;
            }

        }


    

    // Update is called once per frame
    void Start()
    {
      Debug.Log(sum(5,10));
      Debug.Log(prod(6,9));
      Debug.Log(div(9,3));
      Debug.Log(div(9,0));

    }
    void Update()
    {
        
    }
    
   
        
    
   void fixedUpdate()
    {
        
    }
    
}
        

