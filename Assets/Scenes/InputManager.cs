using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    private static Controls _controls;

    public static void Init()
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += ctx => 
        {
        
        };
    }

    public static void GameMode()
    {

    }

    public static void UIMode()
    {

    }

}

