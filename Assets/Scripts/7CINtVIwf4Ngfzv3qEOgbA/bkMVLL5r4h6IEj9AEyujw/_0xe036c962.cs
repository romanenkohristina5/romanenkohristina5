using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xe036c962 : MonoBehaviour
{
    private Touch? _0x456a63a2()
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
            return null;
        foreach (Touch _0xfc80fa9b in Touch.activeTouches)
            if (_0xfc80fa9b.ended)
                if (this._0xcec182fb(_0xfc80fa9b))
                    return _0xfc80fa9b;
        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x5d1c786d(Bounds _0x7b2a2525, TouchPhase _0x3ab1e65b)
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
            return null;
        foreach (Touch _0x6aab109c in Touch.activeTouches)
            if (_0x6aab109c.phase == _0x3ab1e65b)
            {
                Vector3 _0x44bb9446 = Camera.main.ScreenToWorldPoint(_0x6aab109c.screenPosition);
                Vector3 _0x82c5a9a4 = new(_0x44bb9446.x, _0x44bb9446.y, _0x7b2a2525.center.z);
                if (_0x7b2a2525.Contains(_0x82c5a9a4) && this._0xcec182fb(_0x6aab109c))
                    return _0x6aab109c;
            }

        return null;
    }

    private Touch? _0x4630e06d()
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
            return null;
        foreach (Touch _0xc457f172 in Touch.activeTouches)
            if (!_0xc457f172.ended)
                if (this._0xcec182fb(_0xc457f172))
                    return _0xc457f172;
        return null;
    }

    private Touch? _0x4e6f8289(Bounds _0x20068560)
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
            return null;
        foreach (Touch _0xc0083059 in Touch.activeTouches)
            if (_0xc0083059.ended)
            {
                Vector3 _0xff243aa6 = Camera.main.ScreenToWorldPoint(_0xc0083059.screenPosition);
                Vector3 _0xaf0d33db = new(_0xff243aa6.x, _0xff243aa6.y, _0x20068560.center.z);
                if (_0x20068560.Contains(_0xaf0d33db) && this._0xcec182fb(_0xc0083059))
                    return _0xc0083059;
            }

        return null;
    }

    private bool _0x108710e8(Touch? _0xec7646c2, Bounds _0x5ae3bf7d, TouchPhase _0x8a2da4fd)
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
        {
            _0xec7646c2 = null;
            return false;
        }

        if (_0xec7646c2 != null)
            if (_0xec7646c2.Value.phase == _0x8a2da4fd)
            {
                Vector3 _0xc1a3d3aa = Camera.main.ScreenToWorldPoint(_0xec7646c2.Value.screenPosition);
                Vector3 _0x07fe4a7f = new(_0xc1a3d3aa.x, _0xc1a3d3aa.y, _0x5ae3bf7d.center.z);
                if (_0x5ae3bf7d.Contains(_0x07fe4a7f) && this._0xcec182fb(_0xec7646c2.Value))
                    return true;
            }

        return false;
    }

    private bool _0xcec182fb(Touch? _0xb89544c2)
    {
        if (!_0xb89544c2.HasValue)
            return false;
        Vector3 _0x950b1542 = Camera.main.ScreenToWorldPoint(_0xb89544c2.Value.screenPosition);
        Vector3 _0xf3767bb9 = _0x950b1542;
        _0xf3767bb9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xf3767bb9))
            return true;
        _0xb89544c2 = null;
        return false;
    }

    private static _0xe036c962 _0x4997a0ca;
    private void _0xc3579b0c(Touch? _0x33807883)
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
        {
            _0x33807883 = null;
            return;
        }

        int _0x623c53ec = _0x33807883.Value.touchId;
        _0x33807883 = Touch.activeTouches.FirstOrDefault(_0x9eeda348 => _0x9eeda348.touchId == _0x623c53ec);
        if (!this._0xcec182fb(_0x33807883.Value))
            _0x33807883 = null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x4997a0ca = this.gameObject.GetComponent<_0xe036c962>();
    }

    private Touch? _0x6c23e78c(Bounds _0x65343cbe)
    {
        if (!_0x7267b4eb.Instance._0x9c9f8260)
            return null;
        foreach (Touch _0x17929e02 in Touch.activeTouches)
            if (!_0x17929e02.ended)
            {
                Vector3 _0x0362f172 = Camera.main.ScreenToWorldPoint(_0x17929e02.screenPosition);
                Vector3 _0xbdb18c51 = new(_0x0362f172.x, _0x0362f172.y, _0x65343cbe.center.z);
                if (_0x65343cbe.Contains(_0xbdb18c51) && this._0xcec182fb(_0x17929e02))
                    return _0x17929e02;
            }

        return null;
    }
}