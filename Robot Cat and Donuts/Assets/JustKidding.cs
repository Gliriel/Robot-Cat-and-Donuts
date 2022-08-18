using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class JustKidding : MonoBehaviour
{
    public TextTypewriter _story;
    public TextMeshProUGUI _storyText;
    public TextMeshProUGUI _justKidding;
    public float _time = 5f;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    public TextMeshProUGUI Text4;
    public TextMeshProUGUI Text5;
    public AudioSource Meow;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(JK());
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard.dKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(2);
        }
    }

    public IEnumerator JK()
    {
        yield return new WaitForSecondsRealtime(_time);
        _story.timeBtwChars = 10000f;
        _justKidding.enabled = true;
        yield return new WaitForSecondsRealtime(1);
        StartCoroutine(TheRealText());
    }

    public IEnumerator TheRealText()
    {
        _storyText.enabled = false;
        _justKidding.enabled = false;
        yield return new WaitForSecondsRealtime(0.5f);
        Text1.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(0.8f);
        Text2.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(0.8f);
        Text3.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(0.8f);
        Text4.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(0.8f);
        Text5.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(2);
    }
}
