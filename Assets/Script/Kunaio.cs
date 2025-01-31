using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunaio : MonoBehaviour
{
    public float speeed = 5f;

    void Start()
    {
        transform.eulerAngles = new Vector3(0f, 0f, 180);
        Destroy(gameObject, 2f);
    }
    void upadate()
    {
        transform.Translate(Vector2.right * speeed * Time.deltaTime);
    }
}
