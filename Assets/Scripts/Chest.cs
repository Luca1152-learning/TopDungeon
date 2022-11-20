using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChestSprite;
    public int coinsAmount = 5;

    protected override void OnCollect()
    {
        base.OnCollect();

        GetComponent<SpriteRenderer>().sprite = emptyChestSprite;
        Debug.Log("Granted " + coinsAmount + " coins!");
    }
}