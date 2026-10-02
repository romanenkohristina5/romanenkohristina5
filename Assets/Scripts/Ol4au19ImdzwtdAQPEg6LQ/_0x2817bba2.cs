using UnityEngine;

// One charge travelling down the shaft. A SPARK is a single token; a BEAM is a head, a
// stretched body and a tail, all at the note sorting order and all sized from the
// camera-derived layout - never from the source PNG.
public sealed class _0x2817bba2 : MonoBehaviour
{
    private SpriteRenderer _0xd4594d47;
    private void _0xd909a80f(SpriteRenderer _0x646dafb4, Color _0xdcb93877)
    {
        if (_0x646dafb4 != null)
        {
            _0x646dafb4.color = _0xdcb93877;
        }
    }

    private SpriteRenderer _0xc663f997;
    public void _0xa934d96a()
    {
        this._0xb91d0200 = true;
    }

    private SpriteRenderer _0x0500312b;
    private _0x7b26b63d _0xc974aeb6;
    // The head sits exactly where the note's hit instant currently is; the beam grows
    // UPWARDS from it, so the tail is the last part to cross the deck.
    public void _0xe1d6e390(float _0x4aefb597)
    {
        if (this._0xfbd1f7af == null || this._0xc974aeb6 == null)
        {
            return;
        }

        float _0x84230753 = this._0xfbd1f7af._0x20fadef7 + (this._0xc974aeb6._0x4a19d5f7 - _0x4aefb597) * this._0xfbd1f7af._0x6767802c;
        _0x4051eae7.MoveY(this.transform, _0x84230753);
        if (this._0xc974aeb6._0x88d48175)
        {
            if (this._0x0500312b != null)
            {
                this._0x0500312b.transform.localPosition = new Vector3(0f, this._0x3d15d11e * 0.5f, 0f);
            }

            if (this._0xd4594d47 != null)
            {
                this._0xd4594d47.transform.localPosition = new Vector3(0f, this._0x3d15d11e, 0f);
            }
        }
    }

    public bool _0xc1b8ac1d
    {
        get
        {
            return this._0xb91d0200;
        }
    }

    private bool _0xb91d0200;
    private _0x38c6998c _0xfbd1f7af;
    private SpriteRenderer _0x6dea5977;
    // Once a beam is being held, the part already consumed shrinks away, so the player
    // can see how much of it is still running through the sector.
    public void _0x7467d87f(float _0xbcfd269f)
    {
        if (!this._0xc974aeb6._0x88d48175 || this._0x0500312b == null || this._0xfbd1f7af == null)
        {
            return;
        }

        float _0x55dfe371 = Mathf.Max(0f, this._0xc974aeb6._0xb347cee3 - _0xbcfd269f) * this._0xfbd1f7af._0x6767802c;
        _0x4051eae7.Resize(this._0x0500312b, new Vector2(this._0xfbd1f7af._0x55d00dcd, _0x55dfe371));
        this._0x0500312b.transform.localPosition = new Vector3(0f, _0x55dfe371 * 0.5f, 0f);
        if (this._0xd4594d47 != null)
        {
            this._0xd4594d47.transform.localPosition = new Vector3(0f, _0x55dfe371, 0f);
        }
    }

    public _0x7b26b63d _0x49f40979
    {
        get
        {
            return this._0xc974aeb6;
        }
    }

    public void _0xecbb9a77(Color _0x63365471)
    {
        this._0xd909a80f(this._0x6dea5977, _0x63365471);
        this._0xd909a80f(this._0xc663f997, _0x63365471);
        this._0xd909a80f(this._0x0500312b, _0x63365471);
        this._0xd909a80f(this._0xd4594d47, _0x63365471);
    }

    public void _0xb56900b2(_0x18132870 _0x29858bd0, _0x38c6998c _0x459f2d7b, _0x7b26b63d _0x069e7999)
    {
        this._0xc974aeb6 = _0x069e7999;
        this._0xfbd1f7af = _0x459f2d7b;
        float _0xcd7d4317 = _0x459f2d7b._0xf088ec11;
        if (_0x069e7999._0x88d48175)
        {
            this._0x3d15d11e = _0x069e7999._0xb347cee3 * _0x459f2d7b._0x6767802c;
            this._0x0500312b = _0x4051eae7.Spawn(_0x29858bd0._0x1f7404ff, this.transform, Vector3.zero, new Vector2(_0x459f2d7b._0x55d00dcd, this._0x3d15d11e), _0x38c6998c.NoteOrder, Color.white);
            this._0xc663f997 = _0x4051eae7.Spawn(_0x29858bd0._0x28a5b233, this.transform, Vector3.zero, new Vector2(_0xcd7d4317, _0xcd7d4317), _0x38c6998c.NoteOrder, Color.white);
            this._0xd4594d47 = _0x4051eae7.Spawn(_0x29858bd0._0xe4d1152b, this.transform, Vector3.zero, new Vector2(_0xcd7d4317, _0xcd7d4317), _0x38c6998c.NoteOrder, Color.white);
        }
        else
        {
            this._0x6dea5977 = _0x4051eae7.Spawn(_0x29858bd0._0xf0f89168, this.transform, Vector3.zero, new Vector2(_0xcd7d4317, _0xcd7d4317), _0x38c6998c.NoteOrder, Color.white);
        }

        this.transform.localPosition = new Vector3(_0x459f2d7b._0xbaa2aba6(_0x069e7999._0x32d0badb), _0x459f2d7b._0xa8ae159e, 0f);
    }

    private float _0x3d15d11e;
}