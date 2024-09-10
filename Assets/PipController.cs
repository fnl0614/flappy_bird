using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipController : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,15);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
