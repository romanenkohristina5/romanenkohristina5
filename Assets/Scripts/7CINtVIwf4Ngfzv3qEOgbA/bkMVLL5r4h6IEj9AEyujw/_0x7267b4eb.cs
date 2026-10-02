using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x1fc44a94;

public class _0x7267b4eb : MonoBehaviour
{
    public void _0x6ddc7496(bool _0x7e593364)
    {
        this._0x9c9f8260 = _0x7e593364;
        this._0x09448ad2(!this._0x9c9f8260);
        Physics2D.simulationMode = this._0x9c9f8260 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x79b29e8d(this.EnvironmentWithTweensToToggle);
    }

    private void _0x09448ad2(bool _0xf9b16714)
    {
        Rigidbody2D[] _0xd07a7725 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x08a9eaf8 in _0xd07a7725)
            if (_0xf9b16714)
                _0x08a9eaf8.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x08a9eaf8.constraints = RigidbodyConstraints2D.None;
    }

    public static bool IsAfterLevelComplete;
    public bool _0x9c9f8260 { get; private set; }

    public Canvas MainCanvas;
    private IEnumerator _0x1f06062f(int _0x2c92b0b8)
    {
        _0x9ae3504d.Instance._0xdb936680(_0x517a5fb9.SPLASH);
        AsyncOperation _0x7f281931 = SceneManager.LoadSceneAsync(_0x2c92b0b8);
        while (!_0x7f281931.isDone)
            yield return null;
    }

    public static _0xf562e0d0 _0xedb96a45 => _0xf562e0d0.ALL_SCENES_SETTING_SINGLETONS[Instance._0xd330c942];

    private IEnumerator _0x09d9affd(string _0x3e41bbc8)
    {
        _0x9ae3504d.Instance._0xdb936680(_0x517a5fb9.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x9664c03d = SceneManager.LoadSceneAsync(_0x3e41bbc8);
        while (!_0x9664c03d.isDone)
            yield return null;
    }

    public void _0x7d601f0b()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public Button DeleteProgressDataButton;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void LoadSceneByIndex(int _0xee4cbc14)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x1f06062f(_0xee4cbc14));
    }

    public void _0xec323a3d()
    {
        _0xedb96a45._0xb72b17dc = true;
    }

    [HideInInspector]
    public List<_0x54276775> MoneyCountContainers = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x7267b4eb>();
        this.RootGameObject = GameObject.FindWithTag(_0x83e6ce5d._0xf8d66dd7(new byte[4] { 97, 92, 92, 71 }, 51));
        if (this._0xd330c942 == _0x98dd0d5d.SCENE_0)
            this._0x6ddc7496(true);
        else
            this._0x6ddc7496(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x54276775>(true).ToList();
    }

    public Button ShowResetTutorialButton;
    public static bool IsAfterLevelFailed = false;
    private static _0xf562e0d0 _0xe14c6250 => _0xf562e0d0.ALL_SCENES_SETTING_SINGLETONS[0];

    private static void MakeGrid(List<RectTransform> _0x58767561, AspectRatioFitter _0x6935e941, float _0x68cb709d, int _0x26ee94f2, int _0x8a86e3e4)
    {
        _0x6935e941.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x6935e941.aspectRatio = _0x68cb709d;
        foreach (RectTransform _0xeb899c25 in _0x58767561)
        {
            int _0x32ce245d = _0xeb899c25.transform.GetSiblingIndex();
            _0xeb899c25.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x32ce245d % _0x26ee94f2) * (1f / _0x26ee94f2), (_0x8a86e3e4 - (Mathf.FloorToInt((float)_0x32ce245d / _0x26ee94f2) % _0x8a86e3e4 + 1f)) * (1f / _0x8a86e3e4));
            _0xeb899c25.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x32ce245d % _0x26ee94f2 + 1f) * (1f / _0x26ee94f2), (_0x8a86e3e4 - Mathf.FloorToInt((float)_0x32ce245d / _0x26ee94f2) % _0x8a86e3e4) * (1f / _0x8a86e3e4));
            _0xeb899c25.offsetMin = Vector2.zero;
            _0xeb899c25.offsetMax = Vector2.zero;
        }
    }

    public int _0xd330c942 => SceneManager.GetActiveScene().buildIndex;

    public Transform EnvironmentWithTweensToToggle;
    private static _0xf562e0d0 GAME_INDEX_SETTINGS(int _0x2032f153)
    {
        return _0xf562e0d0.ALL_SCENES_SETTING_SINGLETONS[_0x2032f153];
    }

    public void _0xf9248276()
    {
        foreach (_0x54276775 _0x4d98b463 in this.MoneyCountContainers)
            _0x4d98b463._0x07803faf();
    }

    public Transform Environment;
    private void _0xe5334b0a()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x98dd0d5d.SCENE_0);
    }

    private void _0x79b29e8d(Transform _0xbf7cfc9f)
    {
        Transform[] _0xc259bc3e = _0xbf7cfc9f.GetComponentsInChildren<Transform>();
        foreach (Transform _0x29a79e23 in _0xc259bc3e)
            if (_0x29a79e23 != null && DOTween.IsTweening(_0x29a79e23))
            {
                if (this._0x9c9f8260)
                    DOTween.Play(_0x29a79e23);
                else
                    DOTween.Pause(_0x29a79e23);
            }
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void Start()
    {
        if (this._0xd330c942 != _0x98dd0d5d.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x98dd0d5d.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xedb96a45._0xb72b17dc = false;
            _0x0e2f9237.Instance._0x60ef6ae8();
            _0x9ae3504d.Instance._0xdb936680(_0x517a5fb9.TUTORIAL0);
        });
    }

    public static _0x7267b4eb Instance;
}

internal static class _0x83e6ce5d
{
    internal static string _0xf8d66dd7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}