using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fastory.Helper;

namespace Fastory.UI
{
    public sealed class ButtonHandler : MonoBehaviour
    {
        public void OpenAndCloseUIPanel (GameObject panel) => panel.SetActive(!panel.activeInHierarchy);
        
    }
}

