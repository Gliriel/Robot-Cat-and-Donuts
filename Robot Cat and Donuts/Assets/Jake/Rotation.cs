using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 100f;
    private Im_Master _inputs;
    

    private void Awake()
    {
        _inputs = new Im_Master();
    }

    private void OnEnable()
    {
        _inputs.main.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float x = _inputs.main.main_button.ReadValue<float>();
        transform.Rotate(new Vector3(0,0,-x) * speed * Time.deltaTime );
    }
}
