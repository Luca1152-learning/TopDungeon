using UnityEngine;
using UnityEngine.UI;

public class FloatingText
{
    public GameObject gameObject;

    private Text text;

    public bool isActive;

    public Vector3 motion;
    public float duration;

    public float lastShown;

    public void Show()
    {
        isActive = true;
        gameObject.SetActive(isActive);

        lastShown = Time.time;
    }

    public void Hide()
    {
        isActive = false;
        gameObject.SetActive(isActive);
    }

    public void UpdateFloatingText()
    {
        if (!isActive)
        {
            return;
        }

        if (Time.time - lastShown > duration)
        {
            Hide();
        }

        gameObject.transform.position += motion * Time.deltaTime;
    }
}