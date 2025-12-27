using UnityEngine;

public class Increase : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    void Update()
    {
        transform.localScale += new Vector3(_increaseSpeed, _increaseSpeed, _increaseSpeed);
    }
}
