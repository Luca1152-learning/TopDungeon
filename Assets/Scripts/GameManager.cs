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
    public FloatingTextManager floatingTextManager;

    // Logic
    public int numCoins;
    public int experience;

    public void ShowText(string text, Vector3 position, int fontSize, Color color, Vector3 motion, float duration)
    {
        floatingTextManager.Show(text, position, fontSize, color, motion, duration);
    }

    // Save state
    /*
     * int preferredSkin
     * int numCoins
     * int experience
     * int weaponLevel
     */
    public void SaveState()
    {
        var s = "";

        s += "0" + "|";
        s += numCoins + "|";
        s += experience + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene scene, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
        {
            return;
        }

        string[] data = PlayerPrefs.GetString("SaveState").Split("|");

        // TODO - change player skin
        numCoins = int.Parse(data[1]);
        experience = int.Parse(data[1]);
        // TODO - change the weapon level

        Debug.Log("Load state");
    }
}