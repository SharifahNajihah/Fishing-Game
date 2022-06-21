using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FishHunter.Data
{
    public class RandomPick : Singleton<RandomPick>
    {
        [Header("FishList")]
        public string[] fishType;
        public List<GameObject> fishObject;

        public Item fishItems;

        public string gotFish;
        string selected1;

        public void Fish()
        {
            Shuffle(fishType);
            StartCoroutine(Wait());
        }

        IEnumerator Wait()
        {
            GetFish(fishType);
            yield return null;
        }

        void GetFish(string[] fishes)
        {
            for (int i = 0; i < 1; i++)
            {
                if (selected1 == fishType[i])
                {
                    
                    
                        Debug.Log("ddd");
                    
                    //fish.SetActive(true);

                }
                gotFish = fishes[i];
            }

        }
        void Shuffle(string[] lists)
        {
            for (int j = fishType.Length - 1; j > 0; j--)
            {
                int rnd = UnityEngine.Random.Range(0, j + 1);
                string temp = lists[j];
                lists[j] = lists[rnd];
                lists[rnd] = temp;
            }

        }
    }
}


