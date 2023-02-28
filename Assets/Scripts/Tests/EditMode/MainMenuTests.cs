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
        var gameObject = GameObject.Find("MenuCanvas/MenuPanel/PlayButton");
        var playBtn = gameObject.GetComponent<Button>();

        Assert.NotNull(playBtn, "Play button is not found on scene");
        Debug.Log(playBtn.name +" Located on the scene");
    }

    

}
