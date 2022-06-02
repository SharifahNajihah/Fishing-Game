using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FishHunter.UIManager
{
    public class UIContentFitter : Singleton<UIContentFitter>
    {
        void Start()
        {
            HorizontalLayoutGroup hg = GetComponent<HorizontalLayoutGroup>();
            int childCount = transform.childCount - 1;
            float childWidth = transform.GetChild(0).GetComponent<RectTransform>().rect.width;
            float width = hg.spacing * childCount + childCount * childWidth + hg.padding.left;

            GetComponent<RectTransform>().sizeDelta = new Vector2(width, 325);
        }
    }
}

