using UnityEngine;

public class KickAttack : MonoBehaviour
{
    [SerializeField] public float _lifetime = 0.1f;
    [SerializeField] private Vector3 _kickAmount = Vector3.up;
    private float _timer;

    // Add a member variable to represent the timer.

    // ------------------------------------------------------------------------
    private void OnEnable()
    {
        _timer = _lifetime;
    }

    // ------------------------------------------------------------------------
    // Use a built-in Unity method that runs every frame...
    // Disable this GameObject when time runs out
    private void Update()
    {
        _timer -= Time.deltaTime;
    }

    // ------------------------------------------------------------------------
    // Use a built-in Unity collision detection method...
    // Check if the colliding object has a Kickable component-
    //      if so, Kick it!
}