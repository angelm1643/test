using UnityEngine;
using UnityEngine.UI;

namespace course.PatronesDiseno.Mediator
{
    public class SettingsMenu : Menu
    {
        public Button BackBtn;

        public override void Hide() { }
        public override void Show() { }

        private void Start()
        {
            BackBtn.onClick.AddListener(() => mediator.GoToMainMenu());

        }
    }
}
