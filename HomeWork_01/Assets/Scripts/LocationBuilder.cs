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

    public Material enemyMaterial;
    public Material playerMaterial;
    public Rigidbody enemyRigidbody;
    public Rigidbody playerRigidbody;
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
        playerRigidbody = player.GetComponent<Rigidbody>();
        playerRigidbody.freezeRotation = true;
        player.AddComponent<PlayerMovement>();
        player.AddComponent<Triggered>();
        playerMaterial = player.GetComponent<Renderer>().material;
        playerMaterial.color = Color.green;

        GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
        enemy.transform.position = new Vector3 (1, 1, 0);
        enemy.transform.localScale = new Vector3 (0.5f, 1, 0.5f);
        enemy.name = new string ("Enemy");
        enemy.AddComponent<Rigidbody>();
        enemyRigidbody = enemy.GetComponent<Rigidbody>();
        enemyRigidbody.drag = 10;
        enemyRigidbody.freezeRotation = true;
        enemyMaterial = enemy.GetComponent<Renderer>().material;
        enemyMaterial.color = Color.red;

        
        
        
        

    }
}
