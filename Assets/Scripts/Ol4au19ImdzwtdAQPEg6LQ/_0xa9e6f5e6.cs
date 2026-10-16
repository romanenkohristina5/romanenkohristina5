using DG.Tweening;
using UnityEngine;

// The landing deck: three sectors, the pilot line that marks the hit instant, and the
// pulse ring that IS the metronome. Every size comes from PulseLayout, every sorting
// order from its named constants.
public sealed class _0xa9e6f5e6 : MonoBehaviour
{
    private SpriteRenderer _0xa622f09a;
    private SpriteRenderer _0x5984ff54(int _0x6279bb80)
    {
        if (_0x6279bb80 < 0 || _0x6279bb80 >= this._0x5394a634.Length)
        {
            return null;
        }

        return this._0x5394a634[_0x6279bb80];
    }

    private _0x18132870 _0x0caede99;
    private void _0xca4cd057(SpriteRenderer _0x19965d5d)
    {
        if (_0x19965d5d != null)
        {
            Destroy(_0x19965d5d.gameObject);
        }
    }

    private float _0xf1d45f73;
    public void _0x6807cd51(int _0x01a3b69b, bool _0xa8ea382a)
    {
        SpriteRenderer _0x667a7fe4 = this._0x5984ff54(_0x01a3b69b);
        if (_0x667a7fe4 == null)
        {
            return;
        }

        DOTween.Kill(_0x667a7fe4, true);
        _0x667a7fe4.color = _0xa8ea382a ? _0x821966c0.Reward : _0x821966c0.Secondary;
        _0x667a7fe4.DOColor(Color.white, 0.22f).SetTarget(_0x667a7fe4);
        if (this._0x0caede99 != null && this._0x0caede99._0x9150c0b8 != null)
        {
            float _0x676da15c = this._0xb0b13d2b._0xa0eb066f;
            SpriteRenderer _0xf04cd8f7 = _0x4051eae7.Spawn(this._0x0caede99._0x9150c0b8, this.transform, new Vector3(this._0xb0b13d2b._0xbaa2aba6(_0x01a3b69b), this._0xb0b13d2b._0x20fadef7, 0f), new Vector2(_0x676da15c * 0.4f, _0x676da15c * 0.4f), _0x38c6998c.BurstOrder, _0xa8ea382a ? _0x821966c0.Reward : _0x821966c0.Secondary);
            if (_0xf04cd8f7 != null)
            {
                DOTween.To(() => _0xf04cd8f7.size.x, _0x002774dc => _0xf04cd8f7.size = new Vector2(_0x002774dc, _0x002774dc), _0x676da15c * 1.3f, _0xd04e59fe.BurstSeconds).SetEase(Ease.OutCubic).SetTarget(_0xf04cd8f7);
                _0xf04cd8f7.DOFade(0f, _0xd04e59fe.BurstSeconds).SetTarget(_0xf04cd8f7).OnComplete(() => this._0xca4cd057(_0xf04cd8f7));
            }
        }
    }

    private readonly SpriteRenderer[] _0x5394a634 = new SpriteRenderer[_0x38c6998c.LaneCount];
    public void _0x2f65b09c(int _0xfde0a99a, bool _0x7d32e1d8)
    {
        SpriteRenderer _0x1a7a3f10 = this._0x5984ff54(_0xfde0a99a);
        if (_0x1a7a3f10 == null)
        {
            return;
        }

        Vector2 _0x3ab46c15 = this._0xb0b13d2b._0x0c17f921;
        _0x4051eae7.Resize(_0x1a7a3f10, _0x7d32e1d8 ? _0x3ab46c15 * 0.94f : _0x3ab46c15);
        _0x1a7a3f10.color = _0x7d32e1d8 ? _0x821966c0.Alpha(_0x821966c0.Secondary, 1f) : Color.white;
    }

    public void _0xaa3891c7(int _0x00bf143b)
    {
        SpriteRenderer _0xdf7e94b3 = this._0x5984ff54(_0x00bf143b);
        if (_0xdf7e94b3 == null)
        {
            return;
        }

        DOTween.Kill(_0xdf7e94b3, true);
        _0xdf7e94b3.color = _0x821966c0.DangerFill;
        _0xdf7e94b3.DOColor(Color.white, 0.18f).SetTarget(_0xdf7e94b3);
    }

    // Rule C.0: the pulse is animated through m_Size from the computed base, not through
    // a scale literal, so it reads the same on any aspect.
    public void _0xd23dfe39(float _0x3575deef)
    {
        if (this._0xe25fd922 == null)
        {
            return;
        }

        DOTween.Kill(this._0xe25fd922, true);
        float _0xdc6d0bef = this._0xf1d45f73 * 0.55f;
        float _0xb8c49373 = this._0xf1d45f73;
        this._0xe25fd922.size = new Vector2(_0xdc6d0bef, _0xdc6d0bef);
        this._0xe25fd922.color = _0x821966c0.Alpha(Color.white, 0.9f);
        float _0xc5a6b056 = Mathf.Max(0.12f, _0x3575deef * 0.9f);
        DOTween.To(() => this._0xe25fd922.size.x, _0x002774dc => this._0xe25fd922.size = new Vector2(_0x002774dc, _0x002774dc), _0xb8c49373, _0xc5a6b056).SetEase(Ease.OutCubic).SetTarget(this._0xe25fd922);
        this._0xe25fd922.DOFade(0f, _0xc5a6b056).SetEase(Ease.InQuad).SetTarget(this._0xe25fd922);
        if (this._0xa32d5cad != null)
        {
            DOTween.Kill(this._0xa32d5cad, true);
            this._0xa32d5cad.color = _0x821966c0.Alpha(_0x821966c0.Secondary, 0.85f);
            this._0xa32d5cad.DOFade(0.35f, _0xc5a6b056).SetTarget(this._0xa32d5cad);
        }
    }

    private SpriteRenderer _0xa32d5cad;
    public void _0x9113f445(_0x18132870 _0x18bdd44a, _0x38c6998c _0x9afb3403)
    {
        this._0x0caede99 = _0x18bdd44a;
        this._0xb0b13d2b = _0x9afb3403;
        this._0xa622f09a = _0x4051eae7.Spawn(_0x18bdd44a._0x41d8bb06, this.transform, new Vector3(0f, _0x9afb3403._0x484581e4, 0f), _0x9afb3403._0xca8989f6, _0x38c6998c.DeckOrder, Color.white);
        for (int _0x054b7850 = 0; _0x054b7850 < _0x38c6998c.LaneCount; _0x054b7850++)
        {
            this._0x5394a634[_0x054b7850] = _0x4051eae7.Spawn(_0x18bdd44a._0x850dfcce, this.transform, new Vector3(_0x9afb3403._0xbaa2aba6(_0x054b7850), _0x9afb3403._0x20fadef7, 0f), _0x9afb3403._0x0c17f921, _0x38c6998c.SectorPadOrder, Color.white);
        }

        this._0xa32d5cad = _0x4051eae7.Spawn(_0x18bdd44a._0x0ac5e015, this.transform, new Vector3(0f, _0x9afb3403._0x20fadef7, 0f), _0x9afb3403._0x073f9aa1, _0x38c6998c.PilotLineOrder, _0x821966c0.Alpha(_0x821966c0.Secondary, 0.35f));
        this._0xf1d45f73 = _0x9afb3403._0xea490e7e;
        this._0xe25fd922 = _0x4051eae7.Spawn(_0x18bdd44a._0x04a75342, this.transform, new Vector3(0f, _0x9afb3403._0x20fadef7, 0f), new Vector2(this._0xf1d45f73, this._0xf1d45f73), _0x38c6998c.HitRingOrder, _0x821966c0.Alpha(Color.white, 0f));
    }

    private _0x38c6998c _0xb0b13d2b;
    private SpriteRenderer _0xe25fd922;
}