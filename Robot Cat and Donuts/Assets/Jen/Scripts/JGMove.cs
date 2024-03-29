using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class JGMove : MonoBehaviour
{
    public float speed = 4f;
    public Im_Master _im_Master;
    public Rigidbody2D _rbody;
    public Vector2 _moveInput;
    public bool facingRight = true;
    public WinLose winLose;
    public PlayRandomSound _playSound;

    private void Awake()
    {
        _im_Master = new Im_Master();
        _rbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _im_Master.Jen.Enable();
    }

    private void Update()
    {
        _moveInput = _im_Master.Jen.Movement.ReadValue<Vector2>();
        _moveInput.y = 0f;
        _rbody.velocity = _moveInput * speed;  
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            _playSound.PlayRandomSoundBite();
            winLose.win = false;
        }
       
    }

    private void FixedUpdate()
    {

        if (_moveInput.x > 0 && !facingRight)
        {
            Flip();
        }
        if (_moveInput.x < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }


}
