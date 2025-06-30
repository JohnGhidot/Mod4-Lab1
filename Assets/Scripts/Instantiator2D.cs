using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] private GameObject _quadPrefab;
    [SerializeField] private int _column = 6;
    [SerializeField] private int _row = 6;
    [SerializeField] private float _offsetCol = 1.5f;
    [SerializeField] private float _offsetRow = 1.5f;
    [SerializeField] private Transform _parentTransform;

    // Start is called before the first frame update
    void Start()
    {
        Instantiatior();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Instantiatior()
    {
        for (int y = 0; y < _row; y++)
        {
            for (int x = 0; x < _column; x++)
            {
                Vector3 pos = new Vector3(x * _offsetCol, -y * _offsetRow, 0f);
                Instantiate(_quadPrefab, pos, Quaternion.identity, this.transform);
            }
        }
    }
}
