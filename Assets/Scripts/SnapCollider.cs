using UnityEngine;

public class SnapCollider : MonoBehaviour
{
    // Bu sýnýf sadece collider iþaretlemesi için kullanýlýr.
    // Collider'ýn trigger olarak ayarlandýðýndan emin olun.
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, GetComponent<Collider>().bounds.size);
    }
}
