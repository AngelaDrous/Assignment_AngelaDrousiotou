using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSON_Reader : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class FoodObjects
    {
        public string Name;
        public int Points;
    }

    [System.Serializable]

    public class FoodObjList
    {
        public FoodObjects[] FoodObjects;
    }

    public FoodObjList myFoodObjList = new FoodObjList();

    // Start is called before the first frame update
    void Start()
    {
        myFoodObjList = JsonUtility.FromJson<FoodObjList>(textJSON.text);
    }

}
