using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmallCircle : MonoBehaviour
{
    [SerializeField] GameObject _smallCircle;
    [SerializeField] Transform _spawnTransform;

    // Start is called before the first frame update


    private void Update()
    {
        Spawner();
    }


  
    void Spawner()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_smallCircle, _spawnTransform.position, _spawnTransform.rotation);
        }
        
    }
}
