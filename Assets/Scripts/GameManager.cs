using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject componentButtonPrefab;
    [SerializeField] GameObject buttonParent;
    
    float yPos = -10f;
    float xPos = 17.5f;

    [SerializeField] List<ComponentObject> componentsObjList;
    [SerializeField] List<GameObject> componentsButtonList;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintComponentList();
        AssignComponentsToButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AssignComponentsToButtons()
    {
        xPos = 17.5f;
        yPos = -10f;
        foreach (ComponentObject co in componentsObjList)
        {
            Vector2 buttonPos = new Vector2(xPos, yPos);
            GameObject compButton = Instantiate(componentButtonPrefab, buttonPos, Quaternion.identity, buttonParent.transform);
            xPos += 217.5f;

            componentsButtonList.Add(compButton);
        }
        
    }

    void PrintComponentList()
    {
        foreach (ComponentObject co in componentsObjList)
        {
            Debug.Log(co.CompToString());
        }
    }
}
