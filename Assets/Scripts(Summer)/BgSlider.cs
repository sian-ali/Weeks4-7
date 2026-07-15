using UnityEngine;
using UnityEngine.InputSystem;

public class BgSlider : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnSliderMove(float theBg)
    {
     spriteRenderer.color = color;
    }
}
