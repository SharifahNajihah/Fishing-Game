using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace FishHunter.UIManager
{
    public class ButtonManager : Singleton<ButtonManager>
    {
        private Button btn;
        [SerializeField] private RawImage buttonImage;

        private int _itemID;
        private Sprite _buttonTexture;

        public Sprite ButtonTexture
        {
            set
            {
                _buttonTexture = value;
                buttonImage.texture = _buttonTexture.texture;
            }
        }

        public int ItemId
        {
            set { _itemID = value; }
        }


        void Start()
        {
            btn = GetComponent<Button>();
            btn.onClick.AddListener(SelectObject);

        }


        void Update()
        {
            if (UIManager.Instance.OnEntered(gameObject))
            {
                transform.DOScale(Vector3.one * 2, 0.3f);
                //transform.localScale = Vector3.one * 2;
            }
            else
            {
                transform.DOScale(Vector3.one, 0.3f);
                //transform.localScale = Vector3.one;
            }
        }

        void SelectObject()
        {
            DataHandler.Instance.SetFish(_itemID);
            Debug.Log("Clicked");

        }
    }
}


