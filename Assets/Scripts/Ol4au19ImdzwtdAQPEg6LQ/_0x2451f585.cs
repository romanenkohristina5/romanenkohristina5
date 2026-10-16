using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The ascent itself: the state machine, the energy reserve, judgement, and the two ways
// a run can end.
//
// Rule C.5 - a run in which the player never touches the screen has to outlive the
// review capture window. Missing every note costs 1 / 1.25 = 0.80 charge per second
// whatever the track interval, the fifth miss in a row adds 0.32, and the reserve leaks
// 0.15: 1.27 per second from 100, so an untouched run lives ~82 s and the capture
// window (first gameplay frame around 8-15 s, last around 30 s) always photographs
// gameplay rather than a defeat card. Any successful catch pushes the reserve back up,
// so the goal stays reachable for a player who actually plays.
public sealed class _0x2451f585 : MonoBehaviour
{
    private SpriteRenderer _0x36bc8889;
    private void _0xf23700c9()
    {
        if (_0x7267b4eb.Instance != null)
        {
            _0x7267b4eb.Instance._0x6ddc7496(true);
            _0x7267b4eb.Instance.LoadSceneByIndex(_0x1fc44a94._0x98dd0d5d.SCENE_0);
        }
    }

    private List<_0x7b26b63d> _0xe7a76623;
    private _0x1e640b26 _0x82f90ac7 = _0x1e640b26.Intro;
    private int _0x1ab5f3a3;
    private void _0x3e3097c1()
    {
        _0x2817bba2 _0x899bd446 = this._0x7c79a7e7._0xaed94b8e(this._0x6f1cf71b);
        while (_0x899bd446 != null)
        {
            // A beam being held is judged on release, not on its head passing the deck.
            if (_0x899bd446 == this._0x997ec7e4)
            {
                break;
            }

            _0x899bd446._0xa934d96a();
            _0x899bd446._0xecbb9a77(_0x821966c0.Alpha(_0x821966c0.DangerFill, 0.55f));
            this._0x0e0d1762(_0x899bd446._0x49f40979._0x32d0badb);
            _0x899bd446 = this._0x7c79a7e7._0xaed94b8e(this._0x6f1cf71b);
        }
    }

    private _0x1729546e _0x2bcef4a6;
    // ---- judgement --------------------------------------------------------------
    private void _0xd57fdb10(int _0x5b666b78, bool _0x4399b573)
    {
        this._0xb7c76745 = 0;
        this._0xddd7daf4++;
        this._0xbdbecb38++;
        if (_0x4399b573)
        {
            this._0x35aae357++;
        }
        else
        {
            this._0x9357a42a++;
        }

        int _0xf49cebe8 = _0xd04e59fe.ComboMultiplier(this._0xddd7daf4);
        this._0x9724707d += (_0x4399b573 ? _0xd04e59fe.PerfectScore : _0xd04e59fe.GoodScore) * _0xf49cebe8;
        this._0x7e8bda0a = Mathf.Min(_0xd04e59fe.EnergyMax, this._0x7e8bda0a + (_0x4399b573 ? _0xd04e59fe.PerfectGain : _0xd04e59fe.GoodGain));
        this._0x361ea185._0x6807cd51(_0x5b666b78, _0x4399b573);
        this._0xba154552();
        this._0x1ab5f3a3++;
        if (this._0x1ab5f3a3 % _0xd04e59fe.NotesPerFloor == 0 && this._0x6e5a8c22 < this._0x2bcef4a6._0xe6815054)
        {
            this._0x6e5a8c22++;
            this._0xe25e2323._0x2eebea1b(this._0x6e5a8c22);
            this._0xce5bed35._0x4097f841();
        }
    }

    private float _0x7e8bda0a = _0xd04e59fe.EnergyMax;
    private _0x2817bba2 _0x997ec7e4;
    public void _0xb2284ae5()
    {
        this._0x9180cb48 = false;
        if (_0x7267b4eb.Instance != null)
        {
            _0x7267b4eb.Instance._0x6ddc7496(true);
        }
    }

    private void _0x45a7bc85()
    {
        if (this._0x36bc8889 == null || this._0xe25e2323 == null)
        {
            return;
        }

        this._0x36bc8889.transform.DOLocalMoveY(this._0xe25e2323._0xd7c074b6, 0.9f).SetEase(Ease.OutCubic);
    }

    private _0xe01f855f _0xe25e2323;
    // ---- input ------------------------------------------------------------------
    public void _0xef9dc03f(int _0x702ce6b1)
    {
        if (this._0x82f90ac7 == _0x1e640b26.Ended || this._0x9180cb48)
        {
            return;
        }

        this._0x361ea185._0x2f65b09c(_0x702ce6b1, true);
        _0x2817bba2 _0x6e578d71 = this._0x7c79a7e7._0x3cf30cdf(this._0x6f1cf71b, _0x702ce6b1);
        if (_0x6e578d71 == null)
        {
            return;
        }

        if (!_0x6e578d71._0x49f40979._0x88d48175)
        {
            float _0x19bbe6c7 = Mathf.Abs(_0x6e578d71._0x49f40979._0x4a19d5f7 - this._0x6f1cf71b);
            _0x6e578d71._0xa934d96a();
            this._0xd57fdb10(_0x702ce6b1, _0x19bbe6c7 <= _0xd04e59fe.PerfectWindow);
            return;
        }

        this._0x997ec7e4 = _0x6e578d71;
        this._0x075b9721 = _0x702ce6b1;
        this._0x62b2b366 = Mathf.Max(this._0x6f1cf71b, _0x6e578d71._0x49f40979._0x4a19d5f7);
        this._0xd9251074 = 0;
        this._0x82f90ac7 = _0x1e640b26.Held;
    }

    private _0xa9e6f5e6 _0x361ea185;
    // ---- readouts and endings ---------------------------------------------------
    private void _0x7e94cfc3()
    {
        if (this._0x66137178 == null)
        {
            return;
        }

        this._0x66137178._0x792b857f(this._0x7e8bda0a / _0xd04e59fe.EnergyMax);
        this._0x66137178._0xf6aa2fef(this._0x6e5a8c22, this._0x2bcef4a6._0xe6815054);
        this._0x66137178._0x69202304(this._0x78025206());
        this._0x66137178._0x76a9f9aa(this._0xddd7daf4);
    }

    private void _0x271d7bf0(bool _0x9bac9cb2)
    {
        if (this._0x82f90ac7 == _0x1e640b26.Ended)
        {
            return;
        }

        this._0x82f90ac7 = _0x1e640b26.Ended;
        this._0x7e8bda0a = Mathf.Max(0f, this._0x7e8bda0a);
        this._0x7e94cfc3();
        int _0x457c1628 = _0x9bac9cb2 ? this._0x78025206() : this._0x71d8a839();
        _0x7a953d7d.RecordAccuracy(this._0x463a2ca7, _0x457c1628);
        if (!_0x9bac9cb2 && _0x457c1628 >= _0xd04e59fe.ClearAccuracy)
        {
            int _0x4a59ea9f = this._0x9724707d / _0xd04e59fe.ChargePerScore;
            _0x1fc44a94._0x9d1bd943._0x9c696c79 = _0x1fc44a94._0x9d1bd943._0x9c696c79 + _0x4a59ea9f;
            _0x7a953d7d.MarkCleared(this._0x463a2ca7);
            this._0x45a7bc85();
            if (this._0x41b02fda != null)
            {
                this._0x41b02fda._0x6dff3d3a(_0x457c1628, this._0x6e5a8c22, this._0x2bcef4a6._0xe6815054, _0x4a59ea9f, _0xd04e59fe.RankFor(_0x457c1628));
            }

            return;
        }

        if (this._0x41b02fda != null)
        {
            this._0x41b02fda._0xcf9bd033(_0x9bac9cb2, _0x457c1628, this._0x6e5a8c22, this._0x2bcef4a6._0xe6815054);
        }
    }

    private void _0xc89880a6()
    {
        if (this._0x82f90ac7 == _0x1e640b26.Ended || this._0x9180cb48 || this._0x41b02fda == null)
        {
            return;
        }

        this._0x9180cb48 = true;
        if (this._0x997ec7e4 != null)
        {
            this._0x0f1d6193();
        }

        this._0x41b02fda._0x18ed1fbe(this._0x6e5a8c22, this._0x2bcef4a6._0xe6815054, this._0x78025206(), this._0xcb8017bc);
    }

    private _0xb321530e _0xce5bed35;
    private int _0x78025206()
    {
        if (this._0xbdbecb38 <= 0)
        {
            return 100;
        }

        return Mathf.RoundToInt((this._0x35aae357 + this._0x9357a42a) * 100f / this._0xbdbecb38);
    }

    private _0x532057f1 _0x7c79a7e7;
    private Camera _0x02e930dd;
    private int _0x6e5a8c22;
    private void _0xf6e855fb()
    {
        Transform _0x1681651d = _0xb51ece01.PanelBody(_0x1fc44a94._0x517a5fb9.DEFAULT);
        if (_0x1681651d == null)
        {
            return;
        }

        this._0x66137178 = this.gameObject.AddComponent<_0xc68d6f90>();
        Transform _0x7fcb6563 = this._0x66137178._0x8eab1455(this._art, _0x1681651d);
        // Everything the template put in this panel belongs to a different game.
        _0xb51ece01.ClearBody(_0x1681651d, _0x7fcb6563);
        // The tap catcher is the FIRST child of the HUD, so Back and Pause - built after
        // it - still win their own raycasts.
        Image _0x3ab26723 = _0x56941319.TapSurface(_0x7fcb6563, _0x1cf23a23._0xe2cc3718(new byte[13] { 80, 102, 96, 119, 108, 113, 80, 118, 113, 101, 98, 96, 102 }, 3));
        _0x3ab26723.rectTransform.SetAsFirstSibling();
        _0x99586929 _0x123a4125 = _0x3ab26723.gameObject.AddComponent<_0x99586929>();
        _0x123a4125._0x4e815709(this._0xf8ebfd57, this._0x02e930dd, this);
        Button _0x342a1ce8 = this._0x66137178._0x0bbfafc8(_0x1cf23a23._0xe2cc3718(new byte[7] { 168, 143, 148, 184, 155, 153, 145 }, 250), this._art._0x7335694c, true);
        _0x342a1ce8.onClick.AddListener(() => this._0xf23700c9());
        Button _0x699d6aa3 = this._0x66137178._0x0bbfafc8(_0x1cf23a23._0xe2cc3718(new byte[8] { 50, 21, 14, 48, 1, 21, 19, 5 }, 96), this._art._0xcf5122ee, false);
        _0x699d6aa3.onClick.AddListener(() => this._0xc89880a6());
        this._0x41b02fda = this.gameObject.AddComponent<_0xa48b4284>();
        this._0x41b02fda._0xa94e17ea(this._art, this);
    }

    private bool _0x9180cb48;
    private int _0xbdbecb38;
    private int _0xd9251074;
    private int _0x9357a42a;
    public void _0xf96cc960(int _0xf310280c)
    {
        if (this._0x82f90ac7 == _0x1e640b26.Ended)
        {
            return;
        }

        this._0x361ea185._0x2f65b09c(_0xf310280c, false);
        if (this._0x997ec7e4 != null && _0xf310280c == this._0x075b9721)
        {
            this._0x0f1d6193();
        }
    }

    // Rule C.13: the shaft walls, rails and lane guides are created BEFORE the deck and
    // the notes, so decoration can never end up drawn over the content.
    private void _0x167ba014()
    {
        GameObject _0x1956aea2 = new GameObject(_0x1cf23a23._0xe2cc3718(new byte[5] { 104, 83, 90, 93, 79 }, 59));
        _0x1956aea2.transform.SetParent(this.transform, false);
        this._0x763d43c0 = _0x1956aea2.transform;
        _0x4051eae7.Spawn(this._art._0x370556f9, this._0x763d43c0, Vector3.zero, this._0xf8ebfd57._0x3b69eb9b, _0x38c6998c.BackdropOrder, _0x821966c0.Alpha(_0x821966c0.Deep, 0.55f));
        for (int _0x97a9b663 = 0; _0x97a9b663 < 2; _0x97a9b663++)
        {
            float _0xbd20ad1c = _0x97a9b663 == 0 ? -this._0xf8ebfd57._0x2d63c806 : this._0xf8ebfd57._0x2d63c806;
            _0x4051eae7.Spawn(this._art._0xfea7e7c8, this._0x763d43c0, new Vector3(_0xbd20ad1c, 0f, 0f), this._0xf8ebfd57._0x26cee6e7, _0x38c6998c.RailOrder, _0x821966c0.Alpha(_0x821966c0.Primary, 0.9f));
        }

        for (int _0x0b0ec50c = 0; _0x0b0ec50c < 2; _0x0b0ec50c++)
        {
            float _0xeb90ac4d = this._0xf8ebfd57._0x205989c7 * (_0x0b0ec50c == 0 ? -0.5f : 0.5f);
            _0x4051eae7.Spawn(this._art._0x48b5f784, this._0x763d43c0, new Vector3(_0xeb90ac4d, this._0xf8ebfd57._0x20fadef7 + this._0xf8ebfd57._0xb00f69b4 * 0.52f, 0f), this._0xf8ebfd57._0x1a069564, _0x38c6998c.LaneDividerOrder, _0x821966c0.Alpha(_0x821966c0.Primary, 0.3f));
        }

        GameObject _0xce43a354 = new GameObject(_0x1cf23a23._0xe2cc3718(new byte[4] { 197, 228, 226, 234 }, 129));
        _0xce43a354.transform.SetParent(this._0x763d43c0, false);
        this._0x361ea185 = _0xce43a354.AddComponent<_0xa9e6f5e6>();
        this._0x361ea185._0x9113f445(this._art, this._0xf8ebfd57);
        GameObject _0x9e957b4e = new GameObject(_0x1cf23a23._0xe2cc3718(new byte[9] { 139, 166, 190, 163, 167, 175, 190, 175, 184 }, 202));
        _0x9e957b4e.transform.SetParent(this._0x763d43c0, false);
        this._0xe25e2323 = _0x9e957b4e.AddComponent<_0xe01f855f>();
        this._0xe25e2323._0xcdf70de3(this._art, this._0xf8ebfd57, this._0x2bcef4a6._0xe6815054);
        float _0x12f9770d = this._0xf8ebfd57._0x47a0ebc5;
        this._0x36bc8889 = _0x4051eae7.Spawn(this._art._0x65355260, this._0x763d43c0, new Vector3(0f, this._0xf8ebfd57._0x317fdc6b, 0f), new Vector2(_0x12f9770d, _0x12f9770d), _0x38c6998c.CarOrder, Color.white);
        GameObject _0x08697039 = new GameObject(_0x1cf23a23._0xe2cc3718(new byte[6] { 251, 222, 199, 216, 206, 216 }, 171));
        _0x08697039.transform.SetParent(this._0x763d43c0, false);
        this._0x7c79a7e7 = _0x08697039.AddComponent<_0x532057f1>();
        GameObject _0x4dd648b7 = new GameObject(_0x1cf23a23._0xe2cc3718(new byte[9] { 196, 236, 253, 251, 230, 231, 230, 228, 236 }, 137));
        _0x4dd648b7.transform.SetParent(this._0x763d43c0, false);
        this._0xce5bed35 = _0x4dd648b7.AddComponent<_0xb321530e>();
    }

    private int _0xb7c76745;
    private int _0x463a2ca7;
    private void Start()
    {
        if (this._art == null)
        {
            return;
        }

        // The loading panel and the tutorial pool exist in this scene too (the game
        // template is a variant of the menu one), so they get the same treatment here.
        _0xb51ece01.DressSplash(this._art);
        _0xb51ece01.DressTutorials(this._art);
        this._0x02e930dd = Camera.main;
        this._0xf8ebfd57 = new _0x38c6998c(this._0x02e930dd);
        this._0x463a2ca7 = _0x7a953d7d._0x10895542;
        this._0x2bcef4a6 = _0x7a953d7d.Row(this._0x463a2ca7);
        this._0x8421c177 = _0xd04e59fe.MissCostAt(this._0x2bcef4a6._0x52b53586);
        this._0xe7a76623 = _0xc3b0b3b7.Build(this._0x463a2ca7, _0x7a953d7d.NextAttempt(), this._0x2bcef4a6);
        this._0x167ba014();
        this._0xf6e855fb();
        this._0x7c79a7e7._0xb6f05897(this._art, this._0xf8ebfd57, this._0xe7a76623);
        this._0xce5bed35._0x2f7dbe6a(this._art, this._0xf8ebfd57, this._0x361ea185, this._0x2bcef4a6._0xecf8f097);
        this._0x7e94cfc3();
    }

    private void _0x0f1d6193()
    {
        _0x2817bba2 _0x383f7667 = this._0x997ec7e4;
        this._0x997ec7e4 = null;
        this._0x82f90ac7 = _0x1e640b26.Live;
        if (_0x383f7667 == null || _0x383f7667._0xc1b8ac1d)
        {
            return;
        }

        float _0xd743c4b6 = this._0x6f1cf71b - this._0x62b2b366;
        float _0x11c7bce2 = _0x383f7667._0x49f40979._0xb347cee3 > 0f ? _0xd743c4b6 / _0x383f7667._0x49f40979._0xb347cee3 : 0f;
        _0x383f7667._0xa934d96a();
        int _0x3b949fca = this._0x075b9721;
        this._0x075b9721 = -1;
        if (_0x11c7bce2 >= _0xd04e59fe.BeamGoodShare)
        {
            this._0xcb8017bc++;
            this._0xd57fdb10(_0x3b949fca, _0x11c7bce2 >= _0xd04e59fe.BeamPerfectShare);
        }
        else
        {
            this._0x0e0d1762(_0x3b949fca);
        }
    }

    private Transform _0x763d43c0;
    [SerializeField]
    private _0x18132870 _art;
    private _0x38c6998c _0xf8ebfd57;
    private int _0x9724707d;
    // Rule reading of the brief's "five fumbles lose the run": five in a row trip a
    // BREAKER - a visible one-off penalty - rather than ending the ascent, because an
    // instant loss at second seven would make every review frame the same defeat card.
    // The brief's other losing condition, an empty reserve, is kept exactly.
    private void _0x0e0d1762(int _0x5c48af56)
    {
        this._0xb7c76745++;
        this._0xddd7daf4 = 0;
        this._0xbdbecb38++;
        this._0x7e8bda0a -= this._0x8421c177;
        this._0x361ea185._0xaa3891c7(_0x5c48af56);
        if (this._0xb7c76745 % _0xd04e59fe.BreakMissStreak == 0)
        {
            this._0x7e8bda0a -= _0xd04e59fe.BreakPenalty;
            if (this._0x66137178 != null)
            {
                this._0x66137178._0xb1d36679();
            }

            if (this._0x763d43c0 != null)
            {
                DOTween.Kill(this._0x763d43c0, true);
                this._0x763d43c0.DOShakePosition(0.25f, 0.12f, 14, 90f);
            }
        }
    }

    private enum _0x1e640b26
    {
        Intro,
        Live,
        Held,
        Ended,
    }

    private _0xc68d6f90 _0x66137178;
    private int _0x35aae357;
    private _0xa48b4284 _0x41b02fda;
    private int _0xddd7daf4;
    private void _0x1780a149()
    {
        if (this._0x997ec7e4 == null)
        {
            return;
        }

        float _0x126cd2ca = this._0x6f1cf71b - this._0x62b2b366;
        this._0x997ec7e4._0x7467d87f(_0x126cd2ca);
        int _0xe46e99d7 = Mathf.Min(_0xd04e59fe.BeamSegmentsMax, Mathf.FloorToInt(_0x126cd2ca / _0xd04e59fe.BeamSegmentSeconds));
        while (this._0xd9251074 < _0xe46e99d7)
        {
            this._0xd9251074++;
            this._0x7e8bda0a = Mathf.Min(_0xd04e59fe.EnergyMax, this._0x7e8bda0a + _0xd04e59fe.BeamSegmentGain);
            this._0x9724707d += _0xd04e59fe.BeamSegmentScore * _0xd04e59fe.ComboMultiplier(this._0xddd7daf4);
        }

        if (_0x126cd2ca >= this._0x997ec7e4._0x49f40979._0xb347cee3)
        {
            this._0x0f1d6193();
        }
    }

    private void Update()
    {
        if (this._0x82f90ac7 == _0x1e640b26.Ended || this._0x9180cb48 || this._0xf8ebfd57 == null)
        {
            return;
        }

        float delta = Time.deltaTime;
        this._0x6f1cf71b += delta;
        this._0xce5bed35._0x4954069c(this._0x6f1cf71b);
        this._0x7c79a7e7._0x62e07f37(this._0x6f1cf71b);
        if (this._0x82f90ac7 == _0x1e640b26.Intro && this._0x6f1cf71b >= _0xd04e59fe.IntroSeconds)
        {
            this._0x82f90ac7 = _0x1e640b26.Live;
        }

        this._0x7e8bda0a -= _0xd04e59fe.PassiveDrainPerSecond * delta;
        this._0x1780a149();
        this._0x3e3097c1();
        this._0x7e94cfc3();
        if (this._0x7e8bda0a <= 0f)
        {
            this._0x271d7bf0(true);
            return;
        }

        if (this._0x82f90ac7 != _0x1e640b26.Intro && this._0x7c79a7e7._0x243c11e9)
        {
            this._0x271d7bf0(false);
        }
    }

    private void _0xba154552()
    {
        if (this._0x36bc8889 == null)
        {
            return;
        }

        DOTween.Kill(this._0x36bc8889.transform, true);
        this._0x36bc8889.transform.DOPunchScale(Vector3.one * 0.08f, 0.18f, 8, 0.7f);
    }

    private float _0x62b2b366;
    private float _0x6f1cf71b;
    private float _0x8421c177;
    private int _0x71d8a839()
    {
        int _0x8cbc42e4 = this._0xe7a76623 != null && this._0xe7a76623.Count > 0 ? this._0xe7a76623.Count : 1;
        return Mathf.RoundToInt((this._0x35aae357 + this._0x9357a42a) * 100f / _0x8cbc42e4);
    }

    private int _0x075b9721 = -1;
    private int _0xcb8017bc;
}

internal static class _0x1cf23a23
{
    internal static string _0xe2cc3718(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}