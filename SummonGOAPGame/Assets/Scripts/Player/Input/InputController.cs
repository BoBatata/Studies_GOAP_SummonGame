using UnityEngine;

public class InputController
{
    public InputManager inputManager;
    public Vector2 moveDir => inputManager.Player.Walk.ReadValue<Vector2>();

    public InputController()
    {
        inputManager = new InputManager();
        EnableInput();
    }

    private void EnableInput() => inputManager.Player.Enable();
    private void DisableInput() => inputManager.Player.Disable();
}
