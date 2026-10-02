using UnityEngine;

// Rule C.0: every world size comes from the camera, never from a literal and never
// from a sprite's native pixel size. One instance is built per scene and handed to
// everything that needs to place something in the shaft.
//
// Sorting orders live here as named constants (rule: no inline numbers). The whole
// block sits inside -19..-1: the background canvas is -30 and every panel/pop canvas
// is 0 or above, so gameplay art can never cover a result card.
public sealed class _0x38c6998c
{
    private readonly float _0xb0b4046d;
    public float _0x2d63c806
    {
        get
        {
            return this._0x6b5be7c8 * 0.93f;
        }
    }

    public float _0xa94fed17
    {
        get
        {
            return this._0x6b5be7c8;
        }
    }

    public Vector2 _0xa965e0d3
    {
        get
        {
            return new Vector2(this._0x6b5be7c8 * 0.13f, this._0xb0b4046d * 0.036f);
        }
    }

    public Vector2 _0x1a069564
    {
        get
        {
            return new Vector2(this._0x6b5be7c8 * 0.022f, this._0xb0b4046d * 1.4f);
        }
    }

    // ---- derived sizes, all expressed as fractions of the camera half-extents ----
    public Vector2 _0x3b69eb9b
    {
        get
        {
            return new Vector2(this._0xb99a2e38 + this._0xded39d46 * 0.22f, this._0xb0b4046d * 1.9f);
        }
    }

    public Vector2 _0x26cee6e7
    {
        get
        {
            return new Vector2(this._0x6b5be7c8 * 0.069f, this._0xb0b4046d * 2f);
        }
    }

    public float _0xa0eb066f
    {
        get
        {
            return this._0xded39d46 * 0.975f;
        }
    }

    public float _0x47a0ebc5
    {
        get
        {
            return this._0xded39d46 * 0.812f;
        }
    }

    public float _0xea490e7e
    {
        get
        {
            return this._0xded39d46 * 1.007f;
        }
    }

    public float _0x6767802c
    {
        get
        {
            return (this._0xa8ae159e - this._0x20fadef7) / _0xd04e59fe.ApproachSeconds;
        }
    }

    public float _0x0b249945
    {
        get
        {
            return this._0xb0b4046d * 0.72f;
        }
    }

    public float _0x205989c7
    {
        get
        {
            return this._0xded39d46;
        }
    }

    public float _0xf8908878
    {
        get
        {
            return this._0xb99a2e38;
        }
    }

    private readonly float[] _0xef8dca08;
    public const int SectorPadOrder = -9;
    public const int LaneCount = 3;
    public const int DeckOrder = -11;
    public float _0xb00f69b4
    {
        get
        {
            return this._0xb0b4046d;
        }
    }

    public float _0xfd2af970
    {
        get
        {
            return -this._0x6b5be7c8 * 0.944f;
        }
    }

    public Vector2 _0xc39a4053
    {
        get
        {
            return new Vector2(this._0xb99a2e38, this._0xb0b4046d * 0.02f);
        }
    }

    public float _0x20fadef7
    {
        get
        {
            return -this._0xb0b4046d * 0.62f;
        }
    }

    // Square content sprites keep a square footprint so the aspect of the source PNG
    // survives (rule F.2a); only the beam body is stretched, along one axis.
    public float _0xf088ec11
    {
        get
        {
            return this._0xded39d46 * 0.666f;
        }
    }

    private readonly float _0xded39d46;
    public const int NoteOrder = -6;
    public const int HitRingOrder = -7;
    public float _0x317fdc6b
    {
        get
        {
            return this._0x484581e4 + this._0xb0b4046d * 0.124f;
        }
    }

    public const int LaneDividerOrder = -15;
    private readonly float _0xb99a2e38;
    public const int BurstOrder = -3;
    public const int PilotLineOrder = -8;
    public Vector2 _0x073f9aa1
    {
        get
        {
            return new Vector2(this._0xb99a2e38, this._0xb0b4046d * 0.016f);
        }
    }

    public const int FloorMarkOrder = -16;
    private readonly float _0x6b5be7c8;
    public float _0xc9d36fe0
    {
        get
        {
            return -this._0xb0b4046d * 0.48f;
        }
    }

    public float _0xa8ae159e
    {
        get
        {
            return this._0xb0b4046d * 1.12f;
        }
    }

    public float _0x484581e4
    {
        get
        {
            return -this._0xb0b4046d * 0.75f;
        }
    }

    public float _0xbaa2aba6(int _0xdd0dd7bd)
    {
        int _0x61fd9772 = Mathf.Clamp(_0xdd0dd7bd, 0, LaneCount - 1);
        return this._0xef8dca08[_0x61fd9772];
    }

    public _0x38c6998c(Camera _0x732a7111)
    {
        float _0xabdc8db4 = _0x732a7111 != null ? _0x732a7111.orthographicSize : 5f;
        float _0x05aafd6a = _0x732a7111 != null ? _0x732a7111.aspect : (9f / 19.5f);
        this._0xb0b4046d = _0xabdc8db4;
        this._0x6b5be7c8 = _0xabdc8db4 * _0x05aafd6a;
        // 0.80 rather than 0.86: the altimeter gutter on the left needs a clear x-band
        // of its own (rule C.25), and 0.80 leaves it ~0.19 units.
        this._0xb99a2e38 = 2f * this._0x6b5be7c8 * 0.80f;
        this._0xded39d46 = this._0xb99a2e38 / LaneCount;
        this._0xef8dca08 = new float[LaneCount];
        for (int _0xe2c27132 = 0; _0xe2c27132 < LaneCount; _0xe2c27132++)
        {
            this._0xef8dca08[_0xe2c27132] = (_0xe2c27132 - 1) * this._0xded39d46;
        }
    }

    // The sector a world x belongs to. The NEAREST sector always wins, so the outer
    // tenth of the screen - which is outside the shaft itself - still answers for the
    // sector beside it instead of swallowing the tap.
    public int LaneAt(float _0x16a7d34d)
    {
        int _0x5e6a825f = 0;
        float _0x075fbf2e = Mathf.Abs(_0x16a7d34d - this._0xef8dca08[0]);
        for (int _0xe152d410 = 1; _0xe152d410 < LaneCount; _0xe152d410++)
        {
            float _0x56616d9e = Mathf.Abs(_0x16a7d34d - this._0xef8dca08[_0xe152d410]);
            if (_0x56616d9e < _0x075fbf2e)
            {
                _0x075fbf2e = _0x56616d9e;
                _0x5e6a825f = _0xe152d410;
            }
        }

        return _0x5e6a825f;
    }

    public const int RailOrder = -18;
    public float _0x55d00dcd
    {
        get
        {
            return this._0xded39d46 * 0.60f;
        }
    }

    public const int CarOrder = -5;
    public Vector2 _0xca8989f6
    {
        get
        {
            return new Vector2(this._0xb99a2e38, this._0xb0b4046d * 0.20f);
        }
    }

    public const int BackdropOrder = -19;
    public Vector2 _0x0c17f921
    {
        get
        {
            return new Vector2(this._0xded39d46 * 0.89f, this._0xb0b4046d * 0.104f);
        }
    }

    public const int AltimeterOrder = -14;
}