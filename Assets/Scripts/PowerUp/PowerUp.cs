using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Once the tag "Player" hits object its deleted
        if (collision.tag == "Player")
        {
            powerupEffect.Apply(collision.gameObject);
            Destroy(gameObject);
            ScoreManager.Instance.AddPoint();
        }
       
    }
}
