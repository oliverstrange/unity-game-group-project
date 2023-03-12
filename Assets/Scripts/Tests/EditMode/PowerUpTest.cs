using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PowerUpTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void PowerUpCollisionTest()
    {
        // Arrange
        int powerUpSpped = 15;
        int currentSpeed = 10;

        bool powerUpCollision = false;

        Debug.Log("Dod takes power up");
        powerUpCollision = true;

        if (powerUpCollision)
        {
            currentSpeed = powerUpSpped;
        }

        Assert.AreEqual(currentSpeed, 15);

    }
}