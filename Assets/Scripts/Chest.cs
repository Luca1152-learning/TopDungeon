using UnityEngine;

public class Chest : Collectable
{
    protected override void OnCollect()
    {
        base.OnCollect();
        Debug.Log("Grant pesos!");
    }
}