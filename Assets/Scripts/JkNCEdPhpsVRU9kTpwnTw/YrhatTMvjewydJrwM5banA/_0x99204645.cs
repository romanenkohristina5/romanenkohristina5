using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x99204645 : MonoBehaviour
{
    private Vector3 _0x95aed7b3 { get; set; }
    private Vector3 _0x66d92d37 { get; set; }

    private Color _0xdf8b863c = Color.white;
    private new Camera _0x7154fd04;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xdf8b863c;
        Matrix4x4 _0x273a1b22 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x7154fd04.orthographic)
        {
            float _0x2e94e16f = this._0x7154fd04.farClipPlane - this._0x7154fd04.nearClipPlane;
            float _0xe60fa600 = (this._0x7154fd04.farClipPlane + this._0x7154fd04.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xe60fa600), new Vector3(this._0x7154fd04.orthographicSize * 2 * this._0x7154fd04.aspect, this._0x7154fd04.orthographicSize * 2, _0x2e94e16f));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x7154fd04.fieldOfView, this._0x7154fd04.farClipPlane, this._0x7154fd04.nearClipPlane, this._0x7154fd04.aspect);
        }

        Gizmos.matrix = _0x273a1b22;
    }

    private _0xa5801156 _0x4e852635 = _0xa5801156.Portrait;
    private Vector3 _0x918f6e75 { get; set; }
    private Vector3 _0x82231c79 { get; set; }
    private Vector3 _0x656b2d4e { get; set; }
    //public bool executeInUpdate;
    private float _0x133e79c5 { get; set; }
    private Vector3 _0x061a4cc4 { get; set; }
    private float _0x8283c52d { get; set; }

    private void Awake()
    {
        this._0x7154fd04 = this.GetComponent<Camera>();
        _0x36fd4304 = this;
        this._0x25d3a68f();
    }

    private Vector3 _0x92e711d4 { get; set; }

    private float _0xaf43314a = 1;
    private void _0x25d3a68f()
    {
        float _0x392a4927, _0x09717912, _0x83c4a065, _0x0e166925;
        if (this._0x4e852635 == _0xa5801156.Landscape)
            this._0x7154fd04.orthographicSize = 1f / this._0x7154fd04.aspect * this._0xaf43314a / 2f;
        else
            this._0x7154fd04.orthographicSize = this._0xaf43314a / 2f;
        this._0x8283c52d = 2f * this._0x7154fd04.orthographicSize;
        this._0x133e79c5 = this._0x8283c52d * this._0x7154fd04.aspect;
        float _0xd4bd964e = this._0x7154fd04.transform.position.x;
        float _0xd38b8922 = this._0x7154fd04.transform.position.y;
        _0x392a4927 = _0xd4bd964e - this._0x133e79c5 / 2;
        _0x09717912 = _0xd4bd964e + this._0x133e79c5 / 2;
        _0x83c4a065 = _0xd38b8922 + this._0x8283c52d / 2;
        _0x0e166925 = _0xd38b8922 - this._0x8283c52d / 2;
        this._0x07495ee7 = new Vector3(_0x392a4927, _0x0e166925, 0);
        this._0x66d92d37 = new Vector3(_0xd4bd964e, _0x0e166925, 0);
        this._0x82231c79 = new Vector3(_0x09717912, _0x0e166925, 0);
        this._0x918f6e75 = new Vector3(_0x392a4927, _0xd38b8922, 0);
        this._0x656b2d4e = new Vector3(_0xd4bd964e, _0xd38b8922, 0);
        this._0x061a4cc4 = new Vector3(_0x09717912, _0xd38b8922, 0);
        this._0x8b53e86e = new Vector3(_0x392a4927, _0x83c4a065, 0);
        this._0x95aed7b3 = new Vector3(_0xd4bd964e, _0x83c4a065, 0);
        this._0x92e711d4 = new Vector3(_0x09717912, _0x83c4a065, 0);
    }

    private Vector3 _0x8b53e86e { get; set; }

    private static _0x99204645 _0x36fd4304;
    private Vector3 _0x07495ee7 { get; set; }

    public enum _0xa5801156
    {
        Landscape,
        Portrait
    }
}