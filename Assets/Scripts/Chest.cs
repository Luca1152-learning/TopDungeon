using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChestSprite;
    public int coinsAmount = 5;

    protected override void OnCollect()
    {
        base.OnCollect();

        GetComponent<SpriteRenderer>().sprite = emptyChestSprite;
        GameManager.instance.ShowText(
            "+" + coinsAmount + " coins!", transform.position, 25, Color.yellow,
            Vector3.up * 25, 1f
        );
    }
}