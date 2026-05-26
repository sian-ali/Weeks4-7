using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
public class ColourChanger : MonoBehaviour
{
    public SpriteRenderer ball;
    public Vector3 startValue;
    public Vector3 endValue;
    public Vector3 currentValue;
    public float duration;
    public float progress;
    public List<SpriteRenderer> balls;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        currentValue = Vector3.Lerp(startValue, endValue, progress / duration);
        transform.position = currentValue;
        if (progress > duration)
        {
            ball.color = Random.ColorHSV();
            progress = 0f;
        }
        bool isPressed = Keyboard.current.anyKey.isPressed;
    }
}

