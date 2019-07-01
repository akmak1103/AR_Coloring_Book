using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_tiger : MonoBehaviour
{
    public Animator tiger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        tiger.SetInteger("anim",1);
    }
}
