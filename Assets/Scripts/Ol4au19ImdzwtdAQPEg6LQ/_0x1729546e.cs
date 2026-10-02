// One row of the track catalogue. Plain data - no Unity types, so the chart planner
// can be reasoned about (and ported to a simulator) without a scene.
public sealed class _0x1729546e
{
    public float _0xecf8f097
    {
        get
        {
            return 60f / this._0x90e59d31;
        }
    }

    private readonly int _0x93b0e3e0;
    public int _0xe6815054
    {
        get
        {
            return this._0x93b0e3e0;
        }
    }

    private readonly int _0x90e59d31;
    public string _0xf6be4951
    {
        get
        {
            return this._0xfeca687f;
        }
    }

    private readonly float _0x5a7b0bdb;
    private readonly string _0xfeca687f;
    private readonly int _0x4573aa02;
    public _0x1729546e(string _0x9b15f842, int _0x12e74fa2, int _0x33faff51, int _0xf671c3b8, float _0xf48e0c13)
    {
        this._0xfeca687f = _0x9b15f842;
        this._0x90e59d31 = _0x12e74fa2;
        this._0x93b0e3e0 = _0x33faff51;
        this._0x4573aa02 = _0xf671c3b8;
        this._0x5a7b0bdb = _0xf48e0c13;
    }

    // Seconds between consecutive notes on average. Held as data rather than derived
    // from the BPM so the rule C.5 energy arithmetic stays exact per track.
    public float _0x52b53586
    {
        get
        {
            return this._0x5a7b0bdb;
        }
    }

    public int _0x0af37c7a
    {
        get
        {
            return this._0x4573aa02;
        }
    }

    public int _0x78386416
    {
        get
        {
            return this._0x90e59d31;
        }
    }
}