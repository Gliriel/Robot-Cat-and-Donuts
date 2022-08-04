using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject prefab;
    public Battery _battery;
    public GameObject littlePlanet;
    public float angle = 25;
    public float speed = 4;
    public int _randomScene;
    public bool canRotate = false;

    private void Awake()
    {
        if (!GameObject.FindGameObjectWithTag("Batt"))
        {
            GameObject newBattery = Instantiate(prefab);
            newBattery.name = prefab.name;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Battery");
        _battery = go.GetComponent<Battery>();
        if (_battery.gamesPlayed <= 5)
        {
            littlePlanet.transform.localRotation = Quaternion.Euler(0, 0, (angle * ((_battery.gamesPlayed - 1) * 2)));
            
        }
        else
        {
            littlePlanet.transform.localRotation = Quaternion.Euler(0, 0, 250);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        _randomScene = Random.Range(3, SceneManager.sceneCountInBuildSettings);
        SceneChanges();
        if (canRotate == true)
        {
            littlePlanet.transform.Rotate(Vector3.forward * speed);
        }
    }

    void SceneChanges()
    {
        if (_battery.gamesPlayed <= 5)
        {
            StartCoroutine(RandomSceneChange());
            
        }
        else if (_battery.gamesPlayed >= 6)
        {
            StartCoroutine(EndGameChange());
        }
    }

    
    
    public void LoadRandomScene()
    {
        
        SceneManager.LoadScene(_randomScene); //_randomScene
    }
    

    public IEnumerator RandomSceneChange()
    {
        canRotate = true;
        yield return new WaitForSecondsRealtime(2);
        canRotate = false;
        LoadRandomScene();
    }

    public IEnumerator EndGameChange()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(2);
    }
}
