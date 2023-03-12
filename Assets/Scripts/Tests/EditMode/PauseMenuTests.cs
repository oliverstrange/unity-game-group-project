using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


public class PauseMenuTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void PauseScreenAppersAndDissapears()
    {

        // Get a reference to the "Start Menu" scene
        Scene gameScene = SceneManager.GetSceneByName("Firstviablegame");
        Debug.Log(SceneManager.GetActiveScene().name );

       
        Debug.Log("Screen is paused");

        Debug.Log("Screen is unPaused");

    }

}

