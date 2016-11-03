using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    public static class SortCard
    {
        public static List<Card> InsertionSort(List<Card> listNotSorted)
        {
            for(var i =0; i<listNotSorted.Count; i++)
            {
                for(var j = i+1; j<listNotSorted.Count; j++)
                {
                    if(listNotSorted[i].CompareTo(listNotSorted[j]) > 0)
                    {
                        var temp = listNotSorted[i];
                        listNotSorted[i] = listNotSorted[j];
                        listNotSorted[j] = temp;
                    }
                }
            }
            return listNotSorted;
        }

        public static List<Card> BubbleSort(List<Card> listNotSorted)
        {
            for (var i = 0; i < listNotSorted.Count; i++)
            {
                for (var j = 0; j < listNotSorted.Count-i-1; j++)
                {
                    if(listNotSorted[j].CompareTo(listNotSorted[j+1]) > 0)
                    {
                        var temp = listNotSorted[j];
                        listNotSorted[j] = listNotSorted[j+1];
                        listNotSorted[j+1] = temp;
                    }
                }
            }
            return listNotSorted;
        }

        public static List<Card> ShakeSort(List<Card> listNotSorted)
        {
            for (var i = 0; i < listNotSorted.Count; i++)
            {
                for (var j = i; j < listNotSorted.Count - i - 1; j++)
                {
                    if (listNotSorted[j].CompareTo(listNotSorted[j + 1]) > 0)
                    {
                        var temp = listNotSorted[j];
                        listNotSorted[j] = listNotSorted[j + 1];
                        listNotSorted[j + 1] = temp;
                    }
                }
                for (var j = listNotSorted.Count - i - 1; j > i; j--)
                {
                    if (listNotSorted[j].CompareTo(listNotSorted[j - 1]) < 0)
                    {
                        var temp = listNotSorted[j];
                        listNotSorted[j] = listNotSorted[j - 1];
                        listNotSorted[j - 1] = temp;
                    }
                }
            }
            return listNotSorted;
        }

        public static List<Card> FusionSort(List<Card> listNotSorted)
        {
            if(listNotSorted.Count <= 2)
            {
                return listNotSorted;
            }
            else
            {
                int middleCount = listNotSorted.Count / 2;
                List<Card> lowList = new List<Card>();
                List<Card> highList = new List<Card>();
                for(int i = 0; i< listNotSorted.Count; i++)
                {
                    if(i < middleCount)
                    {
                        lowList.Add(listNotSorted[i]);
                    }
                    else
                    {
                        highList.Add(listNotSorted[i]);
                    }
                }
                FusionSort(lowList);
                FusionSort(highList);
            }
        }
    }
}
