using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


public class RespawnTest
{
    
    // A Test behaves as an ordinary method
    [Test]
    public void Respawns()
    {
        bool respawn = false;

        float startingHealth = 3;

        float currentHealth = 2;

        currentHealth = Mathf.Clamp(currentHealth -1, 0, startingHealth);

        if (currentHealth > 0)
        {
            respawn = true;
        }
        Debug.Log("Avatar respawned");
        Assert.AreEqual(respawn, true);

    }
    [Test]
    public void Death()
    {
        bool dead = false;
        Debug.Log("Dog currently alive");

        float startingHealth = 3;

        float currentHealth = startingHealth;

        currentHealth = Mathf.Clamp(currentHealth - 3, 0, startingHealth);

        if (currentHealth < 1)
        {
            dead = true;
        }
        Debug.Log("User dies");

        Assert.AreEqual(dead, true);

    }

}

