using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.position += Vector3.forward * _moveSpeed * Time.deltaTime;
    }
}
