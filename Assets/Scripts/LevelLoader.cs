using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader
{
    /// <summary>
    /// Reloads current scene.
    /// </summary>
    public static void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// Loads a specific scene
    /// </summary>
    /// <param name="index">Scene's build index</param>
    public static void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    /// <summary>
    /// Loads a specific scene
    /// </summary>
    /// <param name="index">Scene's build index</param>
    public static void LoadLevel(string index)
    {
        SceneManager.LoadScene(index);
    }
}
