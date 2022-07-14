using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResetGame : MonoBehaviour
{

    private void Update()
    {
        var keyboard = Keyboard.current;
        // Quick and dirty one-liner to reload the scene (eg use at the end of the battle)
        if (keyboard.escapeKey.wasPressedThisFrame)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }
}
