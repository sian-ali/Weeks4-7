using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SunButton : MonoBehaviour
{
    public Vector3 startValue;
    public Vector3 endValue;
    public Vector3 currentValue;

    public float duration;
    float progress = 0f;

    public AnimationCurve yPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress(float theSun)
    {
        progress += Time.deltaTime;
        currentValue = Vector3.Lerp(startValue, endValue, progress / duration);
        transform.position = currentValue;
    }
}

