using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spos : MonoBehaviour
{
    public GameObject kuaniprefab;
    public Transform kuaniposition;
    public float throwforce = 10f;
    public float nextfire = 0.5f;

    void Update()
    {
         if(Input.GetKeyDown(KeyCode.E) && Time.time > nextfire)
        {
            nextfire = Time.time + nextfire;
            Throw();
        }
    }

    void Throw()
    {
        GameObject kuanigo = Instantiate(kuaniprefab, kuaniposition.position, kuaniposition.rotation);
        Rigidbody2D rb = kuanigo.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * throwforce;
    }
}
