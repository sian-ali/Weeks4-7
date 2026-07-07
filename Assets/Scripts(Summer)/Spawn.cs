using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    public GameObject dodgeballPrefab;
    public Vector3 spawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //spawn a runner
            Instantiate(dodgeballPrefab);

            //spawn a runner that is a child of this object
            //Instantiate(dodgeballPrefab, transform);

            //spawn a runner at a specific position
            Instantiate(dodgeballPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
