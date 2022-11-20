using UnityEngine;

public class Chest : Collidable
{
    protected override void OnCollide(Collider2D collider)
    {
        Debug.Log("Grant pesos!");
    }
}