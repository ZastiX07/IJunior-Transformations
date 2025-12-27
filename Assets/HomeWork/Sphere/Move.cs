using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        transform.position += Vector3.forward * _moveSpeed * Time.deltaTime;
    }
}
