using UnityEngine;

public class SnapCollider : MonoBehaviour
{
    // Bu s�n�f sadece collider i�aretlemesi i�in kullan�l�r.
    // Collider'�n trigger olarak ayarland���ndan emin olun.
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, GetComponent<Collider>().bounds.size);
    }
}
