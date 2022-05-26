using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed;
    public TextMeshPro countText;
    
    private int count;
    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")){
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }

    void SetCountText() {
        countText.text = "Puntos (10): " + count.ToString();

        if (count >= 10){
            countText.text = "Encontraste los 10 objetos ;)" + count.ToString();
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }
}
