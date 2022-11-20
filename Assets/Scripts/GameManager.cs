using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        // Make sure we don't end up with more GameManagers in your "Dont destroy on load" scene (in case
        // we would reload the Main scene, for example)
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    // Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> expTable;

    // References
    public Player player;
    // public Weapon weapon;
    // ...

    // Logic
    public int numCoins;
    public int experience;

    // Save state
    public void SaveState()
    {
        Debug.Log("Save state");
    }

    public void LoadState(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Load state");
    }
}