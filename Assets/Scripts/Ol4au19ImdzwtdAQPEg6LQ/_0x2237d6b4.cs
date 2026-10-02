using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The menu. Everything is built at runtime into the template's own DefaultPanel body,
// so the template hierarchy is untouched and nothing is addressed by name.
public sealed class _0x2237d6b4 : MonoBehaviour
{
    private void Start()
    {
        _0xb51ece01.DressSplash(this._art);
        _0xb51ece01.DressTutorials(this._art);
        Transform _0x315cc80f = _0xb51ece01.PanelBody(_0x1fc44a94._0x517a5fb9.DEFAULT);
        if (_0x315cc80f == null || this._art == null)
        {
            return;
        }

        this._0x595f9337 = _0x56941319.Node(_0x315cc80f, _0xbbd9911f._0x319207cf(new byte[9] { 11, 48, 57, 62, 44, 21, 61, 54, 45 }, 88));
        this._0x595f9337.SetAsFirstSibling();
        this._0x5bc4463e();
        this._0xd14b7166();
        this._0x74473c49();
        this._0x3aa59019();
        this._0x07c7167f();
        this._0xdbccfe15();
        this._0x34053f68(_0x315cc80f);
        this._0x8b8c226c = _0x56941319.Node(_0x315cc80f, _0xbbd9911f._0x319207cf(new byte[15] { 218, 225, 232, 239, 253, 221, 251, 232, 234, 226, 218, 225, 236, 236, 253 }, 137));
        this._0x8b8c226c.SetAsLastSibling();
        this._0xa5ba9f2f = this._0x8b8c226c.gameObject.AddComponent<_0xf49374fb>();
        this._0xa5ba9f2f._0x690bd584(this._art, this);
        this._0xa5ba9f2f._0x82cf156c();
        this._0x40726756();
        this._0x349cbb0b();
    }

    private const float GutterWidth = 48f;
    private void _0x74473c49()
    {
        Image _0x09d7fe62;
        RectTransform _0x06f30098 = _0xb51ece01.Card(this._0x595f9337, this._art, new Vector2(0.5f, 0.830f), Vector2.zero, new Vector2(1060f, 300f), _0x821966c0.Alpha(_0x821966c0.Primary, 0.95f), out _0x09d7fe62);
        this._0x00f7093c = _0x09d7fe62;
        this._0xb33afe26 = _0x56941319.Label(_0x06f30098, _0xbbd9911f._0x319207cf(new byte[10] { 47, 9, 26, 24, 16, 47, 18, 15, 23, 30 }, 123), _0xbbd9911f._0x319207cf(new byte[8] { 132, 130, 145, 147, 155, 240, 224, 225 }, 208), 56f, _0x821966c0.TextPrimary, this._art._0x6cd35f3f, TextAlignmentOptions.Left);
        _0x56941319.Place(this._0xb33afe26.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(TextCentre, 76f), new Vector2(TextWidth, 70f));
        this._0xea7fed40 = _0x56941319.Label(_0x06f30098, _0xbbd9911f._0x319207cf(new byte[9] { 69, 99, 112, 114, 122, 92, 116, 101, 112 }, 17), _0xbbd9911f._0x319207cf(new byte[7] { 237, 237, 236, 252, 158, 140, 145 }, 220), 40f, _0x821966c0.Secondary, this._art._0x6cd35f3f, TextAlignmentOptions.Left);
        _0x56941319.Place(this._0xea7fed40.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(TextCentre, 4f), new Vector2(TextWidth, 56f));
        TextMeshProUGUI _0xe9d52a9b = _0x56941319.Label(_0x06f30098, _0xbbd9911f._0x319207cf(new byte[9] { 243, 213, 198, 196, 204, 239, 206, 201, 211 }, 167), _0xbbd9911f._0x319207cf(new byte[33] { 129, 148, 133, 245, 129, 135, 148, 150, 158, 134, 245, 129, 154, 245, 133, 156, 150, 158, 245, 148, 155, 154, 129, 157, 144, 135, 245, 148, 134, 150, 144, 155, 129 }, 213), 34f, _0x821966c0.TextMuted, this._art._0x6cd35f3f, TextAlignmentOptions.Left);
        _0x56941319.Place(_0xe9d52a9b.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(TextCentre, -72f), new Vector2(TextWidth, 46f));
        this._0x300e8e82 = _0x56941319.Node(_0x06f30098, _0xbbd9911f._0x319207cf(new byte[11] { 233, 195, 192, 192, 221, 227, 206, 203, 203, 202, 221 }, 175));
        _0x56941319.Place(this._0x300e8e82, new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), new Vector2(GutterWidth, 236f));
    }

    private const float TextCentre = -125f;
    private RectTransform _0x595f9337;
    private _0xf49374fb _0xa5ba9f2f;
    // ---- state ------------------------------------------------------------------
    public void _0x40726756()
    {
        int _0xea372519 = _0x7a953d7d._0x10895542;
        _0x1729546e _0x35af3072 = _0x7a953d7d.Row(_0xea372519);
        Color _0x3ade9731 = _0x821966c0.TrackAccent(_0xea372519);
        if (this._0x9ce4e53b != null)
        {
            this._0x9ce4e53b.text = _0xd04e59fe.Grouped(_0x1fc44a94._0x9d1bd943._0x9c696c79);
        }

        if (this._0x76d61b39 != null)
        {
            this._0x76d61b39.text = _0x7a953d7d.BestAccuracy(_0xea372519) + _0xbbd9911f._0x319207cf(new byte[1] { 154 }, 191);
        }

        if (this._0xb33afe26 != null)
        {
            this._0xb33afe26.text = _0xbbd9911f._0x319207cf(new byte[7] { 193, 199, 212, 214, 222, 181, 165 }, 149) + (_0xea372519 + 1) + _0xbbd9911f._0x319207cf(new byte[3] { 65, 76, 65 }, 97) + _0x35af3072._0xf6be4951;
        }

        if (this._0xea7fed40 != null)
        {
            this._0xea7fed40.text = _0x35af3072._0x78386416 + _0xbbd9911f._0x319207cf(new byte[7] { 253, 159, 141, 144, 253, 242, 253 }, 221) + _0x35af3072._0xe6815054 + _0xbbd9911f._0x319207cf(new byte[15] { 244, 146, 152, 155, 155, 134, 135, 244, 251, 244, 150, 145, 135, 128, 244 }, 212) + _0x7a953d7d.BestAccuracy(_0xea372519) + _0xbbd9911f._0x319207cf(new byte[1] { 32 }, 5);
            this._0xea7fed40.color = _0x3ade9731;
        }

        if (this._0x00f7093c != null)
        {
            this._0x00f7093c.color = _0x821966c0.Alpha(_0x3ade9731, 0.95f);
        }

        for (int _0x6d7fe1c1 = 0; _0x6d7fe1c1 < this._0x16f5ea48.Count; _0x6d7fe1c1++)
        {
            this._0x16f5ea48[_0x6d7fe1c1].color = _0x3ade9731;
        }

        this._0x3efb63b8(_0x35af3072._0xe6815054, _0x3ade9731);
    }

    private void _0xd14b7166()
    {
        RectTransform _0xea1f57c3 = _0x56941319.Node(this._0x595f9337, _0xbbd9911f._0x319207cf(new byte[9] { 45, 10, 31, 10, 11, 13, 44, 17, 9 }, 126));
        _0x56941319.Place(_0xea1f57c3, new Vector2(0.5f, 0.945f), Vector2.zero, new Vector2(1120f, 130f));
        this._0x9ce4e53b = this._0x174cc13c(_0xea1f57c3, -290f, _0xbbd9911f._0x319207cf(new byte[6] { 38, 45, 36, 55, 34, 32 }, 101), _0x821966c0.Reward);
        this._0x76d61b39 = this._0x174cc13c(_0xea1f57c3, 290f, _0xbbd9911f._0x319207cf(new byte[4] { 82, 85, 67, 68 }, 16), _0x821966c0.Secondary);
    }

    private void _0x3efb63b8(int _0x10a5adfe, Color _0x3f852270)
    {
        if (this._0x300e8e82 == null)
        {
            return;
        }

        for (int _0x1bae7c5c = 0; _0x1bae7c5c < this._0xcc8052a6.Count; _0x1bae7c5c++)
        {
            if (this._0xcc8052a6[_0x1bae7c5c] != null)
            {
                Destroy(this._0xcc8052a6[_0x1bae7c5c].gameObject);
            }
        }

        this._0xcc8052a6.Clear();
        float _0x3250b569 = this._0x300e8e82.sizeDelta.y;
        float _0x90536712 = _0x3250b569 / Mathf.Max(1, _0x10a5adfe);
        float height = Mathf.Max(4f, _0x90536712 * 0.62f);
        // Lit steps show how far the best recorded ascent on this track got.
        int _0x083427af = Mathf.RoundToInt(_0x10a5adfe * _0x7a953d7d.BestAccuracy(_0x7a953d7d._0x10895542) / 100f);
        for (int _0x58c229c8 = 0; _0x58c229c8 < _0x10a5adfe; _0x58c229c8++)
        {
            Image _0x396c6e33 = _0x56941319.Plate(this._0x300e8e82, _0xbbd9911f._0x319207cf(new byte[10] { 5, 40, 45, 45, 44, 59, 26, 61, 44, 57 }, 73), this._art._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Primary, 0.35f), 4f);
            float _0x42ee164c = -_0x3250b569 * 0.5f + _0x90536712 * (_0x58c229c8 + 0.5f);
            _0x56941319.Place(_0x396c6e33.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(0f, _0x42ee164c), new Vector2(GutterWidth - 8f, height));
            if (_0x58c229c8 < _0x083427af)
            {
                _0x396c6e33.color = _0x3f852270;
            }

            this._0xcc8052a6.Add(_0x396c6e33);
        }
    }

    private void _0x3aa59019()
    {
        RectTransform _0x74d8411a = _0xb51ece01.Card(this._0x595f9337, this._art, new Vector2(0.5f, 0.575f), Vector2.zero, new Vector2(1060f, 860f), _0x821966c0.Alpha(_0x821966c0.Secondary, 0.55f));
        TextMeshProUGUI _0xa1387651 = _0x56941319.Label(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[12] { 218, 248, 239, 252, 227, 239, 253, 222, 227, 254, 230, 239 }, 138), _0xbbd9911f._0x319207cf(new byte[17] { 28, 11, 15, 10, 7, 0, 9, 110, 26, 6, 11, 110, 29, 6, 15, 8, 26 }, 78), 48f, _0x821966c0.TextPrimary, this._art._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0xa1387651.rectTransform, new Vector2(0.5f, 0.90f), Vector2.zero, new Vector2(900f, 70f));
        float[] _0x4534881f =
        {
            -330f,
            0f,
            330f
        };
        for (int _0x9eefeb3a = 0; _0x9eefeb3a < _0x4534881f.Length; _0x9eefeb3a++)
        {
            Image _0xdf66bad6 = _0x56941319.Picture(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[10] { 131, 161, 182, 165, 186, 182, 164, 131, 178, 183 }, 211), this._art._0x5684b951, Color.white);
            _0xdf66bad6.type = Image.Type.Sliced;
            _0xdf66bad6.preserveAspect = false;
            _0xdf66bad6.pixelsPerUnitMultiplier = 2.6f;
            _0x56941319.Place(_0xdf66bad6.rectTransform, new Vector2(0.5f, 0.21f), new Vector2(_0x4534881f[_0x9eefeb3a], 0f), new Vector2(296f, 128f));
        }

        Image _0x2e5a0be7 = _0x56941319.Picture(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[11] { 168, 138, 157, 142, 145, 157, 143, 188, 157, 155, 147 }, 248), this._art._0x12c042fb, Color.white);
        _0x2e5a0be7.type = Image.Type.Sliced;
        _0x2e5a0be7.preserveAspect = false;
        _0x2e5a0be7.pixelsPerUnitMultiplier = 2.2f;
        _0x56941319.Place(_0x2e5a0be7.rectTransform, new Vector2(0.5f, 0.10f), Vector2.zero, new Vector2(960f, 96f));
        Image _0xd3ae67b8 = _0x56941319.Picture(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[12] { 21, 55, 32, 51, 44, 32, 50, 22, 53, 36, 55, 46 }, 69), this._art._0x1945f64f, Color.white);
        _0x56941319.Place(_0xd3ae67b8.rectTransform, new Vector2(0.5f, 0.58f), new Vector2(-330f, 0f), new Vector2(170f, 170f));
        _0xd3ae67b8.rectTransform.DOAnchorPosY(_0xd3ae67b8.rectTransform.anchoredPosition.y - 150f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        Image _0xe981ec78 = _0x56941319.Picture(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[11] { 0, 34, 53, 38, 57, 53, 39, 18, 53, 49, 61 }, 80), this._art._0xedffc3ef, Color.white);
        _0x56941319.Place(_0xe981ec78.rectTransform, new Vector2(0.5f, 0.58f), new Vector2(330f, 0f), new Vector2(170f, 170f));
        Image _0x8231a8f4 = _0x56941319.Picture(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[15] { 178, 144, 135, 148, 139, 135, 149, 160, 135, 131, 143, 160, 141, 134, 155 }, 226), this._art._0x09d3091c, Color.white);
        _0x8231a8f4.type = Image.Type.Sliced;
        _0x8231a8f4.preserveAspect = false;
        _0x8231a8f4.pixelsPerUnitMultiplier = 2.6f;
        _0x56941319.Place(_0x8231a8f4.rectTransform, new Vector2(0.5f, 0.74f), new Vector2(330f, 0f), new Vector2(120f, 190f));
        TextMeshProUGUI _0x17c4e088 = _0x56941319.Label(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[16] { 234, 200, 223, 204, 211, 223, 205, 233, 202, 219, 200, 209, 238, 223, 194, 206 }, 186), _0xbbd9911f._0x319207cf(new byte[20] { 65, 66, 83, 64, 89, 24, 70, 83, 66, 50, 70, 90, 87, 50, 65, 87, 81, 70, 93, 64 }, 18), 38f, _0x821966c0.TextPrimary, this._art._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x17c4e088.rectTransform, new Vector2(0.5f, 0.40f), new Vector2(-330f, 0f), new Vector2(300f, 110f));
        TextMeshProUGUI _0x90a4bfd1 = _0x56941319.Label(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[15] { 169, 139, 156, 143, 144, 156, 142, 187, 156, 152, 148, 173, 156, 129, 141 }, 249), _0xbbd9911f._0x319207cf(new byte[20] { 127, 120, 124, 112, 55, 117, 114, 113, 121, 29, 105, 117, 120, 29, 110, 120, 126, 105, 114, 111 }, 61), 38f, _0x821966c0.TextPrimary, this._art._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x90a4bfd1.rectTransform, new Vector2(0.5f, 0.40f), new Vector2(330f, 0f), new Vector2(300f, 110f));
        Image _0xd73bc62f = _0x56941319.Picture(_0x74d8411a, _0xbbd9911f._0x319207cf(new byte[11] { 128, 162, 181, 166, 185, 181, 167, 130, 185, 190, 183 }, 208), this._art._0x3cc557a4, Color.white);
        _0x56941319.Place(_0xd73bc62f.rectTransform, new Vector2(0.5f, 0.21f), Vector2.zero, new Vector2(230f, 230f));
        _0xd73bc62f.rectTransform.localScale = Vector3.one * 0.62f;
        _0xd73bc62f.rectTransform.DOScale(1f, 0.99f).SetEase(Ease.OutSine).SetLoops(-1, LoopType.Restart);
    }

    private TextMeshProUGUI _0x76d61b39;
    private void _0x16f346ec()
    {
        if (this._0x9122873e != null)
        {
            DOTween.Kill(this._0x9122873e, true);
            this._0x9122873e.DOPunchScale(Vector3.one * 0.06f, 0.25f, 6, 0.6f);
        }
    }

    private TextMeshProUGUI _0xb33afe26;
    private void _0xe9879961()
    {
        if (_0x9ae3504d.Instance != null)
        {
            _0x9ae3504d.Instance._0xdb936680(_0x1fc44a94._0x517a5fb9.TUTORIAL0);
        }
    }

    private void _0xdbccfe15()
    {
        TextMeshProUGUI _0xd6e0da1c = _0x56941319.Label(this._0x595f9337, _0xbbd9911f._0x319207cf(new byte[13] { 221, 240, 248, 247, 241, 230, 251, 228, 247, 222, 251, 252, 247 }, 146), _0xbbd9911f._0x319207cf(new byte[45] { 52, 47, 34, 35, 70, 35, 48, 35, 52, 63, 70, 32, 42, 41, 41, 52, 70, 75, 70, 45, 35, 35, 54, 70, 50, 46, 35, 70, 37, 46, 39, 52, 33, 35, 70, 39, 36, 41, 48, 35, 70, 60, 35, 52, 41 }, 102), 38f, _0x821966c0.TextMuted, this._art._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0xd6e0da1c.rectTransform, new Vector2(0.5f, 0.105f), Vector2.zero, new Vector2(1140f, 64f));
    }

    // Rule C.25: the floor ladder and the card text own two x-bands that never meet.
    private const float GutterCentre = 347f; // card-local, card is 1060 wide
    private TextMeshProUGUI _0xea7fed40;
    private void _0x07c7167f()
    {
        Button _0xe0685056 = _0x56941319.TextButton(this._0x595f9337, _0xbbd9911f._0x319207cf(new byte[12] { 41, 15, 28, 30, 22, 14, 63, 8, 9, 9, 18, 19 }, 125), _0xbbd9911f._0x319207cf(new byte[6] { 205, 203, 216, 218, 210, 202 }, 153), new Vector2(0.5f, 0.185f), new Vector2(-280f, 0f), new Vector2(500f, 120f), _0x821966c0.Surface, _0x821966c0.Primary, _0x821966c0.TextPrimary, 48f, this._art._0x07271a7c, this._art._0x6cd35f3f);
        _0xe0685056.onClick.AddListener(() => this._0xfaaa3688());
        Button _0xa927cc62 = _0x56941319.TextButton(this._0x595f9337, _0xbbd9911f._0x319207cf(new byte[11] { 202, 237, 245, 214, 237, 192, 247, 246, 246, 237, 236 }, 130), _0xbbd9911f._0x319207cf(new byte[11] { 250, 253, 229, 146, 230, 253, 146, 226, 254, 243, 235 }, 178), new Vector2(0.5f, 0.185f), new Vector2(280f, 0f), new Vector2(500f, 120f), _0x821966c0.Surface, _0x821966c0.Primary, _0x821966c0.TextPrimary, 48f, this._art._0x07271a7c, this._art._0x6cd35f3f);
        _0xa927cc62.onClick.AddListener(() => this._0xe9879961());
    }

    // ---- construction -----------------------------------------------------------
    private void _0x5bc4463e()
    {
        for (int _0x390f10ee = 0; _0x390f10ee < 2; _0x390f10ee++)
        {
            float _0x1bb8288c = _0x390f10ee == 0 ? 0.027f : 0.973f;
            Image _0xefa5aa12 = _0x56941319.Picture(this._0x595f9337, _0xbbd9911f._0x319207cf(new byte[9] { 235, 208, 217, 222, 204, 234, 217, 209, 212 }, 184), this._art._0x931edd1b, _0x821966c0.Primary);
            _0xefa5aa12.type = Image.Type.Sliced;
            _0xefa5aa12.preserveAspect = false;
            _0xefa5aa12.pixelsPerUnitMultiplier = 2.2f;
            _0x56941319.Place(_0xefa5aa12.rectTransform, new Vector2(_0x1bb8288c, 0.5f), Vector2.zero, new Vector2(28f, 2560f));
            this._0x16f5ea48.Add(_0xefa5aa12);
            for (int _0x4fe64d76 = 0; _0x4fe64d76 < 3; _0x4fe64d76++)
            {
                Image _0x9fef05ce = _0x56941319.Plate(_0xefa5aa12.rectTransform, _0xbbd9911f._0x319207cf(new byte[9] { 212, 231, 239, 234, 213, 246, 231, 244, 237 }, 134), this._art._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Secondary, 0.85f), 4f);
                _0x56941319.Place(_0x9fef05ce.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, -120f), new Vector2(18f, 150f));
                _0x9fef05ce.rectTransform.DOAnchorPosY(2600f, 2.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Restart).SetDelay(_0x4fe64d76 * 0.8f + _0x390f10ee * 0.4f);
            }
        }
    }

    private Image _0x00f7093c;
    [SerializeField]
    private _0x18132870 _art;
    private RectTransform _0x9122873e;
    private TextMeshProUGUI _0x9ce4e53b;
    private Button _0xb8fb663c;
    private readonly List<Image> _0xcc8052a6 = new List<Image>();
    private void _0xfaaa3688()
    {
        if (this._0xa5ba9f2f != null)
        {
            this._0xa5ba9f2f._0x53430f0c();
        }
    }

    private RectTransform _0x300e8e82;
    private TextMeshProUGUI _0x174cc13c(RectTransform _0xdd9e5251, float _0xc713f05c, string _0x213371ac, Color _0xc482baa7)
    {
        RectTransform _0x826223b4 = _0xb51ece01.Card(_0xdd9e5251, this._art, new Vector2(0.5f, 0.5f), new Vector2(_0xc713f05c, 0f), new Vector2(520f, 118f), _0x821966c0.Alpha(_0xc482baa7, 0.55f));
        Image _0xd9c7f3eb = _0x56941319.Plate(_0x826223b4, _0xbbd9911f._0x319207cf(new byte[7] { 96, 71, 82, 71, 119, 92, 71 }, 51), this._art._0x07271a7c, _0xc482baa7, 1.6f);
        _0x56941319.Place(_0xd9c7f3eb.rectTransform, new Vector2(0f, 0.5f), new Vector2(34f, 0f), new Vector2(14f, 56f));
        TextMeshProUGUI _0xc13479d6 = _0x56941319.Label(_0x826223b4, _0xbbd9911f._0x319207cf(new byte[11] { 36, 3, 22, 3, 52, 22, 7, 3, 30, 24, 25 }, 119), _0x213371ac, 34f, _0x821966c0.TextMuted, this._art._0x6cd35f3f, TextAlignmentOptions.Left);
        _0x56941319.Place(_0xc13479d6.rectTransform, new Vector2(0f, 0.5f), new Vector2(190f, 30f), new Vector2(260f, 44f));
        TextMeshProUGUI _0xe7aa4e0c = _0x56941319.Label(_0x826223b4, _0xbbd9911f._0x319207cf(new byte[9] { 36, 3, 22, 3, 33, 22, 27, 2, 18 }, 119), _0xbbd9911f._0x319207cf(new byte[1] { 119 }, 71), 52f, _0xc482baa7, this._art._0x6cd35f3f, TextAlignmentOptions.Left);
        _0x56941319.Place(_0xe7aa4e0c.rectTransform, new Vector2(0f, 0.5f), new Vector2(250f, -22f), new Vector2(380f, 58f));
        return _0xe7aa4e0c;
    }

    // Rule G.3: the scene-loading button is the template's own; this game only gives it
    // a readable face (and a raycast target, which the template chrome does not have).
    // The load itself stays with the template driver - calling it here too would load twice.
    private void _0x34053f68(Transform _0xc6bce5ed)
    {
        this._0xb8fb663c = _0xb51ece01.FindSceneButton(_0xc6bce5ed, _0x1fc44a94._0x98dd0d5d.SCENE_1);
        if (this._0xb8fb663c == null)
        {
            return;
        }

        RectTransform _0xa33f34a9 = this._0xb8fb663c.GetComponent<RectTransform>();
        this._0x9122873e = _0x56941319.Node(_0xa33f34a9, _0xbbd9911f._0x319207cf(new byte[8] { 109, 81, 92, 68, 123, 92, 94, 88 }, 61));
        _0x56941319.Stretch(this._0x9122873e);
        Image _0x8b38cf2a = _0x56941319.Plate(this._0x9122873e, _0xbbd9911f._0x319207cf(new byte[7] { 180, 136, 133, 157, 182, 141, 137 }, 228), this._art._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Reward, 0.55f), 1.9f);
        _0x56941319.Stretch(_0x8b38cf2a.rectTransform);
        _0x8b38cf2a.rectTransform.offsetMin = new Vector2(-8f, -8f);
        _0x8b38cf2a.rectTransform.offsetMax = new Vector2(8f, 8f);
        Image _0x2fe16b98 = _0x56941319.Plate(this._0x9122873e, _0xbbd9911f._0x319207cf(new byte[8] { 77, 113, 124, 100, 95, 114, 121, 100 }, 29), this._art._0x07271a7c, _0x821966c0.Reward, 1.9f);
        _0x56941319.Stretch(_0x2fe16b98.rectTransform);
        _0x2fe16b98.raycastTarget = true;
        _0x2fe16b98.canvasRenderer.cullTransparentMesh = false;
        Image _0xfda3cf13 = _0x56941319.Plate(this._0x9122873e, _0xbbd9911f._0x319207cf(new byte[9] { 35, 31, 18, 10, 52, 31, 28, 0, 0 }, 115), this._art._0x07271a7c, new Color(1f, 1f, 1f, 0.16f), 2.4f);
        _0x56941319.Place(_0xfda3cf13.rectTransform, new Vector2(0.5f, 0.72f), Vector2.zero, new Vector2(680f, 52f));
        TextMeshProUGUI _0x39f40b38 = _0x56941319.Label(this._0x9122873e, _0xbbd9911f._0x319207cf(new byte[9] { 153, 165, 168, 176, 133, 168, 171, 172, 165 }, 201), _0xbbd9911f._0x319207cf(new byte[4] { 38, 58, 55, 47 }, 118), 64f, _0x821966c0.Deep, this._art._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Stretch(_0x39f40b38.rectTransform);
        this._0xb8fb663c.targetGraphic = _0x2fe16b98;
        this._0xb8fb663c.onClick.AddListener(() => this._0x16f346ec());
    }

    private readonly List<Image> _0x16f5ea48 = new List<Image>();
    private void _0x349cbb0b()
    {
        if (this._0x595f9337 != null)
        {
            CanvasGroup _0x0f7859aa = _0x56941319.Group(this._0x595f9337);
            _0x0f7859aa.alpha = 0f;
            _0x0f7859aa.DOFade(1f, 0.35f).SetEase(Ease.OutCubic);
        }

        if (this._0x9122873e != null)
        {
            this._0x9122873e.localScale = Vector3.one * 0.8f;
            this._0x9122873e.DOScale(1f, 0.4f).SetEase(Ease.OutBack).SetDelay(0.12f);
        }
    }

    public _0x18132870 _0x2467a6c3
    {
        get
        {
            return this._art;
        }
    }

    private const float TextWidth = 800f; // right edge -125+400 = 275, gutter starts 323
    private RectTransform _0x8b8c226c;
}

internal static class _0xbbd9911f
{
    internal static string _0x319207cf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}