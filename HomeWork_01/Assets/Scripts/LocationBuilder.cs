using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    void Start()
    {
        BuildLocation();


    }

    
    void Update()
    {
        
    }

    private void BuildLocation()
    {
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground.transform.position = new Vector3 (0, -0.5f, 0);
        ground.transform.localScale = new Vector3 (10, 0.5f, 5);
        ground.name = new string ("Ground");

        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        player.transform.position = new Vector3 (-1, 0, 0);
        player.transform.localScale = new Vector3 (0.5f, 1, 0.5f);
        player.name = new string ("Player");
        player.AddComponent<Rigidbody>();
        player.AddComponent<PlayerMovement>();
        player.AddComponent<Triggered>();

        GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
        enemy.transform.position = new Vector3 (1, 0, 0);
        enemy.transform.localScale = new Vector3 (0.5f, 1, 0.5f);
        enemy.name = new string ("Enemy");
        enemy.AddComponent<Rigidbody>();
        
        
        
        

    }
}
