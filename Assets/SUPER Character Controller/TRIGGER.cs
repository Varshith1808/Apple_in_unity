using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIGGER : MonoBehaviour
{
    public GameObject _Trigger;
    private Animator _Animator;
    // Start is called before the first frame update
    void Start()
    {
        _Animator = _Trigger.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Anything");
        _Animator.SetBool("DeathDoor",true);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Hello World");
        _Animator.SetBool("DeathDoor",false);
    }
}

