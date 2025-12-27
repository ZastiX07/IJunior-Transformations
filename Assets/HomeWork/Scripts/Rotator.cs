using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        var rotate = new Vector3 (0, _rotateSpeed , 0);

        transform.Rotate(rotate);
    }
}
