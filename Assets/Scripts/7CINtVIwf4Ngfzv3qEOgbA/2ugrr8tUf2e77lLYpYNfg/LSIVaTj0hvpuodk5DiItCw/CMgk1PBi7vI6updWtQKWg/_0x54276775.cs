using TMPro;
using UnityEngine;
using static _0x1fc44a94;

public class _0x54276775 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x07803faf()
    {
        this.MoneyCountText.text = _0x9d1bd943._0x9c696c79.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xe2d63a4e;
            if (this.gameObject.TryGetComponent(out _0xe2d63a4e))
                this.MoneyCountText = _0xe2d63a4e;
        }

        this._0x07803faf();
    }
}