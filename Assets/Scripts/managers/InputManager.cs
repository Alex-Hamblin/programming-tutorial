using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{

    private static GameControls _gameControls;

    public static void Init(Player myPlayer)
    {
        _gameControls = new GameControls();

        _gameControls.Permanent.Enable();

        _gameControls.InGame.Movement.performed += jeff =>
        {
            myPlayer.SetMovementDirection(jeff.ReadValue<Vector3>());

        };

        _gameControls.InGame.Jump.started += jeff =>
        {
            myPlayer.Jump();
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
        _gameControls.InGame.Enable();
    }
}
