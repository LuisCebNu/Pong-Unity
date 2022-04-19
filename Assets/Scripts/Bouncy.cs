using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceStrength;
    public AudioSource _hit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
            _hit.Play();
        }
        
    }
}
