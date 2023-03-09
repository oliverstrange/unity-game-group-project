using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


public class HealthTests
{
    
    // A Test behaves as an ordinary method
    [Test]
    public void HealthIncrease()
    {
        float startingHealth = 3;

        float currentHealth = 2;

        float expected = 3;

        currentHealth = Mathf.Clamp(currentHealth + 1, 0, startingHealth);

        Debug.Log("Health increase by 1");

        Assert.AreEqual(currentHealth, expected);

    }
    [Test]
    public void HealthDecrease()
    {
        float startingHealth = 3;

        float currentHealth = startingHealth;

        float expected = 2;

        currentHealth = Mathf.Clamp(currentHealth - 1, 0, startingHealth);

        Debug.Log("Health decreases by 1" );

        Assert.AreEqual(currentHealth, expected);

    }

}

