using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        yield return new WaitForSecondsRealtime(1);
        Text1.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(1.5f);
        Text2.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(1.5f);
        Text3.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(1.5f);
        Text4.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(1.5f);
        Text5.enabled = true;
        Meow.Play();
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(2);
    }
}
