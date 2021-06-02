using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITEM_COUNT : MonoBehaviour
{
    public GameObject prefab_GameObject;
    public Button option_Buttons;
    public RectTransform parent_Position;
    public int item_Number;
    // Start is called before the first frame update
    void Start()
    {
        parent_Position.position = this.transform.position;
        item_Number = Random.Range(0, 5);

        if (item_Number > 0)
        {
            for (int i = 0; i < item_Number; i++)
            {
                Instantiate(prefab_GameObject,parent_Position);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
