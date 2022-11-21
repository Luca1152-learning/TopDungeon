using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextManager : MonoBehaviour
{
    public GameObject textContainer;
    public GameObject textPrefab;

    private List<FloatingText> floatingTexts = new();

    private FloatingText GetFloatingText()
    {
        var floatingText = floatingTexts.Find(t => !t.isActive);

        if (floatingText == null)
        {
            floatingText = new FloatingText
            {
                gameObject = Instantiate(textPrefab, textContainer.transform, true),
                text = gameObject.GetComponent<Text>()
            };

            floatingTexts.Add(floatingText);
        }

        return floatingText;
    }

    public void Update()
    {
        foreach (var floatingText in floatingTexts)
        {
            floatingText.UpdateFloatingText();
        }
    }

    public void Show(string text, Vector3 position, int fontSize, Color color, Vector3 motion, float duration)
    {
        var floatingText = GetFloatingText();

        floatingText.gameObject.transform.position = Camera.main.WorldToScreenPoint(position);

        floatingText.text.text = text;
        floatingText.text.fontSize = fontSize;
        floatingText.text.color = color;


        floatingText.motion = motion;
        floatingText.duration = duration;
        
        floatingText.Show();
    }
}