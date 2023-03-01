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
        Scene startMenuScene = SceneManager.GetSceneByName("Firstviablegame");

        // Assert that the scene is valid
        Assert.IsTrue(startMenuScene.IsValid());

        //Test the scene we are in
        SceneManager.SetActiveScene(startMenuScene); 

        Debug.Log(SceneManager.GetActiveScene().name);


        Scene act = SceneManager.GetActiveScene();

        // Get a reference to the game object
        GameObject gridObj = GameObject.FindWithTag("GameGrid");

        // Get a reference to the script component attached to the game object
        Pause myScript = gridObj.GetComponent<Pause>();

        myScript.PauseGame(true);

        Assert.IsTrue(myScript.pauseScreen.activeSelf);
        Debug.Log("Screen is paused");

        myScript.PauseGame(false);
        Assert.IsFalse(myScript.pauseScreen.activeSelf);
        Debug.Log("Screen is unPaused");

    }

}

