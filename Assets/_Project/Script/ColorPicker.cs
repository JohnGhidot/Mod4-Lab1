using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorPicker : MonoBehaviour
{
    [SerializeField] private ColorManager _colorManager;
    private Color _color;

    void Awake()
    {
        _color = GetComponent<MeshRenderer>().material.color;
    }

    void OnMouseDown()
    {
        _colorManager.ColorSelect = _color;
    }
}
