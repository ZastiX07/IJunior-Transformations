using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    void Update()
    {
        var rotate = new Vector3 (0, _rotateSpeed , 0);

        transform.Rotate(rotate);
    }
}
