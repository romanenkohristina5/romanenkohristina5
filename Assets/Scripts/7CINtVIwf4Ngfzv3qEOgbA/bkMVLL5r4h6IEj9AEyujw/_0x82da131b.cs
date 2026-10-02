using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x82da131b : MonoBehaviour
{
    private void _0xdde441b8()
    {
        if (this.ScoreCurrent > _0x7267b4eb._0xedb96a45._0xaeb58d8d)
            _0x7267b4eb._0xedb96a45._0xaeb58d8d = this.ScoreCurrent;
        if (_0xa54f90d7.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x2255d203)
                this._0x78ac696c();
    }

    public List<TMP_Text> ScoreText = new();
    public int CustomTargetScore = 10;
    private IEnumerator _0xd375dcc3()
    {
        this._0x37f8fd35();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x7267b4eb.Instance._0xd330c942 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x7267b4eb.Instance._0x9c9f8260)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x37f8fd35();
            }
        }

        if (!this.IsGameEnd)
            this._0xd866fb46();
    }

    public void _0x78ac696c()
    {
        if (!this.IsGameEnd)
        {
            this._0x5820dd33();
            _0x7267b4eb.IsAfterLevelComplete = true;
            _0x7267b4eb.IsAfterLevelFailed = false;
            _0x3e70f2cb _0xb26c91da = _0x0e2f9237.Instance._0x309bc0c4(_0x1fc44a94._0xac09a5ba.WIN).GetComponent<_0x3e70f2cb>();
            if (_0xa54f90d7.Instance.IsCheckScoreEnabled)
                _0xb26c91da.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x2255d203}";
            else
                _0xb26c91da.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xa54f90d7.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x1fc44a94._0x9d1bd943._0x9c696c79)
                    _0x1fc44a94._0x9d1bd943._0x9c696c79 = this.ScoreCurrent;
                _0xb26c91da.ContentAdditionalText.text = $"{_0x1fc44a94._0x9d1bd943._0x9c696c79}";
            }
            else
            {
                _0xb26c91da.ContentAdditionalText.text = $"{this._0xac89ebf5}";
                _0x1fc44a94._0x9d1bd943._0x9c696c79 += this._0xac89ebf5;
            }

            if (_0xa54f90d7.Instance.IsLevelIncrementOnWin)
                ++_0x7267b4eb._0xedb96a45._0x3487e5dc;
            _0x0e2f9237.Instance._0xa4c53cf2(_0x1fc44a94._0xac09a5ba.WIN);
        }
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x0633c7ab;
        this.CurrentGameIndex = _0x7267b4eb.Instance._0xd330c942;
        foreach (Button _0x3b6eb8ee in this.HomeButtons)
            _0x3b6eb8ee.onClick.AddListener(() =>
            {
                this._0x87e34810();
            });
        foreach (Button _0x51861af0 in this.PauseButtons)
            _0x51861af0.onClick.AddListener(() =>
            {
                _0x7267b4eb.Instance._0x6ddc7496(false);
                _0x0e2f9237.Instance._0xa4c53cf2(_0x1fc44a94._0xac09a5ba.PAUSE);
            });
        this._0xd81a6878();
        this.LevelNumberText.ForEach(_0xe2312c9e => _0xe2312c9e.text = $"LVL {_0x7267b4eb._0xedb96a45._0x3487e5dc + 1}");
        if (_0xa54f90d7.Instance.IsTimerEnabled)
        {
            this._0x37f8fd35();
            this.StartCoroutine(this._0xd375dcc3());
        }
    }

    private void _0xd81a6878()
    {
        if (_0xa54f90d7.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xe2312c9e => _0xe2312c9e.text = $"{this.ScoreCurrent}/{this._0x2255d203}");
        else
            this.ScoreText.ForEach(_0xe2312c9e => _0xe2312c9e.text = $"{this.ScoreCurrent}");
    }

    public void _0xd866fb46()
    {
        if (_0xa54f90d7.Instance.IsOnlyWinGameEndEnabled)
            this._0x78ac696c();
        if (!this.IsGameEnd)
        {
            this._0x5820dd33();
            _0x7267b4eb.IsAfterLevelComplete = false;
            _0x7267b4eb.IsAfterLevelFailed = true;
            _0x3e70f2cb _0xa8614ed5 = _0x0e2f9237.Instance._0x309bc0c4(_0x1fc44a94._0xac09a5ba.LOSE).GetComponent<_0x3e70f2cb>();
            if (_0xa54f90d7.Instance.IsCheckScoreEnabled)
                _0xa8614ed5.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x2255d203}";
            else
                _0xa8614ed5.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xa8614ed5.ContentAdditionalText.text = $"{0}";
            _0x1fc44a94._0x9d1bd943._0x9c696c79 += 0;
            _0x0e2f9237.Instance._0xa4c53cf2(_0x1fc44a94._0xac09a5ba.LOSE);
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> LevelNumberText = new();
    private int _0x0633c7ab => this.CustomTimeInitial + _0x7267b4eb._0xedb96a45._0x3487e5dc * 10;
    private int _0x2255d203 => this.CustomTargetScore + _0x7267b4eb._0xedb96a45._0x3487e5dc * 10;

    public void _0xe878a921(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xd81a6878();
            this._0xdde441b8();
        }
    }

    private void _0x54054d27()
    {
        if (this.ScoreCurrent >= this._0x2255d203)
            this._0x78ac696c();
        else
            this._0xd866fb46();
    }

    private static _0x82da131b _0xaf818e26;
    public List<Button> HomeButtons = new();
    private void _0x5820dd33()
    {
        this.IsGameEnd = true;
        _0x7267b4eb.IsAfterLevelComplete = true;
    }

    [HideInInspector]
    public int CurrentGameIndex;
    private int _0xac89ebf5 => this.ScoreCurrent;

    public void _0x87e34810()
    {
        _0x7267b4eb.Instance._0x6ddc7496(true);
        _0x7267b4eb.Instance.LoadSceneByIndex(_0x1fc44a94._0x98dd0d5d.SCENE_0);
    }

    [HideInInspector]
    public int TimeLeft;
    private void _0x37f8fd35()
    {
        this.TimerText.ForEach(_0xe2312c9e => _0xe2312c9e.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xded40d0a._0x10f50114(new byte[6] { 161, 161, 144, 246, 191, 191 }, 204)));
    }

    public List<Button> PauseButtons = new();
    private void Awake()
    {
        _0xaf818e26 = this.gameObject.GetComponent<_0x82da131b>();
    }

    [HideInInspector]
    public bool IsGameEnd;
    public List<TMP_Text> SubtitleText = new();
    public int CustomTimeInitial = 30;
    public List<TMP_Text> TimerText = new();
}

internal static class _0xded40d0a
{
    internal static string _0x10f50114(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}