using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Small factory for the runtime UGUI this game builds inside the template's own panel
// bodies. Everything here is type-driven - no object is ever looked up by name.
//
// The rounded plate sprite is passed in (it comes from a serialized reference), never
// loaded by path, so renaming assets cannot blank a panel.
public static class _0x56941319
{
    public static Image Picture(Transform _0x8ec2deb7, string _0x861e886e, Sprite _0xc6d189cd, Color _0xb3ea0df3)
    {
        GameObject _0x603c73e7 = new GameObject(_0x861e886e, typeof(RectTransform));
        RectTransform _0x0062c90b = _0x603c73e7.GetComponent<RectTransform>();
        _0x0062c90b.SetParent(_0x8ec2deb7, false);
        Stretch(_0x0062c90b);
        Image _0x26cfb929 = _0x603c73e7.AddComponent<Image>();
        _0x26cfb929.sprite = _0xc6d189cd;
        _0x26cfb929.type = Image.Type.Simple;
        _0x26cfb929.preserveAspect = true;
        _0x26cfb929.color = _0xb3ea0df3;
        _0x26cfb929.raycastTarget = false;
        return _0x26cfb929;
    }

    // A rounded corner reads the same at every size only if the slice multiplier
    // follows the rect: the smaller the box, the higher the multiplier.
    public static float RadiusFor(Vector2 _0xda4adc55)
    {
        float _0x8e19bd76 = Mathf.Max(1f, Mathf.Min(Mathf.Abs(_0xda4adc55.x), Mathf.Abs(_0xda4adc55.y)));
        return Mathf.Clamp(260f / _0x8e19bd76, 1.35f, 6f);
    }

    // A fresh RectTransform is 100x100 anchored at the centre; anything parented into a
    // 1242x2688 panel has to be told otherwise immediately or every child resolves
    // against 100x100.
    public static void Stretch(RectTransform _0xd64ebcd1)
    {
        _0xd64ebcd1.anchorMin = Vector2.zero;
        _0xd64ebcd1.anchorMax = Vector2.one;
        _0xd64ebcd1.pivot = new Vector2(0.5f, 0.5f);
        _0xd64ebcd1.anchoredPosition = Vector2.zero;
        _0xd64ebcd1.sizeDelta = Vector2.zero;
        _0xd64ebcd1.localScale = Vector3.one;
    }

    public static void Place(RectTransform _0xbdc97948, Vector2 _0xa88a472c, Vector2 _0x8452b9a8, Vector2 _0x4291e3a3)
    {
        _0xbdc97948.anchorMin = _0xa88a472c;
        _0xbdc97948.anchorMax = _0xa88a472c;
        _0xbdc97948.pivot = new Vector2(0.5f, 0.5f);
        _0xbdc97948.anchoredPosition = _0x8452b9a8;
        _0xbdc97948.sizeDelta = _0x4291e3a3;
        _0xbdc97948.localScale = Vector3.one;
    }

    // Rule: wrapping is OFF everywhere and line breaks are written by hand, so the
    // layout is identical on every device. Autosize is ON with a readable floor.
    public const float FontFloor = 32f;
    public static CanvasGroup Group(RectTransform _0xc6f182c8)
    {
        CanvasGroup _0x478850a7 = _0xc6f182c8.GetComponent<CanvasGroup>();
        if (_0x478850a7 == null)
        {
            _0x478850a7 = _0xc6f182c8.gameObject.AddComponent<CanvasGroup>();
        }

        return _0x478850a7;
    }

    public const float ReferenceHeight = 2688f;
    public const float ReferenceWidth = 1242f;
    public static RectTransform Node(Transform _0x7deb7249, string _0x273dd76b)
    {
        GameObject _0x60831502 = new GameObject(_0x273dd76b, typeof(RectTransform));
        RectTransform _0x0d1484cb = _0x60831502.GetComponent<RectTransform>();
        _0x0d1484cb.SetParent(_0x7deb7249, false);
        Stretch(_0x0d1484cb);
        return _0x0d1484cb;
    }

    // A transparent Image is culled by the raycaster, so a tap catcher needs a trace of
    // alpha and cullTransparentMesh switched off.
    public static Image TapSurface(Transform _0x4b0b510d, string _0xf6951a26)
    {
        Image _0xe0b6d784 = Plate(_0x4b0b510d, _0xf6951a26, null, new Color(0f, 0f, 0f, 0.004f), 1f);
        _0xe0b6d784.type = Image.Type.Simple;
        _0xe0b6d784.raycastTarget = true;
        _0xe0b6d784.canvasRenderer.cullTransparentMesh = false;
        return _0xe0b6d784;
    }

    public static Image Plate(Transform _0xb01c3051, string _0x434a6c11, Sprite _0xe1d0160c, Color _0xeddf9c41, float _0x7d8eff31)
    {
        GameObject _0x9e81fab1 = new GameObject(_0x434a6c11, typeof(RectTransform));
        RectTransform _0xb2d5d3cf = _0x9e81fab1.GetComponent<RectTransform>();
        _0xb2d5d3cf.SetParent(_0xb01c3051, false);
        Stretch(_0xb2d5d3cf);
        Image _0xaf9fbf11 = _0x9e81fab1.AddComponent<Image>();
        _0xaf9fbf11.sprite = _0xe1d0160c;
        _0xaf9fbf11.type = Image.Type.Sliced;
        _0xaf9fbf11.pixelsPerUnitMultiplier = _0x7d8eff31;
        _0xaf9fbf11.color = _0xeddf9c41;
        _0xaf9fbf11.raycastTarget = false;
        return _0xaf9fbf11;
    }

    public static TextMeshProUGUI Label(Transform _0xa804ab14, string _0x0711f403, string _0x30b1c3bc, float _0xcb13ba16, Color _0x73b8c36d, TMP_FontAsset _0x9cbf1958, TextAlignmentOptions _0x03548a60)
    {
        GameObject _0x7d283730 = new GameObject(_0x0711f403, typeof(RectTransform));
        RectTransform _0xf535310a = _0x7d283730.GetComponent<RectTransform>();
        _0xf535310a.SetParent(_0xa804ab14, false);
        Stretch(_0xf535310a);
        TextMeshProUGUI _0x362a264e = _0x7d283730.AddComponent<TextMeshProUGUI>();
        if (_0x9cbf1958 != null)
        {
            _0x362a264e.font = _0x9cbf1958;
        }

        _0x362a264e.text = _0x30b1c3bc;
        _0x362a264e.color = _0x73b8c36d;
        _0x362a264e.alignment = _0x03548a60;
        _0x362a264e.raycastTarget = false;
        _0x362a264e.richText = false;
        _0x362a264e.textWrappingMode = TextWrappingModes.NoWrap;
        _0x362a264e.overflowMode = TextOverflowModes.Overflow;
        _0x362a264e.enableAutoSizing = true;
        _0x362a264e.fontSizeMin = FontFloor;
        _0x362a264e.fontSizeMax = Mathf.Max(FontFloor, _0xcb13ba16);
        _0x362a264e.fontSize = Mathf.Max(FontFloor, _0xcb13ba16);
        return _0x362a264e;
    }

    // A themed button: rounded body, bright rim, label drawn LAST so it is always on
    // top of its own background. The body is the raycast target and the press tint
    // multiplies it, so a runtime recolour of the body survives.
    public static Button TextButton(Transform _0x03e1d677, string _0x64b8a85b, string _0x2596f9d8, Vector2 _0xe5bc268a, Vector2 _0x3f2a3bb2, Vector2 _0x76880195, Color _0xb0176770, Color _0xddd355da, Color _0x5af5f411, float _0x4192b026, Sprite _0x6fbbfbd6, TMP_FontAsset _0x1c5d626c)
    {
        GameObject _0x18c0cef0 = new GameObject(_0x64b8a85b, typeof(RectTransform));
        RectTransform _0x99ef8ff8 = _0x18c0cef0.GetComponent<RectTransform>();
        _0x99ef8ff8.SetParent(_0x03e1d677, false);
        Place(_0x99ef8ff8, _0xe5bc268a, _0x3f2a3bb2, _0x76880195);
        float _0x62604e44 = RadiusFor(_0x76880195);
        Image _0x53de8e5c = Plate(_0x99ef8ff8, _0x64b8a85b + _0xdba966bc._0x7b9d6cbe(new byte[3] { 121, 66, 70 }, 43), _0x6fbbfbd6, _0xddd355da, _0x62604e44);
        Stretch(_0x53de8e5c.rectTransform);
        Image _0x47aceb32 = Plate(_0x99ef8ff8, _0x64b8a85b + _0xdba966bc._0x7b9d6cbe(new byte[4] { 247, 218, 209, 204 }, 181), _0x6fbbfbd6, _0xb0176770, _0x62604e44);
        Stretch(_0x47aceb32.rectTransform);
        _0x47aceb32.rectTransform.offsetMin = new Vector2(5f, 5f);
        _0x47aceb32.rectTransform.offsetMax = new Vector2(-5f, -5f);
        _0x47aceb32.raycastTarget = true;
        TextMeshProUGUI _0x94cf798c = Label(_0x99ef8ff8, _0x64b8a85b + _0xdba966bc._0x7b9d6cbe(new byte[5] { 20, 57, 58, 61, 52 }, 88), _0x2596f9d8, _0x4192b026, _0x5af5f411, _0x1c5d626c, TextAlignmentOptions.Center);
        _0x94cf798c.rectTransform.offsetMin = new Vector2(24f, 0f);
        _0x94cf798c.rectTransform.offsetMax = new Vector2(-24f, 0f);
        Button _0x671d502d = _0x18c0cef0.AddComponent<Button>();
        _0x671d502d.targetGraphic = _0x47aceb32;
        ColorBlock _0xe1439c16 = _0x671d502d.colors;
        _0xe1439c16.normalColor = Color.white;
        _0xe1439c16.highlightedColor = new Color(1.1f, 1.1f, 1.1f, 1f);
        _0xe1439c16.pressedColor = new Color(0.72f, 0.72f, 0.78f, 1f);
        _0xe1439c16.selectedColor = Color.white;
        _0xe1439c16.disabledColor = new Color(1f, 1f, 1f, 0.45f);
        _0xe1439c16.fadeDuration = 0.08f;
        _0x671d502d.colors = _0xe1439c16;
        return _0x671d502d;
    }
}

internal static class _0xdba966bc
{
    internal static string _0x7b9d6cbe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}