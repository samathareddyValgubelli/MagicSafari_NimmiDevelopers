﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameUI : MonoBehaviour
{
    private static GameUI instance = null;

    // Game Instance Singleton
    public static GameUI Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public enum enSelectedType
    {
        Gravity,
        Destroy,
        Shape,
        Magic,
        None
    }

    public enSelectedType selectedType;

    private void Start()
    {
        OnClickTypeToApply(-1);
    }

    public void OnClickTypeToApply(int i)
    {
        switch(i)
        {
            case 0:
                selectedType = enSelectedType.Destroy;
                break;
            case 1:
                selectedType = enSelectedType.Gravity;
                break;
            case 2:
                selectedType = enSelectedType.Shape;
                break;
            case 3:
                selectedType = enSelectedType.Magic;
                break;
            default:
                selectedType = enSelectedType.None;
                break;
        }
    }
   
}

