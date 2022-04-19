using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    public float BSpeed = 200;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }

    private void Start()
    {
        ResetPosition();
        AddStartingFoce();
    }

    public void AddStartingFoce()
    {
        float x = Random.value < 0.5f ? -1 : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f,-0.5f): Random.Range(0.5f,1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.BSpeed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }


}
