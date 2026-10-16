using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The in-run readout, built into the template's own game panel body after the template
// HUD has been switched off. Back and Pause are this game's own targets, placed where
// nothing else sits, and the full-surface tap catcher is the FIRST child so every later
// button wins its own raycast.
public sealed class _0xc68d6f90 : MonoBehaviour
{
    public Button _0x0bbfafc8(string _0xebd59e3f, Sprite _0xb4f80ea7, bool _0x8cfb2aa7)
    {
        GameObject _0xf7b32134 = new GameObject(_0xebd59e3f, typeof(RectTransform));
        RectTransform _0x7ece9dff = _0xf7b32134.GetComponent<RectTransform>();
        _0x7ece9dff.SetParent(this._0x2a2fd1c8, false);
        _0x56941319.Place(_0x7ece9dff, new Vector2(_0x8cfb2aa7 ? 0f : 1f, 1f), new Vector2(_0x8cfb2aa7 ? 96f : -96f, -112f), new Vector2(120f, 120f));
        Image _0x20bd9a5c = _0x56941319.Plate(_0x7ece9dff, _0xebd59e3f + _0xe8eee5b2._0xdd205b20(new byte[4] { 107, 70, 77, 80 }, 41), this._0x1978985a._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Surface, 0.95f), 2.6f);
        _0x56941319.Stretch(_0x20bd9a5c.rectTransform);
        _0x20bd9a5c.raycastTarget = true;
        _0x20bd9a5c.canvasRenderer.cullTransparentMesh = false;
        Image _0xbd17ab0c = _0x56941319.Plate(_0x7ece9dff, _0xebd59e3f + _0xe8eee5b2._0xdd205b20(new byte[3] { 137, 178, 182 }, 219), this._0x1978985a._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Primary, 0.9f), 2.6f);
        _0x56941319.Stretch(_0xbd17ab0c.rectTransform);
        _0xbd17ab0c.rectTransform.offsetMin = new Vector2(-4f, -4f);
        _0xbd17ab0c.rectTransform.offsetMax = new Vector2(4f, 4f);
        _0xbd17ab0c.rectTransform.SetAsFirstSibling();
        Image _0xb0fbca73 = _0x56941319.Picture(_0x7ece9dff, _0xebd59e3f + _0xe8eee5b2._0xdd205b20(new byte[5] { 0, 43, 62, 55, 47 }, 71), _0xb4f80ea7, _0x821966c0.TextPrimary);
        _0x56941319.Stretch(_0xb0fbca73.rectTransform);
        _0xb0fbca73.rectTransform.offsetMin = new Vector2(28f, 28f);
        _0xb0fbca73.rectTransform.offsetMax = new Vector2(-28f, -28f);
        Button _0xa5aea684 = _0xf7b32134.AddComponent<Button>();
        _0xa5aea684.targetGraphic = _0x20bd9a5c;
        return _0xa5aea684;
    }

    private void _0xc6194a4f()
    {
        RectTransform _0xe21cbce1 = _0x56941319.Node(this._0x2a2fd1c8, _0xe8eee5b2._0xdd205b20(new byte[9] { 22, 61, 54, 33, 52, 42, 17, 50, 33 }, 83));
        _0x56941319.Place(_0xe21cbce1, new Vector2(0.5f, 0.945f), Vector2.zero, new Vector2(780f, 52f));
        Image _0xce5c0c3e = _0x56941319.Picture(_0xe21cbce1, _0xe8eee5b2._0xdd205b20(new byte[11] { 87, 124, 119, 96, 117, 107, 70, 96, 115, 113, 121 }, 18), this._0x1978985a._0x9a0ee9f4, Color.white);
        _0xce5c0c3e.type = Image.Type.Sliced;
        _0xce5c0c3e.preserveAspect = false;
        _0xce5c0c3e.pixelsPerUnitMultiplier = 2f;
        _0x56941319.Stretch(_0xce5c0c3e.rectTransform);
        this._0x673ad5a8 = 764f;
        this._0xea60bee7 = _0x56941319.Plate(_0xe21cbce1, _0xe8eee5b2._0xdd205b20(new byte[10] { 55, 28, 23, 0, 21, 11, 52, 27, 30, 30 }, 114), this._0x1978985a._0x07271a7c, _0x821966c0.Secondary, 3.2f);
        _0x56941319.Place(this._0xea60bee7.rectTransform, new Vector2(0f, 0.5f), new Vector2(8f + this._0x673ad5a8 * 0.5f, 0f), new Vector2(this._0x673ad5a8, 34f));
        this._0xea60bee7.rectTransform.pivot = new Vector2(0f, 0.5f);
        this._0xea60bee7.rectTransform.anchoredPosition = new Vector2(8f, 0f);
        this._0x0a1a4e2f = _0x56941319.Plate(_0xe21cbce1, _0xe8eee5b2._0xdd205b20(new byte[10] { 179, 152, 147, 132, 145, 143, 177, 154, 153, 129 }, 246), this._0x1978985a._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Primary, 0.35f), 3.2f);
        _0x56941319.Place(this._0x0a1a4e2f.rectTransform, new Vector2(0f, 0.5f), Vector2.zero, new Vector2(this._0x673ad5a8, 16f));
        this._0x0a1a4e2f.rectTransform.pivot = new Vector2(0f, 0.5f);
        this._0x0a1a4e2f.rectTransform.anchoredPosition = new Vector2(8f, -6f);
        TextMeshProUGUI _0x18904f70 = _0x56941319.Label(this._0x2a2fd1c8, _0xe8eee5b2._0xdd205b20(new byte[13] { 49, 26, 17, 6, 19, 13, 55, 21, 4, 0, 29, 27, 26 }, 116), _0xe8eee5b2._0xdd205b20(new byte[6] { 45, 38, 47, 60, 41, 43 }, 110), 34f, _0x821966c0.TextMuted, this._0x1978985a._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x18904f70.rectTransform, new Vector2(0.5f, 0.975f), Vector2.zero, new Vector2(420f, 44f));
    }

    public void _0x69202304(int _0x6e8e63e1)
    {
        if (this._0x7b81723f != null)
        {
            this._0x7b81723f.text = _0xe8eee5b2._0xdd205b20(new byte[4] { 191, 189, 189, 222 }, 254) + _0x6e8e63e1 + _0xe8eee5b2._0xdd205b20(new byte[1] { 67 }, 102);
        }
    }

    private RectTransform _0x5a19050f;
    public void _0xb1d36679()
    {
        if (this._0x2e166f0c == null)
        {
            return;
        }

        DOTween.Kill(this._0x2e166f0c, true);
        this._0x2e166f0c.color = _0x821966c0.Alpha(_0x821966c0.DangerFill, 0.25f);
        this._0x2e166f0c.DOFade(0f, _0xd04e59fe.BreakFlashSeconds).SetTarget(this._0x2e166f0c);
    }

    public Transform _0x8eab1455(_0x18132870 _0xf7d0e9f9, Transform _0xdf53222c)
    {
        this._0x1978985a = _0xf7d0e9f9;
        this._0x2a2fd1c8 = _0x56941319.Node(_0xdf53222c, _0xe8eee5b2._0xdd205b20(new byte[11] { 216, 227, 234, 237, 255, 217, 254, 229, 195, 254, 239 }, 139));
        this._0xc6194a4f();
        this._0x5785c5ad();
        this._0xa8df924f();
        this._0x3c6c8f8b();
        return this._0x2a2fd1c8;
    }

    private void _0x5785c5ad()
    {
        this._0x71571bd8 = this._0xc8c42c8b(-382f, _0xe8eee5b2._0xdd205b20(new byte[13] { 216, 210, 209, 209, 204, 190, 174, 174, 190, 177, 190, 174, 174 }, 158), _0x821966c0.TextPrimary);
        this._0x7b81723f = this._0xc8c42c8b(0f, _0xe8eee5b2._0xdd205b20(new byte[8] { 62, 60, 60, 95, 78, 79, 79, 90 }, 127), _0x821966c0.Secondary);
        this._0x919f080d = this._0xc8c42c8b(382f, _0xe8eee5b2._0xdd205b20(new byte[8] { 76, 64, 66, 77, 64, 47, 119, 63 }, 15), _0x821966c0.TextMuted);
    }

    private TextMeshProUGUI _0x71571bd8;
    private Image _0x0a1a4e2f;
    public void _0xf6aa2fef(int _0x298e223d, int _0xbd1a3f52)
    {
        if (this._0x71571bd8 != null)
        {
            this._0x71571bd8.text = _0xe8eee5b2._0xdd205b20(new byte[6] { 109, 103, 100, 100, 121, 11 }, 43) + Two(_0x298e223d) + _0xe8eee5b2._0xdd205b20(new byte[3] { 241, 254, 241 }, 209) + Two(_0xbd1a3f52);
        }
    }

    private RectTransform _0x2a2fd1c8;
    private TextMeshProUGUI _0xc8c42c8b(float _0xcd0f6f59, string _0xed16be57, Color _0x4a1ed2d0)
    {
        TextMeshProUGUI _0xe0a1a85f = _0x56941319.Label(this._0x2a2fd1c8, _0xe8eee5b2._0xdd205b20(new byte[10] { 185, 158, 133, 168, 132, 158, 133, 159, 142, 153 }, 235), _0xed16be57, 52f, _0x4a1ed2d0, this._0x1978985a._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0xe0a1a85f.rectTransform, new Vector2(0.5f, 0.905f), new Vector2(_0xcd0f6f59, 0f), new Vector2(372f, 66f));
        return _0xe0a1a85f;
    }

    private static string Two(int _0x3e0f3f21)
    {
        return _0x3e0f3f21 < 10 ? _0xe8eee5b2._0xdd205b20(new byte[1] { 19 }, 35) + _0x3e0f3f21 : _0x3e0f3f21.ToString();
    }

    public RectTransform _0x1cf31f31
    {
        get
        {
            return this._0x2a2fd1c8;
        }
    }

    public void _0x76a9f9aa(int _0x98e5ab5a)
    {
        if (this._0x919f080d == null)
        {
            return;
        }

        this._0x919f080d.text = _0xe8eee5b2._0xdd205b20(new byte[7] { 195, 207, 205, 194, 207, 160, 248 }, 128) + _0x98e5ab5a;
        this._0x919f080d.color = _0x98e5ab5a >= 10 ? _0x821966c0.Reward : _0x821966c0.TextMuted;
    }

    private Image _0x2e166f0c;
    private float _0x673ad5a8;
    private TextMeshProUGUI _0x7b81723f;
    // Rule C.6: the control scheme is tap AND hold, so it has to be written on screen,
    // in the frame the review will photograph. It stays solid for the first 20 seconds
    // and then dims rather than disappearing.
    private void _0xa8df924f()
    {
        this._0x5a19050f = _0x56941319.Node(this._0x2a2fd1c8, _0xe8eee5b2._0xdd205b20(new byte[7] { 105, 78, 85, 115, 82, 85, 79 }, 59));
        _0x56941319.Place(this._0x5a19050f, new Vector2(0.5f, 0.055f), Vector2.zero, new Vector2(1000f, 96f));
        Image _0xb818dde8 = _0x56941319.Plate(this._0x5a19050f, _0xe8eee5b2._0xdd205b20(new byte[11] { 204, 235, 240, 214, 247, 240, 234, 220, 255, 253, 245 }, 158), this._0x1978985a._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Deep, 0.7f), 1.35f);
        _0x56941319.Stretch(_0xb818dde8.rectTransform);
        TextMeshProUGUI _0xed915474 = _0x56941319.Label(this._0x5a19050f, _0xe8eee5b2._0xdd205b20(new byte[11] { 23, 48, 43, 13, 44, 43, 49, 17, 32, 61, 49 }, 69), _0xe8eee5b2._0xdd205b20(new byte[39] { 99, 118, 103, 23, 99, 127, 114, 23, 123, 126, 99, 23, 100, 114, 116, 99, 120, 101, 23, 26, 23, 127, 120, 123, 115, 23, 99, 127, 114, 23, 123, 120, 121, 112, 23, 117, 114, 118, 122 }, 55), 42f, _0x821966c0.TextPrimary, this._0x1978985a._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Stretch(_0xed915474.rectTransform);
        CanvasGroup _0xaac0fd9d = _0x56941319.Group(this._0x5a19050f);
        _0xaac0fd9d.alpha = 1f;
        _0xaac0fd9d.DOFade(_0xd04e59fe.HintFadedAlpha, 0.6f).SetDelay(_0xd04e59fe.HintVisibleSeconds);
    }

    private _0x18132870 _0x1978985a;
    private void _0x3c6c8f8b()
    {
        this._0x2e166f0c = _0x56941319.Plate(this._0x2a2fd1c8, _0xe8eee5b2._0xdd205b20(new byte[10] { 118, 70, 81, 85, 95, 114, 88, 85, 71, 92 }, 52), this._0x1978985a._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.DangerFill, 0f), 1f);
        _0x56941319.Stretch(this._0x2e166f0c.rectTransform);
        this._0x2e166f0c.rectTransform.offsetMin = new Vector2(-200f, -200f);
        this._0x2e166f0c.rectTransform.offsetMax = new Vector2(200f, 200f);
    }

    private Image _0xea60bee7;
    private TextMeshProUGUI _0x919f080d;
    // ---- live values ------------------------------------------------------------
    public void _0x792b857f(float _0xc82da646)
    {
        float _0x6ac29de2 = Mathf.Clamp01(_0xc82da646);
        bool _0x32ed91bf = _0x6ac29de2 < _0xd04e59fe.LowEnergyShare;
        if (this._0xea60bee7 != null)
        {
            this._0xea60bee7.rectTransform.sizeDelta = new Vector2(this._0x673ad5a8 * _0x6ac29de2, this._0xea60bee7.rectTransform.sizeDelta.y);
            this._0xea60bee7.color = _0x32ed91bf ? _0x821966c0.DangerFill : _0x821966c0.Secondary;
        }

        if (this._0x0a1a4e2f != null)
        {
            this._0x0a1a4e2f.rectTransform.sizeDelta = new Vector2(this._0x673ad5a8 * _0x6ac29de2, this._0x0a1a4e2f.rectTransform.sizeDelta.y);
            this._0x0a1a4e2f.color = _0x821966c0.Alpha(_0x32ed91bf ? _0x821966c0.DangerText : _0x821966c0.Primary, 0.35f);
        }
    }
}

internal static class _0xe8eee5b2
{
    internal static string _0xdd205b20(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}