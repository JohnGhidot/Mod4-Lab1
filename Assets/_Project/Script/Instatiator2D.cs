using System.Collections.Generic;
using UnityEngine;

public class Instatiator2D : MonoBehaviour
{
    [SerializeField] private int _colonne = 10;
    [SerializeField] private int _righe = 10;
    [SerializeField] private Vector2 _unitScalaPrefab = Vector2.one;
    [SerializeField] private float _offsetX = 0.1f;
    [SerializeField] private float _offsetZ = 0.1f;

    [SerializeField] private SetColor _prefab;
    private List<SetColor> _colorList = new List<SetColor>();
    [SerializeField] private ColorManager _colorManager;

    private void InstantiatorStart()
    {
        float offsetXcenter = ((_colonne - 1) * _unitScalaPrefab.x + _offsetX * (_colonne - 1)) / -2f;
        float offsetZcenter = ((_righe - 1) * _unitScalaPrefab.y + _offsetZ * (_righe - 1)) / -2f;

        for (int i = 0; i < _colonne; i++)
        {
            for (int j = 0; j < _righe; j++)
            {
                float x = i * _unitScalaPrefab.x + _offsetX * i + offsetXcenter;
                float z = j * _unitScalaPrefab.y + _offsetZ * j + offsetZcenter;
                Vector3 position = new Vector3(x, 0f, z);
                SetColor setColor = Instantiate(_prefab, position, _prefab.transform.rotation, transform);
                _colorList.Add(setColor);
            }
        }

        _colorList[0].SetColorManager( _colorManager );
    }

    void Start()
    {
        InstantiatorStart();
    }
}
