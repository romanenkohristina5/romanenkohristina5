using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x1fc44a94;

public class _0x0e2f9237 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x0e2f9237>();
    }

    public GameObject BlurBackground;
    public List<_0x3e70f2cb> Pops;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0x60ef6ae8()
    {
        this.LastPopIndexes.Clear();
        this._0x2d7a6fb5();
        foreach (GameObject _0xce812ca0 in this.GameObjectsToHide)
            if (_0xce812ca0 != null)
                _0xce812ca0.SetActive(true);
        this._0x16f29c78();
    }

    public void _0xa4c53cf2(int _0x90de6811)
    {
        this.CurrentPopIndex = _0x90de6811;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x2d7a6fb5(true);
        this._0x7a522338();
        this.Pops[_0x90de6811].Show();
        foreach (GameObject _0xd12b6bcf in this.GameObjectsToHide)
            _0xd12b6bcf.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    private void _0x16f29c78()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public static _0x0e2f9237 Instance;
    public int CurrentPopIndex;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x3e70f2cb _0x4977138e in this.Pops)
            if (_0x4977138e != null)
                _0x4977138e.gameObject.SetActive(true);
    }

    private void _0x2d7a6fb5(bool _0x75eb5777 = false)
    {
        for (int _0xdf19aa50 = 0; _0xdf19aa50 < this.Pops.Count; ++_0xdf19aa50)
            if (this.Pops[_0xdf19aa50] != null && !(_0xdf19aa50 == this.CurrentPopIndex && _0x75eb5777))
                this.Pops[_0xdf19aa50]._0xec0fd8cf();
    }

    public float ScaleDuration = 0.4f;
    public List<int> LastPopIndexes = new();
    private void _0x7a522338()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public _0x3e70f2cb _0x309bc0c4(int _0xf5cd24bf)
    {
        return this.Pops[_0xf5cd24bf];
    }

    public void _0xface4a02()
    {
        this.LastPopIndexes.RemoveAll(_0x3ffb475c => _0x3ffb475c == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x60ef6ae8();
        else
            this._0xa4c53cf2(this.LastPopIndexes.Last());
    }
}