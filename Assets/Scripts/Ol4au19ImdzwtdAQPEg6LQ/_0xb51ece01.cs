using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Everything this game does TO the template rather than beside it: dressing the splash
// body, rewriting the tutorial pages in this game's words, and switching off the
// template HUD a game of this shape does not use. All of it is reached through the
// template's public singletons and typed lists - never by object name.
public static class _0xb51ece01
{
    public static Transform PanelBody(int _0x6ca273ae)
    {
        _0x9ae3504d _0x99741a54 = _0x9ae3504d.Instance;
        if (_0x99741a54 == null || _0x99741a54.Panels == null)
        {
            return null;
        }

        if (_0x6ca273ae < 0 || _0x6ca273ae >= _0x99741a54.Panels.Count)
        {
            return null;
        }

        _0xc91fa104 _0x1d233ad6 = _0x99741a54.Panels[_0x6ca273ae];
        if (_0x1d233ad6 == null || _0x1d233ad6.Content == null)
        {
            return null;
        }

        return _0x1d233ad6.Content.transform;
    }

    private static void RaisePanel(int _0x404eccd2)
    {
        if (_0x9ae3504d.Instance != null)
        {
            _0x9ae3504d.Instance._0xdb936680(_0x404eccd2);
        }
    }

    // The template's panel chrome ships EVERY image with raycastTarget off, so its
    // buttons take no taps until something gives them a target graphic. The menu's
    // scene-loading button is found by its DRIVER (a typed component), never by name.
    public static Button FindSceneButton(Transform _0xb903eb83, int _0x6ba8f98a)
    {
        if (_0xb903eb83 == null)
        {
            return null;
        }

        List<_0x7b30a34e> _0x5ef89179 = new List<_0x7b30a34e>(_0xb903eb83.GetComponentsInChildren<_0x7b30a34e>(true));
        for (int _0xad3ada74 = 0; _0xad3ada74 < _0x5ef89179.Count; _0xad3ada74++)
        {
            _0x7b30a34e _0xcb3929e3 = _0x5ef89179[_0xad3ada74];
            if (_0xcb3929e3 == null || _0xcb3929e3.IsLoadCurrentScene || _0xcb3929e3.LoadSceneId != _0x6ba8f98a)
            {
                continue;
            }

            Button _0xdd115ad4 = _0xcb3929e3.GetComponent<Button>();
            if (_0xdd115ad4 == null)
            {
                _0xdd115ad4 = _0xcb3929e3.GetComponentInChildren<Button>(true);
            }

            if (_0xdd115ad4 != null)
            {
                return _0xdd115ad4;
            }
        }

        return null;
    }

    // The splash gets this game's own mark - concentric rings with a chevron, an
    // ABSTRACT emblem carrying no lettering - over a darker wash than the menu, so the
    // two screens never read as the same picture. The loading bar is the body's original
    // child and stays the last sibling, i.e. on top of everything added here.
    public static void DressSplash(_0x18132870 _0x2447e35a)
    {
        Transform _0x1f6c93d6 = PanelBody(_0x1fc44a94._0x517a5fb9.SPLASH);
        if (_0x1f6c93d6 == null || _0x2447e35a == null)
        {
            return;
        }

        RectTransform _0xb3abf0a3 = _0x56941319.Node(_0x1f6c93d6, _0xbb7250e0._0x932b1a61(new byte[15] { 69, 126, 119, 112, 98, 69, 102, 122, 119, 101, 126, 91, 119, 100, 125 }, 22));
        Image _0x00b2d523 = _0x56941319.Plate(_0xb3abf0a3, _0xbb7250e0._0x932b1a61(new byte[10] { 162, 129, 157, 144, 130, 153, 166, 144, 130, 153 }, 241), _0x2447e35a._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Deep, 0.88f), 1.35f);
        _0x56941319.Stretch(_0x00b2d523.rectTransform);
        RectTransform _0xedefb0b1 = _0x56941319.Node(_0xb3abf0a3, _0xbb7250e0._0x932b1a61(new byte[12] { 47, 12, 16, 29, 15, 20, 57, 17, 30, 16, 25, 17 }, 124));
        _0x56941319.Place(_0xedefb0b1, new Vector2(0.5f, 0.58f), Vector2.zero, new Vector2(520f, 520f));
        Image _0x186c1bf3 = _0x56941319.Picture(_0xedefb0b1, _0xbb7250e0._0x932b1a61(new byte[15] { 106, 73, 85, 88, 74, 81, 124, 84, 91, 85, 92, 84, 120, 75, 77 }, 57), _0x2447e35a._0xaa03cc84, Color.white);
        _0x56941319.Stretch(_0x186c1bf3.rectTransform);
        TextMeshProUGUI _0x76c6adcc = _0x56941319.Label(_0xb3abf0a3, _0xbb7250e0._0x932b1a61(new byte[13] { 10, 41, 53, 56, 42, 49, 26, 56, 41, 45, 48, 54, 55 }, 89), _0xbb7250e0._0x932b1a61(new byte[18] { 65, 94, 70, 84, 67, 88, 95, 86, 49, 69, 89, 84, 49, 66, 89, 80, 87, 69 }, 17), 44f, _0x821966c0.TextPrimary, _0x2447e35a._0x6cd35f3f, TextAlignmentOptions.Center);
        _0x56941319.Place(_0x76c6adcc.rectTransform, new Vector2(0.5f, 0.32f), Vector2.zero, new Vector2(1000f, 90f));
        _0x76c6adcc.characterSpacing = 8f;
        _0xb3abf0a3.SetAsFirstSibling();
        _0xedefb0b1.localScale = Vector3.one * 0.9f;
        _0xedefb0b1.DOScale(1.06f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private static void RememberTutorial()
    {
        if (_0x7267b4eb.Instance != null)
        {
            _0x7267b4eb.Instance._0xec323a3d();
        }
    }

    public static RectTransform Card(Transform _0xa20b4eb3, _0x18132870 _0x6ec1288f, Vector2 _0x81c055fd, Vector2 _0x207bdd42, Vector2 _0x645f4797, Color _0x425595dd, out Image _0xac9e1edf)
    {
        _0xac9e1edf = _0x56941319.Plate(_0xa20b4eb3, _0xbb7250e0._0x932b1a61(new byte[7] { 162, 128, 147, 133, 179, 136, 140 }, 225), _0x6ec1288f._0x07271a7c, _0x425595dd, _0x56941319.RadiusFor(_0x645f4797));
        _0x56941319.Place(_0xac9e1edf.rectTransform, _0x81c055fd, _0x207bdd42, _0x645f4797 + new Vector2(12f, 12f));
        Image _0xeb3efaf1 = _0x56941319.Plate(_0xa20b4eb3, _0xbb7250e0._0x932b1a61(new byte[8] { 223, 253, 238, 248, 218, 253, 255, 249 }, 156), _0x6ec1288f._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Surface, 0.97f), _0x56941319.RadiusFor(_0x645f4797));
        _0x56941319.Place(_0xeb3efaf1.rectTransform, _0x81c055fd, _0x207bdd42, _0x645f4797);
        return _0xeb3efaf1.rectTransform;
    }

    private static readonly int[] _0x89605718 =
    {
        _0x1fc44a94._0x517a5fb9.TUTORIAL0,
        _0x1fc44a94._0x517a5fb9.TUTORIAL1,
        _0x1fc44a94._0x517a5fb9.TUTORIAL2,
        _0x1fc44a94._0x517a5fb9.TUTORIAL3,
        _0x1fc44a94._0x517a5fb9.TUTORIAL4,
        _0x1fc44a94._0x517a5fb9.TUTORIAL5,
        _0x1fc44a94._0x517a5fb9.TUTORIAL6,
    };
    // Rule C.15: an enabled tutorial carrying the template's filler reads worse than no
    // tutorial at all. Every page the template declares gets this game's own words,
    // whether or not anything navigates to it.
    public static void DressTutorials(_0x18132870 _0x3a071e65)
    {
        if (_0x3a071e65 == null)
        {
            return;
        }

        string[] _0x7c950955 =
        {
            _0xbb7250e0._0x932b1a61(new byte[11] { 135, 156, 155, 134, 128, 244, 132, 129, 152, 135, 145 }, 212),
            _0xbb7250e0._0x932b1a61(new byte[9] { 2, 1, 0, 9, 110, 12, 11, 15, 3 }, 78),
            _0xbb7250e0._0x932b1a61(new byte[9] { 181, 169, 164, 193, 162, 173, 168, 172, 163 }, 225),
            _0xbb7250e0._0x932b1a61(new byte[9] { 118, 106, 103, 2, 97, 110, 107, 111, 96 }, 34),
            _0xbb7250e0._0x932b1a61(new byte[9] { 71, 91, 86, 51, 80, 95, 90, 94, 81 }, 19),
            _0xbb7250e0._0x932b1a61(new byte[9] { 218, 198, 203, 174, 205, 194, 199, 195, 204 }, 142),
            _0xbb7250e0._0x932b1a61(new byte[9] { 167, 187, 182, 211, 176, 191, 186, 190, 177 }, 243),
        };
        string _0x224047cf = _0xbb7250e0._0x932b1a61(new byte[93] { 236, 255, 236, 251, 240, 137, 234, 225, 232, 251, 238, 236, 137, 240, 230, 252, 137, 234, 232, 253, 234, 225, 137, 229, 224, 239, 253, 250, 137, 253, 225, 236, 163, 234, 232, 251, 137, 230, 231, 236, 137, 239, 229, 230, 230, 251, 135, 137, 232, 137, 228, 224, 250, 250, 137, 235, 229, 236, 236, 237, 250, 137, 253, 225, 236, 163, 234, 225, 232, 251, 238, 236, 137, 235, 232, 234, 226, 137, 224, 231, 253, 230, 137, 253, 225, 236, 137, 250, 225, 232, 239, 253, 135 }, 169);
        string[] _0xa2413639 =
        {
            _0xbb7250e0._0x932b1a61(new byte[79] { 60, 93, 46, 45, 60, 47, 54, 93, 57, 47, 50, 45, 46, 93, 57, 50, 42, 51, 93, 50, 51, 56, 93, 46, 56, 62, 41, 50, 47, 83, 119, 41, 60, 45, 93, 41, 53, 60, 41, 93, 46, 56, 62, 41, 50, 47, 93, 41, 53, 56, 93, 52, 51, 46, 41, 60, 51, 41, 93, 52, 41, 119, 41, 50, 40, 62, 53, 56, 46, 93, 41, 53, 56, 93, 57, 56, 62, 54, 83 }, 125),
            _0xbb7250e0._0x932b1a61(new byte[89] { 143, 238, 140, 139, 143, 131, 238, 135, 157, 238, 130, 129, 128, 137, 139, 156, 238, 154, 134, 143, 128, 238, 143, 238, 154, 143, 158, 224, 196, 134, 129, 130, 138, 238, 154, 134, 139, 238, 157, 139, 141, 154, 129, 156, 238, 153, 134, 135, 130, 139, 238, 135, 154, 238, 156, 155, 128, 157, 196, 154, 134, 156, 129, 155, 137, 134, 238, 227, 238, 156, 139, 130, 139, 143, 157, 139, 238, 143, 154, 238, 154, 134, 139, 238, 154, 143, 135, 130, 224 }, 206),
            _0x224047cf,
            _0x224047cf,
            _0x224047cf,
            _0x224047cf,
            _0x224047cf,
        };
        for (int _0xba5aae9e = 0; _0xba5aae9e < _0x89605718.Length; _0xba5aae9e++)
        {
            Transform _0xcafdb4e8 = PanelBody(_0x89605718[_0xba5aae9e]);
            if (_0xcafdb4e8 == null)
            {
                continue;
            }

            RectTransform _0xb1e13525 = _0x56941319.Node(_0xcafdb4e8, _0xbb7250e0._0x932b1a61(new byte[17] { 34, 25, 16, 23, 5, 37, 4, 5, 30, 3, 24, 16, 29, 33, 16, 22, 20 }, 113));
            ClearBody(_0xcafdb4e8, _0xb1e13525);
            RectTransform _0x8b792dbb = Card(_0xb1e13525, _0x3a071e65, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1040f, 1180f), _0x821966c0.Alpha(_0x821966c0.Primary, 0.95f));
            TextMeshProUGUI _0x3a30e44d = _0x56941319.Label(_0x8b792dbb, _0xbb7250e0._0x932b1a61(new byte[13] { 216, 249, 248, 227, 254, 229, 237, 224, 216, 229, 248, 224, 233 }, 140), _0x7c950955[_0xba5aae9e], 72f, _0x821966c0.TextPrimary, _0x3a071e65._0x6cd35f3f, TextAlignmentOptions.Center);
            _0x56941319.Place(_0x3a30e44d.rectTransform, new Vector2(0.5f, 0.85f), Vector2.zero, new Vector2(920f, 120f));
            Image _0x30d328ef = _0x56941319.Picture(_0x8b792dbb, _0xbb7250e0._0x932b1a61(new byte[14] { 121, 88, 89, 66, 95, 68, 76, 65, 107, 68, 74, 88, 95, 72 }, 45), _0xba5aae9e == 1 ? _0x3a071e65._0xedffc3ef : _0x3a071e65._0x1945f64f, Color.white);
            _0x56941319.Place(_0x30d328ef.rectTransform, new Vector2(0.5f, 0.62f), Vector2.zero, new Vector2(260f, 260f));
            Image _0xf6fc2bf0 = _0x56941319.Plate(_0x8b792dbb, _0xbb7250e0._0x932b1a61(new byte[11] { 163, 130, 131, 152, 133, 158, 150, 155, 167, 150, 147 }, 247), _0x3a071e65._0x07271a7c, _0x821966c0.Alpha(_0x821966c0.Secondary, 0.55f), 2.2f);
            _0x56941319.Place(_0xf6fc2bf0.rectTransform, new Vector2(0.5f, 0.46f), Vector2.zero, new Vector2(460f, 26f));
            TextMeshProUGUI _0x29c80957 = _0x56941319.Label(_0x8b792dbb, _0xbb7250e0._0x932b1a61(new byte[12] { 135, 166, 167, 188, 161, 186, 178, 191, 135, 182, 171, 167 }, 211), _0xa2413639[_0xba5aae9e], 44f, _0x821966c0.TextPrimary, _0x3a071e65._0x6cd35f3f, TextAlignmentOptions.Center);
            _0x56941319.Place(_0x29c80957.rectTransform, new Vector2(0.5f, 0.29f), Vector2.zero, new Vector2(940f, 260f));
            bool _0x9d5ab640 = _0xba5aae9e >= 1;
            int _0x687e19ea = _0x9d5ab640 ? _0x1fc44a94._0x517a5fb9.DEFAULT : _0x89605718[_0xba5aae9e + 1];
            Button _0x71459821 = _0x56941319.TextButton(_0x8b792dbb, _0xbb7250e0._0x932b1a61(new byte[12] { 129, 160, 161, 186, 167, 188, 180, 185, 155, 176, 173, 161 }, 213), _0x9d5ab640 ? _0xbb7250e0._0x932b1a61(new byte[6] { 10, 2, 25, 109, 4, 25 }, 77) : _0xbb7250e0._0x932b1a61(new byte[4] { 243, 248, 229, 233 }, 189), new Vector2(0.5f, 0.10f), Vector2.zero, new Vector2(520f, 132f), _0x821966c0.Surface, _0x821966c0.Primary, _0x821966c0.TextPrimary, 52f, _0x3a071e65._0x07271a7c, _0x3a071e65._0x6cd35f3f);
            int _0x5e7e2683 = _0x687e19ea;
            _0x71459821.onClick.AddListener(() => RaisePanel(_0x5e7e2683));
            _0x71459821.onClick.AddListener(() => RememberTutorial());
        }
    }

    // Switch off every branch of a panel body except the one this game just built (and
    // any branch that owns a Pop - those are live result cards, not leftovers).
    public static void ClearBody(Transform _0x596e9638, Transform _0xcbc29485)
    {
        if (_0x596e9638 == null)
        {
            return;
        }

        for (int _0x1f81212b = _0x596e9638.childCount - 1; _0x1f81212b >= 0; _0x1f81212b--)
        {
            Transform _0x97675785 = _0x596e9638.GetChild(_0x1f81212b);
            if (_0x97675785 == null || _0x97675785 == _0xcbc29485)
            {
                continue;
            }

            if (_0xcbc29485 != null && _0xcbc29485.IsChildOf(_0x97675785))
            {
                continue;
            }

            if (_0x97675785.GetComponentInChildren<_0x3e70f2cb>(true) != null)
            {
                continue;
            }

            _0x97675785.gameObject.SetActive(false);
        }
    }

    // A dark card with a bright rim behind it. The rim is built FIRST so it sits under
    // the card and shows only as an even ring - decoration before content, never over it.
    public static RectTransform Card(Transform _0x7d7767dc, _0x18132870 _0xf92f8e46, Vector2 _0xf7bec7ed, Vector2 _0x15eba5ef, Vector2 _0xe0457a84, Color _0xa5c28ce6)
    {
        Image _0xe9185439;
        return Card(_0x7d7767dc, _0xf92f8e46, _0xf7bec7ed, _0x15eba5ef, _0xe0457a84, _0xa5c28ce6, out _0xe9185439);
    }
}

internal static class _0xbb7250e0
{
    internal static string _0x932b1a61(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}