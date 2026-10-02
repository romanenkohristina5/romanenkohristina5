using UnityEngine;
using UnityEngine.EventSystems;

// Touch handling. The template's own InputController exposes nothing public, so taps
// come from UGUI instead: one full-surface catcher converts the pointer position
// through the camera and names the sector. That gives press AND release, which a
// hold mechanic needs, and it is exact on any aspect because camera space is the whole
// screen - no letterbox arithmetic anywhere.
public sealed class _0x99586929 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private int _0xdac8bfd4 = -1;
    private Camera _0x1b1a5e02;
    public void OnPointerUp(PointerEventData _0x58363617)
    {
        if (this._0xdac8bfd4 < 0 || this._0x2502be0b == null)
        {
            return;
        }

        int _0x11fc9406 = this._0xdac8bfd4;
        this._0xdac8bfd4 = -1;
        this._0x2502be0b._0xf96cc960(_0x11fc9406);
    }

    public void OnPointerDown(PointerEventData _0x089c1e99)
    {
        int _0xc8f33842 = this._0x96371bfb(_0x089c1e99);
        if (_0xc8f33842 < 0 || this._0x2502be0b == null)
        {
            return;
        }

        this._0xdac8bfd4 = _0xc8f33842;
        this._0x2502be0b._0xef9dc03f(_0xc8f33842);
    }

    // The whole lower half of the screen answers for a sector, so a tap does not have to
    // land inside a 100 px pad; above the deck the taps are ignored.
    private int _0x96371bfb(PointerEventData _0xa1331c6e)
    {
        if (this._0x30e14044 == null || this._0x1b1a5e02 == null || _0xa1331c6e == null)
        {
            return -1;
        }

        Vector3 _0x9d94e6c4 = _0xa1331c6e.position;
        _0x9d94e6c4.z = -this._0x1b1a5e02.transform.position.z;
        Vector3 _0x0b498791 = this._0x1b1a5e02.ScreenToWorldPoint(_0x9d94e6c4);
        if (_0x0b498791.y > this._0x30e14044._0x20fadef7 + this._0x30e14044._0xb00f69b4 * 0.55f)
        {
            return -1;
        }

        return this._0x30e14044.LaneAt(_0x0b498791.x);
    }

    public void _0x4e815709(_0x38c6998c _0x322960e7, Camera _0xfa062650, _0x2451f585 _0xb3752725)
    {
        this._0x30e14044 = _0x322960e7;
        this._0x1b1a5e02 = _0xfa062650;
        this._0x2502be0b = _0xb3752725;
    }

    private _0x38c6998c _0x30e14044;
    private _0x2451f585 _0x2502be0b;
}