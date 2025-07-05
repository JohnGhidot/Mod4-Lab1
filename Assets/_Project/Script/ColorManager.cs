using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorManager : MonoBehaviour
{
    private Color _colorSelect = Color.white;
    public Color ColorSelect
    {
        get => _colorSelect;
        set
        {
            _colorSelect = value;
            _meshRenderer.material.color = value;
        }
    }
    private MeshRenderer _meshRenderer;

    void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material.color = ColorSelect;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ColorSelect = Color.white;
        }
    }
}
