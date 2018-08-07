using UnityEngine;
using System.Collections;

/// <summary>
/// 颜色拾取器控制脚本
/// </summary>
public class ColorPickerManager : MonoBehaviour 
{

    public new Renderer renderer;
    public ColorPicker picker;

    public Color Color = Color.red;

	void Start () 
    {
        picker.onValueChanged.AddListener(color =>
        {
            renderer.material.color = color;
            Color = color;
        });

		renderer.material.color = picker.CurrentColor;

        picker.CurrentColor = Color;
    }
}
