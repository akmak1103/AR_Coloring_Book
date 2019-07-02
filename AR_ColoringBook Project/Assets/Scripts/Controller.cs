using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject spawn_pos,spawn_tree;
    public Animator path;
    public GameObject env;
    public AudioSource roar_sound,roar_sound2,run,jump;
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
        spawn_tree.SetActive(true);
        env.SetActive(false);
        run.Play();
    }

    public void roar()
    {
        roar_sound.Play();
    }

    public void roar2()
    {
        roar_sound2.Play();
    }

    public void jumping()
    {
        jump.Play();
    }

}
