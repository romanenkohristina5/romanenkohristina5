using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x21467d3a : MonoBehaviour
{
    private Canvas _0x9325f208;
    private void Awake()
    {
        if (!_0x9907e8f4.Contains(this))
            _0x9907e8f4.Add(this);
        this._0x9325f208 = this.GetComponent<Canvas>();
        this._0x4922f4f2 = this.GetComponent<CanvasScaler>();
        if (this._0x4922f4f2 != null)
            this._0x579594a0 = this._0x4922f4f2.referenceResolution;
        this._0x2a200d7b = this.GetComponent<RectTransform>();
        this._0x83d251c7 = this.transform.Find(_0x064c104a._0xcc5e7ea2(new byte[8] { 64, 114, 117, 118, 82, 97, 118, 114 }, 19)) as RectTransform;
        if (!_0xb801f6ba)
        {
            _0x365aa935 = Screen.orientation;
            _0x2238f200.x = Screen.width;
            _0x2238f200.y = Screen.height;
            _0xaeebc5c6 = Screen.safeArea;
            _0xb801f6ba = true;
        }

        this._0xc1236661();
    }

    private static Vector2 _0x2238f200 = Vector2.zero;
    private static bool _0xb801f6ba;
    private RectTransform _0x83d251c7;
    private RectTransform _0x2a200d7b;
    private void OnDestroy()
    {
        if (_0x9907e8f4 != null && _0x9907e8f4.Contains(this))
            _0x9907e8f4.Remove(this);
    }

    private static readonly List<_0x21467d3a> _0x9907e8f4 = new();
    private static void ResolutionChanged()
    {
        _0x2238f200.x = Screen.width;
        _0x2238f200.y = Screen.height;
        _0xaeebc5c6 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x74953466.Invoke();
    }

    private static Rect _0xaeebc5c6 = Rect.zero;
    private CanvasScaler _0x4922f4f2;
    private void Update()
    {
        if (_0x9907e8f4.Count == 0 || _0x9907e8f4[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x365aa935)
            OrientationChanged();
        if (Screen.safeArea != _0xaeebc5c6)
            SafeAreaChanged();
        if (Screen.width != _0x2238f200.x || Screen.height != _0x2238f200.y)
            ResolutionChanged();
    }

    private void _0xc1236661()
    {
        if (this._0x83d251c7 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xd999aa3f = Screen.safeArea;
        Vector2 _0xf27722d3 = _0xd999aa3f.position;
        Vector2 _0xb3ca0ce1 = _0xd999aa3f.position + _0xd999aa3f.size;
        _0xf27722d3.x /= screenWidth;
        _0xf27722d3.y /= screenHeight;
        _0xb3ca0ce1.x /= screenWidth;
        _0xb3ca0ce1.y /= screenHeight;
        this._0x83d251c7.anchorMin = _0xf27722d3;
        this._0x83d251c7.anchorMax = _0xb3ca0ce1;
        this._0x83d251c7.offsetMin = Vector2.zero;
        this._0x83d251c7.offsetMax = Vector2.zero;
        if (this._0x4922f4f2 == null)
            return;
        Vector2 _0xdd760285 = _0xb3ca0ce1 - _0xf27722d3;
        float _0x17f77619 = 2f - _0xdd760285.x;
        float _0x21c5ef60 = 2f - _0xdd760285.y;
        this._0x4922f4f2.referenceResolution = this._0x579594a0 * new Vector2(_0x17f77619, _0x21c5ef60);
    }

    private static ScreenOrientation _0x365aa935 = ScreenOrientation.LandscapeLeft;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x6d92f9db = 0; _0x6d92f9db < _0x9907e8f4.Count; _0x6d92f9db++)
            _0x9907e8f4[_0x6d92f9db]._0xc1236661();
    }

    private Vector2 _0x579594a0;
    private static UnityEvent _0x74953466 = new();
    private void Start()
    {
    }

    private static void SafeAreaChanged()
    {
        _0xaeebc5c6 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void OrientationChanged()
    {
        _0x365aa935 = Screen.orientation;
        _0x2238f200.x = Screen.width;
        _0x2238f200.y = Screen.height;
        _0xaeebc5c6 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x74953466.Invoke();
    }
}

internal static class _0x064c104a
{
    internal static string _0xcc5e7ea2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}