using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x1fc44a94;

public class _0x9ae3504d : MonoBehaviour
{
    public float StaticBlurMaterialInitialValue;
    private void _0xbc893796(int _0xc26e7770)
    {
        this.LastPanelIndexes.Add(_0xc26e7770);
        this.CurrentPanelIndex = _0xc26e7770;
        for (int _0x35abdf34 = 0; _0x35abdf34 < this.Panels.Count; _0x35abdf34++)
            if (_0x35abdf34 != _0xc26e7770 && this.Panels[_0x35abdf34] != null)
                this.Panels[_0x35abdf34]._0x3cbfe248();
    }

    private void _0x4fcc6ac9(int _0xefa425e6)
    {
        this._0xbc893796(_0xefa425e6);
        this._0x07204bf0(_0xefa425e6);
        this.CurrentPanelIndex = _0xefa425e6;
        this.Panels[_0xefa425e6]._0x35597722();
    }

    public void _0xd037a24f(int _0x1e2efef2)
    {
        if (_0x1e2efef2 == _0x517a5fb9.SPLASH && _0x7267b4eb.Instance._0xd330c942 != _0x98dd0d5d.SCENE_0)
            _0xc587caa3.Instance._0x170e01af();
        if (_0x7267b4eb.Instance._0xd330c942 != _0x98dd0d5d.SCENE_0)
        {
            if (_0x1e2efef2 == _0x517a5fb9.SPLASH || _0x1e2efef2 == _0x517a5fb9.TUTORIAL0)
                _0x7267b4eb.Instance._0x6ddc7496(false);
            else if (_0x1e2efef2 == _0x517a5fb9.DEFAULT)
                _0x7267b4eb.Instance._0x6ddc7496(true);
        }
    }

    public static _0x9ae3504d Instance;
    private void Start()
    {
        this._0xe1b6321f();
    }

    private void SwitchSplash()
    {
        if (_0xa54f90d7.Instance.IsTutorialEnabled && !_0x7267b4eb._0xedb96a45._0xb72b17dc)
            this._0xdb936680(_0x517a5fb9.TUTORIAL0);
        else
            this._0xdb936680(_0x517a5fb9.DEFAULT);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x9ae3504d>();
    }

    public void _0x2e52709f()
    {
        this.LastPanelIndexes.RemoveAll(_0x3ffb475c => _0x3ffb475c == this.CurrentPanelIndex);
        int _0x7d18c18d = this.LastPanelIndexes.Last();
        this._0x07204bf0(_0x7d18c18d);
        this._0xa4ddc201(_0x7d18c18d);
        this.CurrentPanelIndex = _0x7d18c18d;
        this.Panels[_0x7d18c18d].Show();
    }

    public List<_0xc91fa104> Panels;
    public void _0xdb936680(int _0x76e94185)
    {
        this._0xbc893796(_0x76e94185);
        this._0x07204bf0(_0x76e94185);
        this.CurrentPanelIndex = _0x76e94185;
        this.Panels[_0x76e94185].Show();
    }

    private _0xc91fa104 _0x9af15d8c(int _0x20116f7e)
    {
        return this.Panels[_0x20116f7e];
    }

    public int CurrentPanelIndex;
    private void _0xa4ddc201(int _0x33cf42e9)
    {
        this.LastPanelIndexes.Add(_0x33cf42e9);
        this.CurrentPanelIndex = _0x33cf42e9;
        for (int _0x6a540362 = 0; _0x6a540362 < this.Panels.Count; _0x6a540362++)
            if (_0x6a540362 != _0x33cf42e9 && this.Panels[_0x6a540362] != null)
                this.Panels[_0x6a540362]._0x3cbfe248();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public float ScaleDuration = 0.4f;
    private void _0xe1b6321f()
    {
        this._0x4fcc6ac9(_0x517a5fb9.SPLASH);
        if (_0x7267b4eb.Instance._0xd330c942 == _0x98dd0d5d.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xc587caa3.Instance.DefaultAnimationTime);
        }
    }

    public bool IsShowSplashOnStart = true;
    private void _0x07204bf0(int _0x486ded4b)
    {
        if (_0x486ded4b == _0x517a5fb9.SPLASH)
            _0xc587caa3.Instance._0xe77e3aaf();
        if (_0x7267b4eb.Instance._0xd330c942 == _0x98dd0d5d.SCENE_0)
        {
        }
    }
}