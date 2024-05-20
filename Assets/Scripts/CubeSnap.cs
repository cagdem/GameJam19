using UnityEngine;

public class CubeSnap : MonoBehaviour
{
    public float snapDistance = 10f; // Snaplenme mesafesi
    private bool isSnapped = false; // Snaplenip snaplenmedi�ini kontrol etmek i�in
    public Rigidbody Rigidbody;

    void Update()
    {            
        CheckForSnap();
    }

    void CheckForSnap()
    {
        // T�m SnapCollider'lar� bul
        SnapCollider[] snapColliders = FindObjectsByType<SnapCollider>(FindObjectsSortMode.None);

        foreach (SnapCollider snapCollider in snapColliders)
        {
            // SnapCollider ile mesafeyi kontrol et
            float distance = Vector3.Distance(transform.position, snapCollider.transform.position);
            if (distance <= snapDistance)
            {
                Rigidbody.isKinematic = true;
                SnapToObject(snapCollider.transform);
                break;
            }
        }
    }

    void SnapToObject(Transform snapTarget)
    {
        // K�p� collider'�n pozisyonuna snaple
        transform.position = snapTarget.position;
        transform.rotation = snapTarget.rotation; // �ste�e ba�l� olarak rotasyonu da snapleyebilirsiniz
        isSnapped = true; // Bir kez snaplendikten sonra tekrar snaplenmemesi i�in
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, snapDistance);
    }
}
