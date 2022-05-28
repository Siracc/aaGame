using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{

    [SerializeField] float _speed;
    [SerializeField] int _childCount = 0, _level;
    [SerializeField] Text _levelText, _seviyeText;
    [SerializeField] GameObject _spawner, _background;
    GameObject[] _child;
    int _seviye, _save;
    

    private void Start()
    {
        _levelText.text = "1";
        _level = int.Parse(_levelText.text);
        _seviye = int.Parse(_seviyeText.text);
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(0, 0, _speed * Time.deltaTime);
        DestroyChild();
    }
   


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SmallCircle"))
        {
            _childCount++;
        }
    }
    IEnumerator OpenWin()
    {
        _background.GetComponent<SpriteRenderer>().color = Color.green;
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene(3);        
    }
    IEnumerator NextLevel()
    {
        _background.GetComponent<SpriteRenderer>().color = Color.green;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }



    void DestroyChild()
    {
        if (_seviye == 2)
        {
            _save = 2;
            PlayerPrefs.SetInt("Save", _save);
            if (_childCount == 10 && int.Parse(_levelText.text) == 10)
            {
                
                _spawner.GetComponent<SpawnSmallCircle>().enabled = false;
                GetComponent<Rotate>().enabled = false;
                StartCoroutine(OpenWin());
            }

        else if (_childCount == int.Parse(_levelText.text))
            {
                _childCount = 0;
                _level++;
                _levelText.text = _level.ToString();
                _speed += 0.3f;

                for (int i = 0; i <= 50; i++)
                {
                    _child = GameObject.FindGameObjectsWithTag("SmallCircle");
                    Destroy(_child[i]);
                }
            }
        }

        else if (_seviye == 1)
        {
            _save = 1;
            PlayerPrefs.SetInt("Save", _save);
            if (_childCount == 10 && int.Parse(_levelText.text) == 10)
            {
                
                Time.timeScale = 0;
                _seviye = 2;
                PlayerPrefs.SetInt("Seviye", _seviye);
                StartCoroutine(NextLevel());
                Time.timeScale = 1;


            }
          else  if (_childCount == int.Parse(_levelText.text) && int.Parse(_levelText.text) <= 9)
            {
                _childCount = 0;
                _level++;
                _levelText.text = _level.ToString();
                _speed += 0.3f;

                for (int i = 0; i <= 50; i++)
                {
                    _child = GameObject.FindGameObjectsWithTag("SmallCircle");
                    Destroy(_child[i]);
                }
            }
        }
    }
}

