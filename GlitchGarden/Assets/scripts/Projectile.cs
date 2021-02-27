using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float Speed = 1f;
    [SerializeField] float damage = 50f;
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D OtherCollider)
    {
        var health = OtherCollider.GetComponent<Health>();
        var attacker = OtherCollider.GetComponent<Attacker>();

        if(attacker && health)
        {
            Destroy(gameObject);
            health.DealDamage(damage);

        }
    }
}
