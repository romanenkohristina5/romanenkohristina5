using UnityEngine;
using UnityEngine.UI;

public class _0x1435a934 : MonoBehaviour
{
    public bool IsTutorialEndPanel;
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x9ae3504d.Instance._0xdb936680(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x7267b4eb.Instance._0xec323a3d());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x9ae3504d.Instance._0xdb936680(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x9ae3504d.Instance._0xdb936680(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x7267b4eb.Instance._0xec323a3d());
        }
    }
}