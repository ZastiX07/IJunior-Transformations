using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_increaseSpeed, _increaseSpeed, _increaseSpeed);
    }
}
