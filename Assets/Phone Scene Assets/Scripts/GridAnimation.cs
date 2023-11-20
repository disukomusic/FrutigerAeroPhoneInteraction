using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridAnimation : MonoBehaviour
{
    private Animator _animator;
    private bool _isOpen;
    public static GridAnimation instance;
    

    private void Start()
    {
        instance = this;
        _animator = GetComponent<Animator>();
        _isOpen = false;
    }

    public void AnimationOpen()
    {
        _animator.SetTrigger("Open");
        _isOpen = true;
    }
    
    public void AnimationClose()
    {
        //_animator.SetTrigger("OnClose");
        _isOpen = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            AnimationOpen();
        }
    }
}
