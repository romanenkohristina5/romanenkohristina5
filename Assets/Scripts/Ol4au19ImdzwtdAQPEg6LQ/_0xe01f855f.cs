using DG.Tweening;
using UnityEngine;

// How far up the shaft the car has got, as a column of segments down the left gutter.
// Rule C.25: the gutter owns an x-band of its own - the shaft is only 0.80 of the
// screen width precisely so this column never sits under the play field.
public sealed class _0xe01f855f : MonoBehaviour
{
    private SpriteRenderer[] _0xdc8a73dc;
    public void _0x2eebea1b(int _0xe34c5dd8)
    {
        if (this._0xdc8a73dc == null)
        {
            return;
        }

        int _0x936fa10e = Mathf.Clamp(_0xe34c5dd8, 0, this._0xdc8a73dc.Length);
        for (int _0x33275993 = this._0x0fad14f4; _0x33275993 < _0x936fa10e; _0x33275993++)
        {
            SpriteRenderer _0xb255dc61 = this._0xdc8a73dc[_0x33275993];
            if (_0xb255dc61 == null)
            {
                continue;
            }

            DOTween.Kill(_0xb255dc61, true);
            _0xb255dc61.DOColor(_0x821966c0.Reward, 0.2f).SetTarget(_0xb255dc61);
        }

        this._0x0fad14f4 = _0x936fa10e;
    }

    private _0x38c6998c _0xf1b27476;
    public void _0xcdf70de3(_0x18132870 _0x08b08b7e, _0x38c6998c _0xc02e601a, int _0xbcf6f013)
    {
        this._0xf1b27476 = _0xc02e601a;
        int _0x36f1112e = Mathf.Max(1, _0xbcf6f013);
        this._0xdc8a73dc = new SpriteRenderer[_0x36f1112e];
        float _0xfc3e764c = _0xc02e601a._0xc9d36fe0;
        float _0x3de1c226 = _0xc02e601a._0x0b249945;
        float _0x7f6e91e9 = _0x36f1112e > 1 ? (_0x3de1c226 - _0xfc3e764c) / (_0x36f1112e - 1) : 0f;
        Vector2 _0x116c5f54 = _0xc02e601a._0xa965e0d3;
        if (_0x36f1112e > 1)
        {
            _0x116c5f54 = new Vector2(_0x116c5f54.x, Mathf.Min(_0x116c5f54.y, _0x7f6e91e9 * 0.62f));
        }

        for (int _0x8f737eed = 0; _0x8f737eed < _0x36f1112e; _0x8f737eed++)
        {
            this._0xdc8a73dc[_0x8f737eed] = _0x4051eae7.Spawn(_0x08b08b7e._0x2f74c22e, this.transform, new Vector3(_0xc02e601a._0xfd2af970, _0xfc3e764c + _0x7f6e91e9 * _0x8f737eed, 0f), _0x116c5f54, _0x38c6998c.AltimeterOrder, _0x821966c0.Alpha(_0x821966c0.Primary, 0.35f));
        }
    }

    private int _0x0fad14f4;
    public float _0xd7c074b6
    {
        get
        {
            return this._0xf1b27476 != null ? this._0xf1b27476._0x0b249945 : 0f;
        }
    }
}