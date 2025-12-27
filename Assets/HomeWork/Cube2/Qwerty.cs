using UnityEngine;

public class Qwerty : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _increaseSpeed;
    [SerializeField] private float _rotateSpeed;

    void Update()
    {
        var speedRotate = new Vector3(0, _rotateSpeed * Time.deltaTime, 0);

        var speedIncrease = _increaseSpeed * Time.deltaTime;

        transform.position += transform.forward * _moveSpeed * Time.deltaTime;

        transform.Rotate(new Vector3(0, speedRotate.y, 0));

        transform.localScale += new Vector3(speedIncrease, speedIncrease, speedIncrease);
    }
}
