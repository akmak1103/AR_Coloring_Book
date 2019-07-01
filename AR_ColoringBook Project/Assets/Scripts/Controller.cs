using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject spawn_pos;
    public Animator path;
    public GameObject env;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void is_Running_Now()
    {
        path.enabled = true;
        spawn_pos.SetActive(true);
        env.SetActive(false);
    }
}
