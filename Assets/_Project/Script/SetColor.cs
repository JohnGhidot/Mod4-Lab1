using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(BoxCollider))]
public class SetColor : MonoBehaviour
{
    private Material _material;
    private Color _default;
    private static ColorManager _colorManager;

    void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
        _default = _material.color;
    }

    void OnMouseDown()
    {
        _material.color = _colorManager.ColorSelect;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _material.SetColor("_BaseColor", _default);
        }
    }

    public void SetColorManager(ColorManager colorManager)
    {
        _colorManager = colorManager;
    }
}
