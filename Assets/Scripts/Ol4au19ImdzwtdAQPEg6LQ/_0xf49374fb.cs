using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The ascent picker. It is a sheet INSIDE the menu scene, not a scene of its own - PLAY
// always goes straight into the game with whatever is currently selected, so nothing
// can trap a player (or a capture run) on an intermediate screen.
//
// Rule C.7: a tap here changes the whole frame, not a word. The selection marker moves,
// the card punches, the menu rails and track card repaint in the new accent, and a toast
// states what was picked.
public sealed class _0xf49374fb : MonoBehaviour
{
    // Rule C.25: the per-row ladder gutter and the row text own two x-bands that never
    // overlap. Row body is 1020 wide, so local x runs -510..+510.
    private const float RowGutterCentre = 335f;
    private _0x2237d6b4 _0x3baf3846;
    private void _0x158de3f9()
    {
        int _0x4c31693a = _0x7a953d7d._0x10895542;
        for (int _0xe58c2d5d = 0; _0xe58c2d5d < this._0x9ca24fe1.Count; _0xe58c2d5d++)
        {
            Image _0xabb04a27 = this._0x9ca24fe1[_0xe58c2d5d];
            if (_0xabb04a27 == null)
            {
                continue;
            }

            bool _0x4d1d6b5c = _0xe58c2d5d == _0x4c31693a;
            _0xabb04a27.color = _0x821966c0.Alpha(_0x821966c0.Reward, _0x4d1d6b5c ? 1f : 0f);
            if (_0xe58c2d5d < this._0x1b4db90b.Count && this._0x1b4db90b[_0xe58c2d5d] != null)
            {
                Color _0x871dabfd = _0x7a953d7d.IsUnlocked(_0xe58c2d5d) ? _0x821966c0.TrackAccent(_0xe58c2d5d) : _0x821966c0.Raised;
                this._0x1b4db90b[_0xe58c2d5d].color = _0x821966c0.Alpha(_0x4d1d6b5c ? _0x821966c0.Reward : _0x871dabfd, _0x4d1d6b5c ? 1f : 0.9f);
            }
        }
    }

    private void _0x57ee955d()
    {
        GameObject _0xd30f8b1a = new GameObject(_0xf166f93a._0x1423cd9d(new byte[10] { 196, 255, 242, 242, 227, 212, 251, 248, 228, 242 }, 151), typeof(RectTransform));
        RectTransform _0xa4ffab33 = _0xd30f8b1a.GetComponent<RectTransform>();
        _0xa4ffab33.SetParent(this._0xa50abdf9, false);
        _0x56941319.Place(_0xa4ffab33, new Vector2(1f, 1f), new Vector2(-82f, -82f), new Vector2(116f, 116f));
        Image _0x92aa5b2b = _0x56941319.Plate(_0xa4ffab33, _0xf166f93a._0x1423cd9d(new byte[14] { 192, 251, 246, 246, 231, 208, 255, 252, 224, 246, 209, 252, 247, 234 }, 147), this._0xc7a49b96._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Raised, 0.95f), 2.6f);
        _0x56941319.Stretch(_0x92aa5b2b.rectTransform);
        _0x92aa5b2b.raycastTarget = true;
        // The template's own close glyph has no sprite assigned; this one is ours, so the
        // corner never ships as a white square.
        Image _0xf56dc0ab = _0x56941319.Picture(_0xa4ffab33, _0xf166f93a._0x1423cd9d(new byte[15] { 117, 78, 67, 67, 82, 101, 74, 73, 85, 67, 97, 74, 95, 86, 78 }, 38), this._0xc7a49b96._0x04ec54a3, _0x821966c0.TextPrimary);
        _0x56941319.Stretch(_0xf56dc0ab.rectTransform);
        _0xf56dc0ab.rectTransform.offsetMin = new Vector2(26f, 26f);
        _0xf56dc0ab.rectTransform.offsetMax = new Vector2(-26f, -26f);
        Button _0xc5d0680d = _0xd30f8b1a.AddComponent<Button>();
        _0xc5d0680d.targetGraphic = _0x92aa5b2b;
        _0xc5d0680d.onClick.AddListener(() => this._0x82cf156c());
    }

    private CanvasGroup _0xa49901b8;
    private const float RowTextWidth = 720f;
    public void _0x690bd584(_0x18132870 _0x0af2bef8, _0x2237d6b4 _0x0f1917c1)
    {
        this._0xc7a49b96 = _0x0af2bef8;
        this._0x3baf3846 = _0x0f1917c1;
        this._0xc6550b34();
    }

    private void _0xb1c894f8(int _0x5d7b142b)
    {
        if (!this._0xd6eae099)
        {
            return;
        }

        if (_0x5d7b142b < 0 || _0x5d7b142b >= this._0xfaa45ea8.Count)
        {
            return;
        }

        RectTransform _0xdaa64d68 = this._0xfaa45ea8[_0x5d7b142b];
        if (!_0x7a953d7d.IsUnlocked(_0x5d7b142b))
        {
            DOTween.Kill(_0xdaa64d68, true);
            _0xdaa64d68.DOShakeAnchorPos(0.3f, 14f, 12, 90f);
            this._0x0a38040c(_0xf166f93a._0x1423cd9d(new byte[22] { 125, 126, 114, 122, 116, 117, 17, 28, 17, 114, 125, 116, 112, 99, 17, 101, 99, 112, 114, 122, 17, 1 }, 49) + _0x5d7b142b + _0xf166f93a._0x1423cd9d(new byte[6] { 216, 190, 177, 170, 171, 172 }, 248));
            return;
        }

        _0x7a953d7d._0x10895542 = _0x5d7b142b;
        DOTween.Kill(_0xdaa64d68, true);
        _0xdaa64d68.DOPunchScale(Vector3.one * 0.06f, 0.25f, 6, 0.6f);
        this._0x158de3f9();
        this._0x0a38040c(_0xf166f93a._0x1423cd9d(new byte[7] { 21, 19, 0, 2, 10, 97, 113 }, 65) + (_0x5d7b142b + 1) + _0xf166f93a._0x1423cd9d(new byte[3] { 161, 172, 161 }, 129) + _0x7a953d7d.Row(_0x5d7b142b)._0xf6be4951 + _0xf166f93a._0x1423cd9d(new byte[9] { 170, 217, 207, 198, 207, 201, 222, 207, 206 }, 138));
        if (this._0x3baf3846 != null)
        {
            this._0x3baf3846._0x40726756();
        }
    }

    private const float RowTextCentre = -100f;
    private RectTransform _0x6aa99a96;
    private void _0xc6550b34()
    {
        RectTransform _0x054ce933 = this.GetComponent<RectTransform>();
        _0x56941319.Stretch(_0x054ce933);
        this._0xa49901b8 = _0x56941319.Group(_0x054ce933);
        // The shade is a close control of its own: a tap that misses the corner glyph
        // must still be able to leave, or the sheet parks over PLAY for good.
        Image _0x6e70681b = _0x56941319.Plate(_0x054ce933, _0xf166f93a._0x1423cd9d(new byte[10] { 95, 100, 105, 105, 120, 95, 100, 109, 104, 105 }, 12), this._0xc7a49b96._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Deep, 0.82f), 1f);
        _0x56941319.Stretch(_0x6e70681b.rectTransform);
        _0x6e70681b.raycastTarget = true;
        _0x6e70681b.canvasRenderer.cullTransparentMesh = false;
        Button _0xfac2cf49 = _0x6e70681b.gameObject.AddComponent<Button>();
        _0xfac2cf49.transition = Selectable.Transition.None;
        _0xfac2cf49.targetGraphic = _0x6e70681b;
        _0xfac2cf49.onClick.AddListener(() => this._0x82cf156c());
        this._0xa50abdf9 = _0xb51ece01.Card(_0x054ce933, this._0xc7a49b96, new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1120f, 1580f), _0x821966c0.Alpha(_0x821966c0.Primary, 0.95f));
        Image _0x7892acdd = this._0xa50abdf9.GetComponent<Image>();
        if (_0x7892acdd != null)
        {
            _0x7892acdd.raycastTarget = true;
        }

        TextMeshProUGUI _0x05c03e51 = _0x56941319.Label(this._0xa50abdf9, _0xf166f93a._0x1423cd9d(new byte[10] { 124, 71, 74, 74, 91, 123, 70, 91, 67, 74 }, 47), _0xf166f93a._0x1423cd9d(new byte[16] { 143, 153, 144, 153, 159, 136, 252, 157, 146, 252, 157, 143, 159, 153, 146, 136 }, 220), 64f, _0x821966c0.TextPrimary, this._0xc7a49b96._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x05c03e51.rectTransform, new Vector2(0.5f, 0.935f), Vector2.zero, new Vector2(820f, 96f));
        this._0x57ee955d();
        this._0xecf87f04();
        this._0xd7876086();
    }

    private void _0x89975c1a(RectTransform _0xa07b8bda, int _0x3c67b630, Color _0x7c4543f4)
    {
        RectTransform _0x1c59c089 = _0x56941319.Node(_0xa07b8bda, _0xf166f93a._0x1423cd9d(new byte[9] { 8, 53, 45, 22, 59, 62, 62, 63, 40 }, 90));
        _0x56941319.Place(_0x1c59c089, new Vector2(0.5f, 0.5f), new Vector2(RowGutterCentre, 0f), new Vector2(RowGutterWidth, 212f));
        float _0x8e9e1a1c = 212f / Mathf.Max(1, _0x3c67b630);
        float height = Mathf.Max(4f, _0x8e9e1a1c * 0.62f);
        for (int _0xf3a226f0 = 0; _0xf3a226f0 < _0x3c67b630; _0xf3a226f0++)
        {
            Image _0xac350d7c = _0x56941319.Plate(_0x1c59c089, _0xf166f93a._0x1423cd9d(new byte[13] { 142, 179, 171, 144, 189, 184, 184, 185, 174, 143, 168, 185, 172 }, 220), this._0xc7a49b96._0x07271a7c, _0x821966c0.Alpha(_0x7c4543f4, _0xf3a226f0 % 4 == 0 ? 0.95f : 0.4f), 4f);
            _0x56941319.Place(_0xac350d7c.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(0f, -106f + _0x8e9e1a1c * (_0xf3a226f0 + 0.5f)), new Vector2(RowGutterWidth - 10f, height));
        }
    }

    private void _0x0a38040c(string _0xa4dc18d4)
    {
        if (this._0x6aa99a96 == null || this._0xfaef3213 == null)
        {
            return;
        }

        this._0xfaef3213.text = _0xa4dc18d4;
        CanvasGroup _0x46621fdc = _0x56941319.Group(this._0x6aa99a96);
        DOTween.Kill(_0x46621fdc, true);
        _0x46621fdc.alpha = 0f;
        Sequence _0xa6e461e9 = DOTween.Sequence();
        _0xa6e461e9.Append(_0x46621fdc.DOFade(1f, 0.18f));
        _0xa6e461e9.AppendInterval(_0xd04e59fe.ToastSeconds);
        _0xa6e461e9.Append(_0x46621fdc.DOFade(0f, 0.25f));
    }

    private const float RowGutterWidth = 48f;
    private bool _0xd6eae099;
    private void _0xd7876086()
    {
        this._0x6aa99a96 = _0x56941319.Node(this._0xa50abdf9, _0xf166f93a._0x1423cd9d(new byte[10] { 234, 209, 220, 220, 205, 237, 214, 216, 202, 205 }, 185));
        _0x56941319.Place(this._0x6aa99a96, new Vector2(0.5f, 0.11f), Vector2.zero, new Vector2(920f, 104f));
        Image _0x51f58883 = _0x56941319.Plate(this._0x6aa99a96, _0xf166f93a._0x1423cd9d(new byte[13] { 28, 39, 42, 42, 59, 27, 32, 46, 60, 59, 13, 46, 61 }, 79), this._0xc7a49b96._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Raised, 0.95f), 2.2f);
        _0x56941319.Stretch(_0x51f58883.rectTransform);
        this._0xfaef3213 = _0x56941319.Label(this._0x6aa99a96, _0xf166f93a._0x1423cd9d(new byte[14] { 252, 199, 202, 202, 219, 251, 192, 206, 220, 219, 251, 202, 215, 219 }, 175), "", 40f, _0x821966c0.TextPrimary, this._0xc7a49b96._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Stretch(this._0xfaef3213.rectTransform);
        _0x56941319.Group(this._0x6aa99a96).alpha = 0f;
    }

    // ---- behaviour --------------------------------------------------------------
    public void _0x53430f0c()
    {
        this._0xd6eae099 = true;
        this.gameObject.SetActive(true);
        this._0x158de3f9();
        if (this._0xa49901b8 != null)
        {
            this._0xa49901b8.alpha = 0f;
            this._0xa49901b8.blocksRaycasts = true;
            this._0xa49901b8.DOFade(1f, 0.25f);
        }

        if (this._0xa50abdf9 != null)
        {
            this._0xa50abdf9.localScale = Vector3.one * 0.88f;
            this._0xa50abdf9.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
        }
    }

    private RectTransform _0xa50abdf9;
    private readonly List<RectTransform> _0xfaa45ea8 = new List<RectTransform>();
    private _0x18132870 _0xc7a49b96;
    private void _0xecf87f04()
    {
        float[] _0xd3d0542c =
        {
            0.735f,
            0.545f,
            0.355f
        };
        if (_0x7a953d7d._0x60b01583 <= 0)
        {
            TextMeshProUGUI _0xad9cfe74 = _0x56941319.Label(this._0xa50abdf9, _0xf166f93a._0x1423cd9d(new byte[10] { 104, 83, 94, 94, 79, 126, 86, 75, 79, 66 }, 59), _0xf166f93a._0x1423cd9d(new byte[43] { 95, 94, 69, 89, 88, 95, 86, 49, 68, 95, 93, 94, 82, 90, 84, 85, 49, 72, 84, 69, 27, 65, 93, 80, 72, 49, 69, 94, 49, 94, 65, 84, 95, 49, 80, 95, 49, 80, 66, 82, 84, 95, 69 }, 17), 46f, _0x821966c0.TextMuted, this._0xc7a49b96._0x6cd35f3f, TextAlignmentOptions.Center);
            _0x56941319.Place(_0xad9cfe74.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 240f));
            return;
        }

        for (int _0x4ecf6c6a = 0; _0x4ecf6c6a < _0x7a953d7d._0x60b01583 && _0x4ecf6c6a < _0xd3d0542c.Length; _0x4ecf6c6a++)
        {
            _0x1729546e _0xc57363d9 = _0x7a953d7d.Row(_0x4ecf6c6a);
            bool _0xdba2c3f2 = _0x7a953d7d.IsUnlocked(_0x4ecf6c6a);
            Color _0xcbf28e9a = _0x821966c0.TrackAccent(_0x4ecf6c6a);
            Image _0xd5d3eb7b;
            RectTransform _0x7eda6900 = _0xb51ece01.Card(this._0xa50abdf9, this._0xc7a49b96, new Vector2(0.5f, _0xd3d0542c[_0x4ecf6c6a]), Vector2.zero, new Vector2(1020f, 280f), _0x821966c0.Alpha(_0xdba2c3f2 ? _0xcbf28e9a : _0x821966c0.Raised, 0.9f), out _0xd5d3eb7b);
            this._0xfaa45ea8.Add(_0x7eda6900);
            this._0x1b4db90b.Add(_0xd5d3eb7b);
            Image _0xaa7ecd1a = _0x7eda6900.GetComponent<Image>();
            if (_0xaa7ecd1a != null)
            {
                _0xaa7ecd1a.raycastTarget = true;
                _0xaa7ecd1a.color = _0xdba2c3f2 ? _0x821966c0.Alpha(_0x821966c0.Surface, 0.97f) : _0x821966c0.Alpha(_0x821966c0.Deep, 0.92f);
            }

            Image _0x83c56eb8 = _0x56941319.Plate(_0x7eda6900, _0xf166f93a._0x1423cd9d(new byte[9] { 193, 252, 228, 222, 242, 225, 248, 246, 225 }, 147), this._0xc7a49b96._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Reward, 0f), 3f);
            _0x56941319.Place(_0x83c56eb8.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(-492f, 0f), new Vector2(10f, 220f));
            this._0x9ca24fe1.Add(_0x83c56eb8);
            TextMeshProUGUI _0x57fbf45e = _0x56941319.Label(_0x7eda6900, _0xf166f93a._0x1423cd9d(new byte[8] { 156, 161, 185, 154, 167, 186, 162, 171 }, 206), _0xf166f93a._0x1423cd9d(new byte[7] { 253, 251, 232, 234, 226, 137, 153 }, 169) + (_0x4ecf6c6a + 1) + _0xf166f93a._0x1423cd9d(new byte[3] { 42, 39, 42 }, 10) + _0xc57363d9._0xf6be4951, 52f, _0xdba2c3f2 ? _0x821966c0.TextPrimary : _0x821966c0.TextMuted, this._0xc7a49b96._0x6cd35f3f, TextAlignmentOptions.Left);
            _0x56941319.Place(_0x57fbf45e.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(RowTextCentre, 74f), new Vector2(RowTextWidth, 64f));
            TextMeshProUGUI _0xe858df5e = _0x56941319.Label(_0x7eda6900, _0xf166f93a._0x1423cd9d(new byte[7] { 223, 226, 250, 192, 232, 249, 236 }, 141), _0xc57363d9._0x78386416 + _0xf166f93a._0x1423cd9d(new byte[7] { 208, 178, 160, 189, 208, 223, 208 }, 240) + _0xc57363d9._0xe6815054 + _0xf166f93a._0x1423cd9d(new byte[10] { 180, 210, 216, 219, 219, 198, 199, 180, 187, 180 }, 148) + _0xc57363d9._0x0af37c7a + _0xf166f93a._0x1423cd9d(new byte[7] { 64, 48, 53, 44, 51, 37, 51 }, 96), 40f, _0xdba2c3f2 ? _0xcbf28e9a : _0x821966c0.TextMuted, this._0xc7a49b96._0x6cd35f3f, TextAlignmentOptions.Left);
            _0x56941319.Place(_0xe858df5e.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(RowTextCentre, 6f), new Vector2(RowTextWidth, 54f));
            string _0x58280579 = _0xdba2c3f2 ? _0xf166f93a._0x1423cd9d(new byte[5] { 182, 177, 167, 160, 212 }, 244) + _0x7a953d7d.BestAccuracy(_0x4ecf6c6a) + _0xf166f93a._0x1423cd9d(new byte[16] { 151, 146, 159, 146, 241, 254, 247, 243, 224, 146, 243, 230, 146, 138, 135, 151 }, 178) : _0xf166f93a._0x1423cd9d(new byte[34] { 205, 206, 194, 202, 196, 197, 161, 172, 161, 194, 205, 196, 192, 211, 161, 213, 201, 196, 161, 209, 211, 196, 215, 200, 206, 212, 210, 161, 192, 210, 194, 196, 207, 213 }, 129);
            TextMeshProUGUI _0xed549cd3 = _0x56941319.Label(_0x7eda6900, _0xf166f93a._0x1423cd9d(new byte[8] { 91, 102, 126, 90, 125, 104, 125, 108 }, 9), _0x58280579, 36f, _0xdba2c3f2 ? _0x821966c0.TextMuted : _0x821966c0.DangerText, this._0xc7a49b96._0x6cd35f3f, TextAlignmentOptions.Left);
            _0x56941319.Place(_0xed549cd3.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(RowTextCentre, -66f), new Vector2(RowTextWidth, 48f));
            this._0x89975c1a(_0x7eda6900, _0xc57363d9._0xe6815054, _0xdba2c3f2 ? _0xcbf28e9a : _0x821966c0.Raised);
            Button _0xc0d93fbf = _0x7eda6900.gameObject.AddComponent<Button>();
            _0xc0d93fbf.transition = Selectable.Transition.None;
            _0xc0d93fbf.targetGraphic = _0xaa7ecd1a;
            int _0xd4ad3262 = _0x4ecf6c6a;
            _0xc0d93fbf.onClick.AddListener(() => this._0xb1c894f8(_0xd4ad3262));
        }
    }

    private readonly List<Image> _0x1b4db90b = new List<Image>();
    private readonly List<Image> _0x9ca24fe1 = new List<Image>();
    private TextMeshProUGUI _0xfaef3213;
    public void _0x82cf156c()
    {
        this._0xd6eae099 = false;
        if (this._0xa49901b8 != null)
        {
            this._0xa49901b8.blocksRaycasts = false;
        }

        this.gameObject.SetActive(false);
    }
}

internal static class _0xf166f93a
{
    internal static string _0x1423cd9d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}