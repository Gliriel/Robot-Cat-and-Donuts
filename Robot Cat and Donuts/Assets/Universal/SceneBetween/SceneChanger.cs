using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public Battery _battery;
    public NumberList _listOfGames;
    public GameObject littlePlanet;
    public float angle = 12f;
    public float speed = 4;
    public int _randomScene;
    public bool canRotate = false;
    public bool newNumber;
    public TextMeshProUGUI distance;

    private void Awake()
    {
        if (!GameObject.FindGameObjectWithTag("Batt"))
        {
            GameObject newBattery = Instantiate(prefab1);
            newBattery.name = prefab1.name;
        }
        if (!GameObject.FindGameObjectWithTag("List"))
        {
            GameObject newList = Instantiate(prefab2);
            newList.name = prefab2.name;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Battery");
        _battery = go.GetComponent<Battery>();
        GameObject go2 = GameObject.Find("ListOfGames");
        _listOfGames = go2.GetComponent<NumberList>();
        if (_battery.gamesPlayed <= 7)
        {
            littlePlanet.transform.localRotation = Quaternion.Euler(0, 0, (angle * ((_battery.gamesPlayed - 1) * 2)));
            
        }
        else
        {
            littlePlanet.transform.localRotation = Quaternion.Euler(0, 0, 250);
        }
        newNumber = false;
        float pow = Mathf.Pow((8 - _battery.gamesPlayed), (8 - _battery.gamesPlayed));
        distance.text = new string(pow + " metres to the DONUT!");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (newNumber == false)
        {
            newNumber = true;
            GetRandomNumber();
            
        }
        else if (canRotate == true)
        {
            littlePlanet.transform.Rotate(Vector3.forward * speed);
        }
        else
        {
            return;
        }
    }

    void GetRandomNumber()
    {
        _randomScene = Random.Range(4, SceneManager.sceneCountInBuildSettings);
        if (_listOfGames.PlayedNumbers.Contains(_randomScene))
        {
            newNumber = false;
            return;
        }
        else
        {

            SceneChanges();
            
        }
    }

    void SceneChanges()
    {
        if (_battery.gamesPlayed <= 7)
        {
            StartCoroutine(RandomSceneChange());
            
        }
        else if (_battery.gamesPlayed >= 8)
        {
            StartCoroutine(EndGameChange());
        }
    }

    
    
    public void LoadRandomScene()
    {
        _listOfGames.PlayedNumbers.Add(_randomScene);
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
        SceneManager.LoadScene(3);
    }
}
