using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static GameControls _gameControls;

    public static void Init(PlayerPrefs myPlayer)
    {
        _gameControls = new GameControls();

        _gameControls.Permanent.Enable();

        

        _gameControls.InGame.Movement.performed += jeff =>
        {
            object value = myPlayer.SetMoveDirection(jeff.ReadValue<Vector3>());
        };
    }
    public static void SetGameControls()
    {
        _gameControls.InGame.Enable();
        _gameControls.UI.Disable();
    }
    public static void SetUIControls()
    {
        _gameControls.UI.Enable();
        _gameControls.InGame.Disable();
    }

    internal static void Init(Player myPlayer)
    {
        throw new NotImplementedException();
    }
}
