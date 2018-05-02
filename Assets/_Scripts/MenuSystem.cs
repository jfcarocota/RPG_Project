using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

namespace GameUtils
{
    namespace MenusSystem
    {
        public class MenuSystem : MonoBehaviour
        {
            [SerializeField]
            Transform optionsParent;
            [SerializeField]
            EventSystem eventSystem;
            [SerializeField]
            List<Button> buttons;

            [SerializeField]
            protected Image fadePanel;
            CanvasRenderer cvr;

            IEnumerator checkMenu;


            protected void Start()
            {
                checkMenu = CheckMenu(0);
                cvr = fadePanel.GetComponent<CanvasRenderer>();
                fadePanel.CrossFadeAlpha(0, 1f, false);
                InitializeMenu();
                StartCoroutine(checkMenu);
            }

            public void InitializeMenu()
            {

                for (int i = 0; i < optionsParent.childCount; i++)
                {
                    Button button = optionsParent.GetChild(i).GetComponent<Button>();
                    buttons.Add(button);
                }

                Button first = buttons[0];
                Button last = buttons.Last<Button>();
                Navigation btnFisrtNav = first.navigation;
                Navigation btnLasttNav = last.navigation;
                btnFisrtNav.mode = Navigation.Mode.Explicit;
                btnLasttNav.mode = Navigation.Mode.Explicit;
                btnFisrtNav.selectOnUp = last;
                btnFisrtNav.selectOnDown = buttons[1];
                btnLasttNav.selectOnUp = buttons[buttons.Count - 2];
                btnLasttNav.selectOnDown = first;
                first.navigation = btnFisrtNav;
                last.navigation = btnLasttNav;
            }

            protected bool MenuEnabled
            {
                get { return cvr.GetAlpha() == 0f; }
            }

            protected bool MenuDesabled
            {
                get { return cvr.GetAlpha() == 1f; }
            }

            IEnumerator CheckMenu(float delay)
            {
                while (!MenuEnabled)
                {
                    yield return new WaitForSeconds(delay);
                }
                
                eventSystem.firstSelectedGameObject = buttons[0].gameObject;
                buttons[0].Select();
            }

            protected void FadeOut()
            {
                cvr.SetAlpha(0f);
                fadePanel.CrossFadeAlpha(255f, 1f, false);
            }
        }
    }
}
