using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease : CollectibleBase
{
    [SerializeField] float speedAmount = .4f;

    protected override void Collect(Player player)
    {
        TankController controller = player.GetComponent<TankController>();
        if (controller != null)
            controller.MoveSpeed = speedAmount;
    }

    protected override void Movement(Rigidbody rb)
    {
        //calculate rotation
        Quaternion turnOffset = Quaternion.Euler(MovementSpeed, MovementSpeed, MovementSpeed);
        rb.MoveRotation(rb.rotation * turnOffset);
    }
}
