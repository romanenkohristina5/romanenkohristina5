using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x20bb9bef : MonoBehaviour
{
    private TMP_Text _0xda15a604;
    private void Update()
    {
        this._0x25fb1fcd();
    }

    private void _0x25fb1fcd()
    {
        if (this._0x7f3b214e.canvasRenderer.GetColor() != this._0xda15a604.canvasRenderer.GetColor())
            this._0xda15a604.canvasRenderer.SetColor(this._0x7f3b214e.canvasRenderer.GetColor());
    }

    private Image _0x7f3b214e;
}