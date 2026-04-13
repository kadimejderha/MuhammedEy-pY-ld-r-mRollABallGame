using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10.0f;

    private int count;

    public TextMeshProUGUI countText;
    // 1. ADIM: "Kazandın" yazısını tutacak objeyi tanımladık
    public GameObject winTextObject;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();

        // 2. ADIM: Oyun başladığında "Kazandın" yazısını gizliyoruz
        winTextObject.SetActive(false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        // 3. ADIM: Eğer puanın 12 veya üzerindeyse kazandın yazısını göster!
        // (Sahnende kaç tane küp varsa 12 yerine o sayıyı yazabilirsin)
        if (count >= 14)
        {
            winTextObject.SetActive(true);
        }
    }
}