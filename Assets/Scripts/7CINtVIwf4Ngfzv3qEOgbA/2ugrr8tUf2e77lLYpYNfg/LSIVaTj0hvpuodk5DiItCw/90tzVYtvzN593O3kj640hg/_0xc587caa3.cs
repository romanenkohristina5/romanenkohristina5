using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xc587caa3 : MonoBehaviour
{
    public GameObject Error;
    public float DefaultAnimationTime = 0.4f;
    public float FirstAnimationTime = 10.0f;
    public void _0x170e01af()
    {
        this._0xe77e3aaf();
        bool _0x14056c2c = _0xd10d1b9f;
        this._0xa4279dba = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xd67b8405 => this.AnimationSlider.value = _0xd67b8405, _0x14056c2c ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xd10d1b9f = !_0xd10d1b9f;
    }

    public void _0x440b57be()
    {
        this._0xa4279dba?.Pause();
    }

    private void _0xf487e807()
    {
        this.AnimationSlider.value = 0.05f;
        _0xd10d1b9f = !_0xd10d1b9f;
        this._0xa4279dba = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xd67b8405 => this.AnimationSlider.value = _0xd67b8405, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x7dc557d6._0x562e499c?._0xfd041e27();
        });
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x1fc44a94._0x98dd0d5d.SCENE_0 && !_0xd10d1b9f)
        {
            this._0xf487e807();
        }
        else
        {
            this._0x170e01af();
        }
    }

    public void _0xe77e3aaf()
    {
        this._0xa4279dba?.Kill();
        this.AnimationSlider.value = _0xd10d1b9f ? this.SecondPassSliderValue : 0.05f;
    }

    private static bool _0xd10d1b9f = false;
    private Sequence _0xa4279dba;
    public float SecondPassSliderValue = 0.5f;
    public void _0x8f69ae24()
    {
        this._0xa4279dba?.Play();
    }

    public GameObject Background;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc587caa3>();
    }

    public static _0xc587caa3 Instance;
    public Slider AnimationSlider;
    public void _0x43013d7b()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xa4279dba?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xd10d1b9f = false;
    }

    public GameObject Content;
}