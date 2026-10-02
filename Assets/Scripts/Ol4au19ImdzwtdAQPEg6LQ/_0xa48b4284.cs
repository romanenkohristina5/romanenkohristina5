using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Rule C.3: the three result cards are rebuilt from scratch, not relabelled. Every
// template child of a pop body is switched off and this game's own card goes in its
// place, so no leftover "Score:" row and no missing-sprite close square can ship.
// Rule C.17: every button that does something carries its OWN caption.
public sealed class _0xa48b4284 : MonoBehaviour
{
    private _0x2451f585 _0xc47ab49b;
    private int _0x384d1c04;
    // ---- the three cards --------------------------------------------------------
    public void _0x6dff3d3a(int _0x5875f5cd, int _0xd48f3e90, int _0xd41324b0, int _0xf70c1712, string _0x02836489)
    {
        _0x3e70f2cb _0x86995de3 = _0x0e2f9237.Instance != null ? _0x0e2f9237.Instance._0x309bc0c4(_0x1fc44a94._0xac09a5ba.WIN) : null;
        if (_0x86995de3 == null)
        {
            return;
        }

        RectTransform _0xf9b8792a = this.Dress(_0x86995de3, _0xe8656ce7._0x4a0fff54(new byte[20] { 240, 235, 244, 132, 244, 232, 229, 240, 226, 235, 246, 233, 132, 246, 225, 229, 231, 236, 225, 224 }, 164), _0x821966c0.Reward, _0xe8656ce7._0x4a0fff54(new byte[9] { 117, 119, 119, 97, 102, 117, 119, 109, 20 }, 52) + _0x5875f5cd + _0xe8656ce7._0x4a0fff54(new byte[9] { 178, 157, 209, 219, 216, 216, 197, 196, 183 }, 151) + _0xd48f3e90 + _0xe8656ce7._0x4a0fff54(new byte[3] { 156, 147, 156 }, 188) + _0xd41324b0 + _0xe8656ce7._0x4a0fff54(new byte[9] { 42, 99, 104, 97, 114, 103, 101, 0, 11 }, 32) + _0xd04e59fe.Grouped(_0xf70c1712), _0xe8656ce7._0x4a0fff54(new byte[6] { 228, 247, 248, 253, 150, 150 }, 182) + _0x02836489, this._0x15c3f7e1._0x59cf4f2c, Color.white);
        bool _0x60f2d961 = _0x7a953d7d._0x10895542 + 1 < _0x7a953d7d._0x60b01583;
        if (_0x60f2d961)
        {
            this._0xb89fb142(_0xf9b8792a, -330f, _0xe8656ce7._0x4a0fff54(new byte[10] { 12, 7, 26, 22, 98, 22, 16, 3, 1, 9 }, 66), _0x821966c0.Reward, 2);
            this._0xb89fb142(_0xf9b8792a, 0f, _0xe8656ce7._0x4a0fff54(new byte[6] { 192, 215, 194, 222, 211, 203 }, 146), _0x821966c0.Primary, 1);
            this._0xb89fb142(_0xf9b8792a, 330f, _0xe8656ce7._0x4a0fff54(new byte[4] { 142, 134, 141, 150 }, 195), _0x821966c0.Raised, 0);
        }
        else
        {
            this._0xb89fb142(_0xf9b8792a, -180f, _0xe8656ce7._0x4a0fff54(new byte[6] { 210, 197, 208, 204, 193, 217 }, 128), _0x821966c0.Primary, 1);
            this._0xb89fb142(_0xf9b8792a, 180f, _0xe8656ce7._0x4a0fff54(new byte[4] { 18, 26, 17, 10 }, 95), _0x821966c0.Raised, 0);
        }

        _0x0e2f9237.Instance._0xa4c53cf2(_0x1fc44a94._0xac09a5ba.WIN);
    }

    public void _0x18ed1fbe(int _0x2c5a1d66, int _0x7e56b8fc, int _0xe523abdf, int _0x229ea0ad)
    {
        _0x3e70f2cb _0x17811d82 = _0x0e2f9237.Instance != null ? _0x0e2f9237.Instance._0x309bc0c4(_0x1fc44a94._0xac09a5ba.PAUSE) : null;
        if (_0x17811d82 == null)
        {
            return;
        }

        RectTransform _0x890b39f3 = this.Dress(_0x17811d82, _0xe8656ce7._0x4a0fff54(new byte[13] { 53, 50, 49, 57, 93, 45, 50, 46, 52, 41, 52, 50, 51 }, 125), _0x821966c0.Secondary, _0xe8656ce7._0x4a0fff54(new byte[6] { 44, 38, 37, 37, 56, 74 }, 106) + _0x2c5a1d66 + _0xe8656ce7._0x4a0fff54(new byte[3] { 166, 169, 166 }, 134) + _0x7e56b8fc + _0xe8656ce7._0x4a0fff54(new byte[10] { 68, 15, 13, 13, 27, 28, 15, 13, 23, 110 }, 78) + _0xe523abdf + _0xe8656ce7._0x4a0fff54(new byte[1] { 129 }, 164), _0xe8656ce7._0x4a0fff54(new byte[11] { 175, 168, 172, 160, 190, 205, 165, 168, 161, 169, 205 }, 237) + _0x229ea0ad, this._0x15c3f7e1._0xaa03cc84, Color.white);
        this._0xb89fb142(_0x890b39f3, -330f, _0xe8656ce7._0x4a0fff54(new byte[6] { 57, 46, 56, 62, 38, 46 }, 107), _0x821966c0.Secondary, 3);
        this._0xb89fb142(_0x890b39f3, 0f, _0xe8656ce7._0x4a0fff54(new byte[7] { 112, 103, 113, 118, 99, 112, 118 }, 34), _0x821966c0.Primary, 1);
        this._0xb89fb142(_0x890b39f3, 330f, _0xe8656ce7._0x4a0fff54(new byte[4] { 135, 143, 132, 159 }, 202), _0x821966c0.Raised, 0);
        this._0x2d9bad0c = true;
        this._0x384d1c04++;
        int _0x2aa671c1 = this._0x384d1c04;
        _0x0e2f9237.Instance._0xa4c53cf2(_0x1fc44a94._0xac09a5ba.PAUSE);
        // A pause with no backstop parks the whole run if the RESUME tap ever misses.
        DOVirtual.DelayedCall(_0xd04e59fe.PauseAutoResumeSeconds, () => this._0xa9c3dc2d(_0x2aa671c1));
    }

    // kind: 0 menu, 1 restart this track, 2 next track, 3 resume.
    private void _0xb89fb142(RectTransform _0x7d4e0f04, float _0x45fc44f1, string _0x302193fd, Color _0x16f5ba61, int _0x11592c47)
    {
        if (_0x7d4e0f04 == null)
        {
            return;
        }

        float width = Mathf.Abs(_0x45fc44f1) > 1f ? 300f : 460f;
        Button _0x31648e3e = _0x56941319.TextButton(_0x7d4e0f04, _0xe8656ce7._0x4a0fff54(new byte[12] { 207, 248, 238, 232, 241, 233, 220, 254, 233, 244, 242, 243 }, 157), _0x302193fd, new Vector2(0.5f, 0.095f), new Vector2(_0x45fc44f1, 0f), new Vector2(width, 128f), _0x821966c0.Surface, _0x16f5ba61, _0x821966c0.TextPrimary, 48f, this._0x15c3f7e1._0x07271a7c, this._0x15c3f7e1._0x6cd35f3f);
        int _0x9f649523 = _0x11592c47;
        _0x31648e3e.onClick.AddListener(() => this._0x885c9f90(_0x9f649523));
    }

    private void _0xa9c3dc2d(int _0x71ac0973)
    {
        if (!this._0x2d9bad0c || _0x71ac0973 != this._0x384d1c04)
        {
            return;
        }

        this._0x885c9f90(3);
    }

    private _0x18132870 _0x15c3f7e1;
    public bool _0x5a2b2bcf
    {
        get
        {
            return this._0x2d9bad0c;
        }
    }

    public void _0xcf9bd033(bool _0x61455c5b, int _0x36725350, int _0x9760d059, int _0x926ffcf8)
    {
        _0x3e70f2cb _0xf1bff6d4 = _0x0e2f9237.Instance != null ? _0x0e2f9237.Instance._0x309bc0c4(_0x1fc44a94._0xac09a5ba.LOSE) : null;
        if (_0xf1bff6d4 == null)
        {
            return;
        }

        string _0x4d81ce52 = _0x61455c5b ? _0xe8656ce7._0x4a0fff54(new byte[13] { 165, 186, 162, 176, 167, 213, 177, 167, 180, 188, 187, 176, 177 }, 245) : _0xe8656ce7._0x4a0fff54(new byte[14] { 199, 213, 197, 195, 200, 210, 166, 213, 210, 199, 202, 202, 195, 194 }, 134);
        string _0x42b13ed0 = _0x61455c5b ? _0xe8656ce7._0x4a0fff54(new byte[20] { 142, 146, 159, 250, 136, 159, 137, 159, 136, 140, 159, 250, 146, 147, 142, 250, 128, 159, 136, 149 }, 218) : _0xe8656ce7._0x4a0fff54(new byte[7] { 198, 205, 205, 204, 205, 204, 168 }, 136) + (int)_0xd04e59fe.ClearAccuracy + _0xe8656ce7._0x4a0fff54(new byte[10] { 84, 81, 37, 62, 81, 50, 61, 52, 48, 35 }, 113);
        RectTransform _0x655eff60 = this.Dress(_0xf1bff6d4, _0x4d81ce52, _0x821966c0.DangerText, _0xe8656ce7._0x4a0fff54(new byte[9] { 195, 193, 193, 215, 208, 195, 193, 219, 162 }, 130) + _0x36725350 + _0xe8656ce7._0x4a0fff54(new byte[9] { 21, 58, 118, 124, 127, 127, 98, 99, 16 }, 48) + _0x9760d059 + _0xe8656ce7._0x4a0fff54(new byte[3] { 251, 244, 251 }, 219) + _0x926ffcf8, _0x42b13ed0, this._0x15c3f7e1._0x59cf4f2c, _0x821966c0.Alpha(_0x821966c0.DangerFill, 0.8f));
        this._0xb89fb142(_0x655eff60, -180f, _0xe8656ce7._0x4a0fff54(new byte[5] { 244, 227, 242, 244, 255 }, 166), _0x821966c0.Primary, 1);
        this._0xb89fb142(_0x655eff60, 180f, _0xe8656ce7._0x4a0fff54(new byte[4] { 234, 226, 233, 242 }, 167), _0x821966c0.Raised, 0);
        _0x0e2f9237.Instance._0xa4c53cf2(_0x1fc44a94._0xac09a5ba.LOSE);
    }

    public void _0xa94e17ea(_0x18132870 _0x7923130e, _0x2451f585 _0x4bae3337)
    {
        this._0x15c3f7e1 = _0x7923130e;
        this._0xc47ab49b = _0x4bae3337;
    }

    // ---- card construction ------------------------------------------------------
    private RectTransform Dress(_0x3e70f2cb _0x7f29d350, string _0xc1de9849, Color _0x6a4b4c52, string _0xcf490d1a, string _0x503b59ef, Sprite _0xda8c5c44, Color _0x0b967b64)
    {
        Transform _0x4a6985a8 = _0x7f29d350.Content != null ? _0x7f29d350.Content.transform : null;
        if (_0x4a6985a8 == null)
        {
            return null;
        }

        for (int _0xad23d2e7 = _0x4a6985a8.childCount - 1; _0xad23d2e7 >= 0; _0xad23d2e7--)
        {
            _0x4a6985a8.GetChild(_0xad23d2e7).gameObject.SetActive(false);
        }

        RectTransform _0x6d74d36a = _0x56941319.Node(_0x4a6985a8, _0xe8656ce7._0x4a0fff54(new byte[15] { 159, 164, 173, 170, 184, 158, 169, 191, 185, 160, 184, 143, 173, 190, 168 }, 204));
        RectTransform _0x5a3df4e3 = _0xb51ece01.Card(_0x6d74d36a, this._0x15c3f7e1, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1060f, 1300f), _0x821966c0.Alpha(_0x821966c0.Primary, 0.95f));
        TextMeshProUGUI _0x3915ce12 = _0x56941319.Label(_0x5a3df4e3, _0xe8656ce7._0x4a0fff54(new byte[11] { 185, 142, 152, 158, 135, 159, 191, 130, 159, 135, 142 }, 235), _0xc1de9849, 96f, _0x6a4b4c52, this._0x15c3f7e1._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x3915ce12.rectTransform, new Vector2(0.5f, 0.87f), Vector2.zero, new Vector2(960f, 150f));
        Image _0xaac13af7 = _0x56941319.Picture(_0x5a3df4e3, _0xe8656ce7._0x4a0fff54(new byte[12] { 160, 151, 129, 135, 158, 134, 180, 155, 149, 135, 128, 151 }, 242), _0xda8c5c44, _0x0b967b64);
        _0x56941319.Place(_0xaac13af7.rectTransform, new Vector2(0.5f, 0.655f), Vector2.zero, new Vector2(320f, 320f));
        TextMeshProUGUI _0x8ca2dc0a = _0x56941319.Label(_0x5a3df4e3, _0xe8656ce7._0x4a0fff54(new byte[11] { 23, 32, 54, 48, 41, 49, 9, 44, 43, 32, 54 }, 69), _0xcf490d1a, 56f, _0x821966c0.TextPrimary, this._0x15c3f7e1._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x8ca2dc0a.rectTransform, new Vector2(0.5f, 0.41f), Vector2.zero, new Vector2(960f, 260f));
        TextMeshProUGUI _0xe5d7c53f = _0x56941319.Label(_0x5a3df4e3, _0xe8656ce7._0x4a0fff54(new byte[10] { 188, 139, 157, 155, 130, 154, 160, 129, 154, 139 }, 238), _0x503b59ef, 48f, _0x821966c0.TextMuted, this._0x15c3f7e1._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0xe5d7c53f.rectTransform, new Vector2(0.5f, 0.245f), Vector2.zero, new Vector2(960f, 70f));
        _0x5a3df4e3.localScale = Vector3.one * 0.85f;
        _0x5a3df4e3.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
        return _0x5a3df4e3;
    }

    private bool _0x2d9bad0c;
    private void _0x885c9f90(int _0x64cf088a)
    {
        if (_0x64cf088a == 3)
        {
            this._0x384d1c04++;
            this._0x2d9bad0c = false;
            if (_0x0e2f9237.Instance != null)
            {
                _0x0e2f9237.Instance._0x60ef6ae8();
            }

            if (this._0xc47ab49b != null)
            {
                this._0xc47ab49b._0xb2284ae5();
            }

            return;
        }

        if (_0x64cf088a == 2)
        {
            _0x7a953d7d._0x10895542 = Mathf.Min(_0x7a953d7d._0x10895542 + 1, _0x7a953d7d._0x60b01583 - 1);
        }

        if (_0x7267b4eb.Instance == null)
        {
            return;
        }

        _0x7267b4eb.Instance._0x6ddc7496(true);
        _0x7267b4eb.Instance.LoadSceneByIndex(_0x64cf088a == 0 ? _0x1fc44a94._0x98dd0d5d.SCENE_0 : _0x1fc44a94._0x98dd0d5d.SCENE_1);
    }
}

internal static class _0xe8656ce7
{
    internal static string _0x4a0fff54(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}