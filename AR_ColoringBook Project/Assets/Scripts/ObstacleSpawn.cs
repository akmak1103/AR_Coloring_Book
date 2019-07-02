using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject obstacle;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ObstacleSpawner");
    }

    private void Update()
    {
        
    }

    IEnumerator ObstacleSpawner ()
    {
        while (true)
        {
            GameObject obstacle1 = Instantiate (obstacle, spawnPosition.position, Quaternion.identity);
            obstacle1.transform.Rotate(0,-28f,0,Space.Self);
            Rigidbody rb = obstacle1.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(50,0,0);
            yield return new WaitForSeconds(2f);
        }
    }
}