using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FishHunter.Data
{
    public class RandomPick : Singleton<RandomPick>
    {
        public List<string> myFish1 = new List<string>();
        public List<string> myFish2 = new List<string>();

        string selected1;
        string selected2;

        [SerializeField] Item[] fishList;
        [SerializeField] Sprite tempFish;
        public void Fish()
        {
            myFish1.Add("Keli");
            myFish1.Add("Jerung");
            myFish1.Add("Haruan");
            myFish1.Add("Kelah");

            myFish2.Add("Ubi");
            myFish2.Add("Piranha");
            myFish2.Add("Nemo");
            myFish2.Add("Guppy");

            Shuffle(myFish1);
            Shuffle(myFish2);

            StartCoroutine(Wait());
        }

        IEnumerator Wait()
        {
            for (int i = 0; i < 4; i++)
            {
                selected1 = myFish1[i];

                for (int j = 0; j < 4; j++)
                {
                    selected2 = myFish2[j];
                    //yield return new WaitForSeconds(1);
                }

                if (selected1 == "Keli")
                {
                    Debug.Log("Got Keli");
                    break;
                }
                else if (selected1 == "Haruan")
                {

                    Debug.Log("Got Haruan");
                    break;
                }
                else if (selected2 == "Piranha")
                {

                    Debug.Log("Got Piranha");
                    break;
                }
                else if (selected1 == "Jerung")
                {

                    Debug.Log("Got Jerung");
                    break;
                }
                else if (selected2 == "Nemo")
                {

                    Debug.Log("Got Nemo");
                    break;
                }
                break;
            }

            foreach (Item i in fishList)
            {
                //tempFish = fishList[]fishImage.name();
            }

            yield return null;
        }

        void Shuffle(List<string> lists)
        {
            for (int j = lists.Count - 1; j > 0; j--)
            {
                int rnd = UnityEngine.Random.Range(0, j + 1);
                string temp = lists[j];
                lists[j] = lists[rnd];
                lists[rnd] = temp;

                Debug.Log(temp);
            }

        }
    }
}


