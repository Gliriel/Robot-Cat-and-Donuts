using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class onKey : MonoBehaviour
{
    public float speed = 4f;
    Im_Master _inputs;
    GameObject PEA;
    private GameObject PEB;
    private void Awake()
    {
        _inputs = new Im_Master();
        PEA = GameObject.Find("ParticleEffectA");
        PEB = GameObject.Find("ParticleEffectB");
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
        switch (x)
        {
            case 1:
                PEB.SetActive(true);
                break;
            case -1:
                PEA.SetActive(true);
                break;
            case 0:
                PEA.SetActive(false);
                PEB.SetActive(false);
                break;

        }
    }
}
