using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

// This game has NO audio of any kind, so the beat has to be something you SEE. Three
// layers carry it: the deck ring opening on every beat, a floor marker sliding past
// every fourth beat, and the approach distance itself - notes travel a fixed 1.6 s, so
// the gap between two of them on screen IS the gap between two of them in time.
public sealed class _0xb321530e : MonoBehaviour
{
    private _0x18132870 _0xc0bb1e10;
    // A floor change gets a brighter marker so the climb is legible without reading the HUD.
    public void _0x4097f841()
    {
        if (this._0x63c40e0f.Count == 0)
        {
            return;
        }

        SpriteRenderer _0x88317ff1 = this._0x63c40e0f[this._0x63c40e0f.Count - 1];
        if (_0x88317ff1 == null)
        {
            return;
        }

        DOTween.Kill(_0x88317ff1, true);
        _0x88317ff1.color = _0x821966c0.Reward;
        _0x88317ff1.DOColor(_0x821966c0.Alpha(_0x821966c0.Secondary, 0.55f), 0.3f).SetTarget(_0x88317ff1);
    }

    private readonly List<SpriteRenderer> _0x63c40e0f = new List<SpriteRenderer>();
    private float _0xdaa1e8a9 = 0.5f;
    private _0x38c6998c _0x908c5eb5;
    public void _0x4954069c(float _0xe5bfd875)
    {
        int _0xfb129939 = Mathf.FloorToInt(_0xe5bfd875 / this._0xdaa1e8a9);
        while (this._0xdc84373f < _0xfb129939)
        {
            this._0xdc84373f++;
            if (this._0x085e4e3c != null)
            {
                this._0x085e4e3c._0xd23dfe39(this._0xdaa1e8a9);
            }

            if (this._0xdc84373f % 4 == 0)
            {
                this._0x05eeddf6();
            }
        }

        for (int _0x0c24702c = this._0x63c40e0f.Count - 1; _0x0c24702c >= 0; _0x0c24702c--)
        {
            SpriteRenderer _0xc47fbf0a = this._0x63c40e0f[_0x0c24702c];
            if (_0xc47fbf0a == null)
            {
                this._0x63c40e0f.RemoveAt(_0x0c24702c);
                continue;
            }

            Vector3 _0x3b35f9e4 = _0xc47fbf0a.transform.localPosition;
            float _0xbf3e6445 = _0x3b35f9e4.y - this._0x908c5eb5._0x6767802c * 0.35f * Time.deltaTime;
            _0x4051eae7.MoveY(_0xc47fbf0a.transform, _0xbf3e6445);
            if (_0xbf3e6445 < -this._0x908c5eb5._0xb00f69b4 * 1.1f)
            {
                this._0x63c40e0f.RemoveAt(_0x0c24702c);
                Destroy(_0xc47fbf0a.gameObject);
            }
        }
    }

    private int _0xdc84373f;
    public void _0x2f7dbe6a(_0x18132870 _0x053a38f6, _0x38c6998c _0x00d2f6a6, _0xa9e6f5e6 _0x72d701f1, float _0x28b8dde4)
    {
        this._0xc0bb1e10 = _0x053a38f6;
        this._0x908c5eb5 = _0x00d2f6a6;
        this._0x085e4e3c = _0x72d701f1;
        this._0xdaa1e8a9 = Mathf.Max(0.12f, _0x28b8dde4);
    }

    public void _0x9b9fcc5d()
    {
        for (int _0x56207323 = 0; _0x56207323 < this._0x63c40e0f.Count; _0x56207323++)
        {
            if (this._0x63c40e0f[_0x56207323] != null)
            {
                Destroy(this._0x63c40e0f[_0x56207323].gameObject);
            }
        }

        this._0x63c40e0f.Clear();
    }

    private _0xa9e6f5e6 _0x085e4e3c;
    private void _0x05eeddf6()
    {
        if (this._0xc0bb1e10 == null || this._0xc0bb1e10._0x0ac5e015 == null)
        {
            return;
        }

        SpriteRenderer _0xe9c3b149 = _0x4051eae7.Spawn(this._0xc0bb1e10._0x0ac5e015, this.transform, new Vector3(0f, this._0x908c5eb5._0xb00f69b4 * 1.05f, 0f), this._0x908c5eb5._0xc39a4053, _0x38c6998c.FloorMarkOrder, _0x821966c0.Alpha(_0x821966c0.Secondary, 0.55f));
        if (_0xe9c3b149 != null)
        {
            this._0x63c40e0f.Add(_0xe9c3b149);
        }
    }
}