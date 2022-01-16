using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooter shooter;
    private Health health;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooter = GetComponent<Shooter>();
        health = GetComponent<Health>();
    }

    private void Update()
    {
        if (!health.isAlive) return;

        float horizontalDirection = Input.GetAxis(GlobalVars.HORIZONTAL_AXIS);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalVars.JUMP);

        if (Input.GetButtonDown(GlobalVars.Fire_1))
        {
            shooter.Shoot();
        }
        
        playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    }
}
