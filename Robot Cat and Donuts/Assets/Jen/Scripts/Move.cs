using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed = 4f;
    Im_Master _input;


    private void Awake()
    {
        _input = new Im_Master();
    }

    void Start()
    {
        
    }
    void Enable()
    {
        _input.main.Enable();
    }
    void Update()
    {
        float x = _input.main.main_button.ReadValue<float>();

        Debug.Log(_input.main.main_button.ReadValue<float>());

        transform.position += new Vector3(x * speed * Time.deltaTime, 0, 0);
        
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
