using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Takip edilecek top
    private Vector3 offset; // Top ve kamera arasındaki mesafe

    void Start()
    {
        // Top ve kamera arasındaki başlangıç mesafesini hesapla
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Kameranın pozisyonunu, topun pozisyonu + mesafe olarak güncelle
        transform.position = player.transform.position + offset;
    }
}