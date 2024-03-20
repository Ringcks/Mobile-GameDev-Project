using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiSpaceship : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + new Vector2 (1f, 0f) * Time.deltaTime);
    }
}
