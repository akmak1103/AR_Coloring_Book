using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public GameObject spawnPosition,endPosition;
    void Start()
    {
        Debug.Log("obstacle Behaviour start function");
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector3(0, 0, 15), ForceMode2D.Impulse);
        transform.position = Vector3.Lerp(spawnPosition.transform.position,endPosition.transform.position,0);
    }
}
