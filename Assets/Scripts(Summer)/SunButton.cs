using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SunButton : MonoBehaviour
{
    public float speed;
    public float xMax;
    public float xMin;
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
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}

