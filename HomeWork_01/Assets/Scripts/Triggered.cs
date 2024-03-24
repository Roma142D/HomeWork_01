using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Triggered : MonoBehaviour
{
    
   
  
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody)
        {
            Debug.Log("Hit");
        }
    }
    
}
