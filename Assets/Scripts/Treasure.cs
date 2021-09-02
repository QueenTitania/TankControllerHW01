using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : CollectibleBase
{

    protected override void Collect(Player player)
    {
        
    }

    protected override void Movement(Rigidbody rb)
    {
        //calculate rotation
        Quaternion turnOffset = Quaternion.Euler(0, 0, MovementSpeed);
        rb.MoveRotation(rb.rotation * turnOffset);
    }
}
