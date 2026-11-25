using UnityEngine;

// Write a timer that destroys the gameobject it's attached to when time is up.
// Use this to remove your explosion VFX when they're done playing.
public class TimedDestroy : MonoBehaviour
{
    [SerializeField] private float _killTime = 1.0f;
    private float _killTimer;

    private void Start()
    {
        _killTimer = _killTime;
    }

    private void Update()
    {
        _killTimer -= Time.deltaTime;
        if (_killTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
