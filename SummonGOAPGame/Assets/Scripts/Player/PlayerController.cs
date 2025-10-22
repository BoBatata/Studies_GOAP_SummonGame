using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputController inputController;
    public PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        inputController = new InputController();
    }

    private void FixedUpdate()
    {
        playerMovement.MoveHandler(inputController);
    }
}
