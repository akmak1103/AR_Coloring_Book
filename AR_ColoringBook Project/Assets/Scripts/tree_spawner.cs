using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_spawner : MonoBehaviour
{
    public Transform [] spawn_Pos;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("TreeSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TreeSpawner ()
    {
        while (true)
        {
            int r = Random.Range(0,2);
            GameObject tree1 = Instantiate (tree, spawn_Pos[r].position, Quaternion.identity);
            //tree1.transform.Rotate(0,-28.768f,0,Space.Self);
            Rigidbody rb = tree1.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(50,0,1.5f);
            yield return new WaitForSeconds(0.6f);
        }
    }
}
