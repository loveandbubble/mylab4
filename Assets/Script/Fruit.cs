using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour 
{
    //start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is callled once per frame
    void Update()
    {

    }  
   
    public void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player"){
            Destroy(gameObject);
        }
    }
      
}