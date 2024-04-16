using UnityEngine;
using UnityEngine.UI;

namespace course.PatronesDiseno.Mediator
{
    public class MainMenu : Menu
    {
        public Button PlayBtn;
        public Button SettingsBtn;
        public Button ExitBtn;
        public override void Hide(){}
        public override void Show(){}
       
        private void Start()
        {
            PlayBtn.onClick.AddListener(() => mediator.GoToPlay());
            SettingsBtn.onClick.AddListener(() => mediator.GoToSettings());
            ExitBtn.onClick.AddListener(() => mediator.GoToExit());
        }
    }
}
