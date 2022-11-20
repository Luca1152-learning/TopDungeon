using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
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

    public void LoadState()
    {
        Debug.Log("Load state");
    }
}