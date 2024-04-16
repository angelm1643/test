using UnityEngine;

namespace course.PatronesDiseno.Strategy
{
    [RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public class Arrow : MonoBehaviour
    {
        private int _damage = 10;
        private float _speed = 5;

        private void Awake()
        {
            GetComponent<Rigidbody2D>().velocity = transform.right* _speed;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            IDamage otherDamage = collision.GetComponent<IDamage>();
            otherDamage?.DoDamage(_damage);
            Destroy(this);
        }
    }
}
