using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x6245e686 : MonoBehaviour
{
    private AspectRatioFitter _0x2d927ec5;
    private float _0x31ed07dc = 0.6f;
    private float _0x64615337 = 4;
    private float _0x6176d8ee = 1.5f;
    private float _0xd1e3cff5;
    private TMP_Text _0xdbede35f;
    private void Update()
    {
        int _0x4cf5e06d = 1;
        if (this._0x9b78a35b.Count > 0)
        {
            string _0xce1991e9 = this._0xdbede35f.text;
            foreach (string _0x20ac3002 in this._0x9b78a35b)
                while (_0xce1991e9.Contains(_0x20ac3002))
                    _0xce1991e9 = _0xce1991e9.Replace(_0x20ac3002, "");
            _0x4cf5e06d = _0xce1991e9.Length;
        }
        else
        {
            _0x4cf5e06d = this._0xdbede35f.text.Length;
        }

        float _0x2ebfb556 = Mathf.Clamp(this._0xd1e3cff5 + this._0x31ed07dc * _0x4cf5e06d, this._0x6176d8ee, this._0x64615337);
        if (!Mathf.Approximately(this._0x2d927ec5.aspectRatio, _0x2ebfb556))
            this._0x2d927ec5.aspectRatio = _0x2ebfb556;
    }

    private List<string> _0x9b78a35b = new();
}