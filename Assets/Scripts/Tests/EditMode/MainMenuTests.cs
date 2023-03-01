using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class MainMenuTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void playButtonWorks()
    {


        //Test the scene we are in

        //Start scene
        EditorSceneManager.OpenScene("Assets/Scenes/Start_game_menu.unity");

        Debug.Log(SceneManager.GetActiveScene().name);

        //Scene should switch to the game
        EditorSceneManager.OpenScene("Assets/Scenes/FirstGame.unity");

        Debug.Log(SceneManager.GetActiveScene().name);

        Assert.AreEqual("FirstGame", SceneManager.GetActiveScene().name);
        Debug.Log("Switches to the game");
    }


}
