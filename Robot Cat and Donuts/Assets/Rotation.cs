using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
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
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = _inputs.main.main_button.ReadValue<float>();
        transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }
}
