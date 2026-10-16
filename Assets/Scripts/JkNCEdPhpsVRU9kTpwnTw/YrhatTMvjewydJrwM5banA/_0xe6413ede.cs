using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xe6413ede : MonoBehaviour
{
    private static ScreenOrientation _0x5ce0b866 = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0xa59be80e.Contains(this))
            _0xa59be80e.Add(this);
        this._0xa329489f = this.GetComponent<Canvas>();
        this._0x300b4acc = this.GetComponent<RectTransform>();
        this._0x2a439343 = this.transform.Find(_0xd2f998f5._0x4da8ba93(new byte[8] { 203, 249, 254, 253, 217, 234, 253, 249 }, 152)) as RectTransform;
        if (!_0xcf3154c2)
        {
            _0x5ce0b866 = Screen.orientation;
            _0x99272266.x = Screen.width;
            _0x99272266.y = Screen.height;
            _0x644c9abf = Screen.safeArea;
            _0xcf3154c2 = true;
        }

        this._0xc63126b1();
    }

    private RectTransform _0x2a439343;
    private Canvas _0xa329489f;
    private static UnityEvent _0xbf73321c = new();
    private static void ResolutionChanged()
    {
        _0x99272266.x = Screen.width;
        _0x99272266.y = Screen.height;
        _0xbf73321c.Invoke();
    }

    private static Vector2 _0x99272266 = Vector2.zero;
    private static void SafeAreaChanged()
    {
        _0x644c9abf = Screen.safeArea;
        for (int _0xf7bcce51 = 0; _0xf7bcce51 < _0xa59be80e.Count; _0xf7bcce51++)
            _0xa59be80e[_0xf7bcce51]._0xc63126b1();
    }

    private static void OrientationChanged()
    {
        _0x5ce0b866 = Screen.orientation;
        _0x99272266.x = Screen.width;
        _0x99272266.y = Screen.height;
        _0xbf73321c.Invoke();
    }

    private void _0xc63126b1()
    {
        if (this._0x2a439343 == null)
            return;
        Rect _0x0bce8e3c = Screen.safeArea;
        Vector2 _0x89011571 = _0x0bce8e3c.position;
        Vector2 _0x492afbcb = _0x0bce8e3c.position + _0x0bce8e3c.size;
        _0x89011571.x /= this._0xa329489f.pixelRect.width;
        _0x89011571.y /= this._0xa329489f.pixelRect.height;
        _0x492afbcb.x /= this._0xa329489f.pixelRect.width;
        _0x492afbcb.y /= this._0xa329489f.pixelRect.height;
        this._0x2a439343.anchorMin = _0x89011571;
        this._0x2a439343.anchorMax = _0x492afbcb;
    }

    private static bool _0xcf3154c2;
    private static readonly List<_0xe6413ede> _0xa59be80e = new();
    private static Rect _0x644c9abf = Rect.zero;
    private void OnDestroy()
    {
        if (_0xa59be80e != null && _0xa59be80e.Contains(this))
            _0xa59be80e.Remove(this);
    }

    private void Update()
    {
        if (_0xa59be80e[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x5ce0b866)
            OrientationChanged();
        if (Screen.safeArea != _0x644c9abf)
            SafeAreaChanged();
        if (Screen.width != _0x99272266.x || Screen.height != _0x99272266.y)
            ResolutionChanged();
    }

    private RectTransform _0x300b4acc;
}

internal static class _0xd2f998f5
{
    internal static string _0x4da8ba93(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}