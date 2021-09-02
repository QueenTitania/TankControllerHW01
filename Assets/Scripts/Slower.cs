using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : Enemy
{
    protected override void PlayerImpact(Player player)
    {
        TankController controller = player.GetComponent<TankController>();
        if (controller != null)
            controller.MoveSpeed = .05f;
    }
}
