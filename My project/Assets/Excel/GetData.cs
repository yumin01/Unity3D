using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour
{
    // Start is called before the first frame update

    public Entity_GameDB entity_GameDB;
    void Start()
    {
        foreach (Entity_GameDB.Param param in entity_GameDB.sheets[0].list)
        {
            Debug.Log(param.Index + " - " + param.Ä³¸¯ÅÍ + " - " + param.hp + " - " + param.mp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
