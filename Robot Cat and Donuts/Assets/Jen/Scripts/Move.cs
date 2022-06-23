using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 4f;
    Im_Master _inputs;

    private void Awake()
    {
        _inputs = new Im_Master();
    }

    private void OnEnable()
    {
        _inputs.main.Enable();
    }
    void Start()
    {
        
    }

    void Update()
    {
        float x = _inputs.main.main_button.ReadValue<float>();
        transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
