using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AvatarMovement

{
    public float moveSpeed = 5f;
    public float jumpForce = 30f;
    public float replicatedTime = 1;
    

    // A Test behaves as an ordinary method
    [Test]
    public void AvatarMovesRight()
    {
        //Right Arrow Keycode value
        float horizontalInput = 1f;

        //The result we expect from one click right (expectedVector = effect of 1 right click)
        Vector3 expectedVector = new Vector3(horizontalInput, 0f, 0f);
        var expectedPosition = expectedVector * replicatedTime * moveSpeed;

        //Testing we get expected value
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        var positionVal = movement * replicatedTime * moveSpeed;


        Assert.AreEqual(expectedPosition, positionVal, "The right arrow does not produce the right output");
       
    }

    [Test]
    public void AvatarMovesLeft()
    {
        //Right Arrow Keycode value (replicated)
        float horizontalInput = -1f;

        //The result we expect from one click right (expectedVector = effect of 1 right click)
        Vector3 expectedVector = new Vector3(horizontalInput, 0f, 0f);
        var expectedPosition = expectedVector * replicatedTime * moveSpeed;

        //Testing we get expected value
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        var positionVal = movement * replicatedTime * moveSpeed;


        Assert.AreEqual(expectedPosition, positionVal, "The right arrow does not produce the right output");

    }

    [Test]
    public void AvatarJumps()
    {

        Vector2 expectedJump = new Vector2();
        Vector2 testJump = new Vector2();

        //Avatar is on the ground
        bool grounded = true;

        //Expected results
        
        bool avatarIsGrounded = true;

        if (avatarIsGrounded)
        {
           expectedJump = new Vector2(0, jumpForce);
        }

        //Testing

        //Replicates an up arrow (jump)
        var verticalInput = 1f;
        

        //Same logic used in player controller
        if (grounded && verticalInput == 1f)
        {
            testJump = new Vector2(0, jumpForce);
        }

        Debug.Log(expectedJump + "   " + testJump);
        Assert.AreEqual(expectedJump, testJump, "The right arrow does not produce the right output");

    }

}
