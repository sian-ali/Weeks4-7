using UnityEngine;
using UnityEngine.Events;

public class Laser : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;

    public UnityEvent onSmall;
    public UnityEvent onMedium;
    public UnityEvent onLarge;

    public float health;

    bool small = false;
    bool medium = false;
    bool large = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Contains(transform.position))
        {
            onSmall.Invoke();
            small = true;
        }
    }
    public void SmallDamage()
    {
        health -= -1;
    }
    public void MediumDamage()
    {
        health -= -5;
    }
    public void LargeDamage()
    {
        health -= -15;
    }
}
