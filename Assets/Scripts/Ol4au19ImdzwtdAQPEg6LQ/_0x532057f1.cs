using System.Collections.Generic;
using UnityEngine;

// Walks the chart: brings each note on screen exactly ApproachSeconds before its hit
// instant, moves the live ones, and retires them once they have left the deck. It owns
// no judgement - the run controller asks it what is currently catchable.
public sealed class _0x532057f1 : MonoBehaviour
{
    private _0x18132870 _0x69721ca9;
    public bool _0x243c11e9
    {
        get
        {
            return this._0xf883f0c2 != null && this._0x444ea12c >= this._0xf883f0c2.Count && this._0xd00bb95a.Count == 0;
        }
    }

    public int _0xbd96e045
    {
        get
        {
            return this._0xf883f0c2 != null ? this._0xf883f0c2.Count : 0;
        }
    }

    private List<_0x7b26b63d> _0xf883f0c2;
    private _0x38c6998c _0x7870eaea;
    // Any note whose GOOD window has closed without being judged.
    public _0x2817bba2 _0xaed94b8e(float _0x60a986ad)
    {
        for (int _0x6c3e42b3 = 0; _0x6c3e42b3 < this._0xd00bb95a.Count; _0x6c3e42b3++)
        {
            _0x2817bba2 _0xe552bd7b = this._0xd00bb95a[_0x6c3e42b3];
            if (_0xe552bd7b == null || _0xe552bd7b._0xc1b8ac1d)
            {
                continue;
            }

            if (_0x60a986ad > _0xe552bd7b._0x49f40979._0x4a19d5f7 + _0xd04e59fe.GoodWindow)
            {
                return _0xe552bd7b;
            }
        }

        return null;
    }

    private int _0x444ea12c;
    public void _0xb6f05897(_0x18132870 _0x34391f71, _0x38c6998c _0x54c30e3d, List<_0x7b26b63d> _0xf95d696c)
    {
        this._0x69721ca9 = _0x34391f71;
        this._0x7870eaea = _0x54c30e3d;
        this._0xf883f0c2 = _0xf95d696c;
        this._0x444ea12c = 0;
    }

    public void _0xae78a027()
    {
        for (int _0xdd976cf8 = 0; _0xdd976cf8 < this._0xd00bb95a.Count; _0xdd976cf8++)
        {
            if (this._0xd00bb95a[_0xdd976cf8] != null)
            {
                Destroy(this._0xd00bb95a[_0xdd976cf8].gameObject);
            }
        }

        this._0xd00bb95a.Clear();
    }

    private void _0x81c9b04f(_0x7b26b63d _0xbd560fd5)
    {
        GameObject _0x7f25d419 = new GameObject(_0xe8a445e4._0xeb5b7331(new byte[5] { 17, 52, 45, 50, 36 }, 65));
        _0x7f25d419.transform.SetParent(this.transform, false);
        _0x2817bba2 _0x1fe6d74c = _0x7f25d419.AddComponent<_0x2817bba2>();
        _0x1fe6d74c._0xb56900b2(this._0x69721ca9, this._0x7870eaea, _0xbd560fd5);
        this._0xd00bb95a.Add(_0x1fe6d74c);
    }

    public int _0x3987f9a9
    {
        get
        {
            return this._0x444ea12c;
        }
    }

    public void _0x62e07f37(float _0x746ea3b0)
    {
        if (this._0xf883f0c2 == null)
        {
            return;
        }

        while (this._0x444ea12c < this._0xf883f0c2.Count && this._0xf883f0c2[this._0x444ea12c]._0x4a19d5f7 - _0x746ea3b0 <= _0xd04e59fe.ApproachSeconds)
        {
            this._0x81c9b04f(this._0xf883f0c2[this._0x444ea12c]);
            this._0x444ea12c++;
        }

        for (int _0x6a4b56a8 = this._0xd00bb95a.Count - 1; _0x6a4b56a8 >= 0; _0x6a4b56a8--)
        {
            _0x2817bba2 _0xcaa5e4a4 = this._0xd00bb95a[_0x6a4b56a8];
            if (_0xcaa5e4a4 == null)
            {
                this._0xd00bb95a.RemoveAt(_0x6a4b56a8);
                continue;
            }

            _0xcaa5e4a4._0xe1d6e390(_0x746ea3b0);
            // Retire once the whole note has travelled a full approach past the deck.
            if (_0x746ea3b0 > _0xcaa5e4a4._0x49f40979._0xe91fd7a8 + _0xd04e59fe.ApproachSeconds * 0.5f)
            {
                this._0xd00bb95a.RemoveAt(_0x6a4b56a8);
                Destroy(_0xcaa5e4a4.gameObject);
            }
        }
    }

    // The one note a tap can currently be about: the earliest unresolved note whose hit
    // instant is inside the GOOD window. The chart guarantees at most one.
    public _0x2817bba2 _0x3cf30cdf(float _0x0d90ad27, int _0x6f87cffe)
    {
        for (int _0x9e16e7bd = 0; _0x9e16e7bd < this._0xd00bb95a.Count; _0x9e16e7bd++)
        {
            _0x2817bba2 _0x42cea5d5 = this._0xd00bb95a[_0x9e16e7bd];
            if (_0x42cea5d5 == null || _0x42cea5d5._0xc1b8ac1d || _0x42cea5d5._0x49f40979._0x32d0badb != _0x6f87cffe)
            {
                continue;
            }

            if (Mathf.Abs(_0x42cea5d5._0x49f40979._0x4a19d5f7 - _0x0d90ad27) <= _0xd04e59fe.GoodWindow)
            {
                return _0x42cea5d5;
            }
        }

        return null;
    }

    private readonly List<_0x2817bba2> _0xd00bb95a = new List<_0x2817bba2>();
}

internal static class _0xe8a445e4
{
    internal static string _0xeb5b7331(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}