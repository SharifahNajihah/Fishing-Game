using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

namespace FishHunter.UIManager
{
    public class DataHandler : Singleton<DataHandler>
    {
        private GameObject fishItem;


        [SerializeField] private ButtonManager buttonPrefab;
        [SerializeField] private GameObject buttonContainer;
        [SerializeField] private List<Item> items;
        //[SerializeField] private string label;

        private int id = 0;

        void Start()
        {
            items = new List<Item>();
            //await Get(label);
            CreateButton();
        }

        void CreateButton()
        {
            foreach(Item i in items)
            {
                ButtonManager b = Instantiate(buttonPrefab, buttonContainer.transform);
                b.ItemId = id;
                b.ButtonTexture = i.fishImage;
                id++;
            }

        }

        public void SetFish(int id)
        {
            fishItem = items[id].fishPrefab;
        }

        public GameObject GetFish()
        {
            return fishItem;
        }

        //public async Task Get(string label)
        //{

        //}
    }
}

