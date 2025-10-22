using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputController inputController;
    public PlayerMovement playerMovement;
    
    public float maxHealth = 100f;
    public float health = 100f;

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
