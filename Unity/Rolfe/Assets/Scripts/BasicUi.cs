using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUi : MonoBehaviour {
    public GameObject Exit;
    public GameObject Options;
    public GameObject Extras;
    public GameObject SaveChanges;
    
    public List<GameObject> AllTabs;
    // Use this for initialization
    void Start () {
        AllTabs.Add(Exit);
        AllTabs.Add(Options);
        AllTabs.Add(Extras);
        AllTabs.Add(SaveChanges);
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OpenOptions()
    {
        Options.SetActive(true);
    }
    public void OpenExtras()
    {
        Extras.SetActive(true);
    }
    public void OpenSaveChanges()
    {
        SaveChanges.SetActive(true);
    }
    public void CloseSave()
    {
        for (int i = 0; i < AllTabs.Count; i++)
        {
            AllTabs[i].SetActive(false);
        }
    }
    public void SimpleClose()
    {
        for (int i = 0; i < AllTabs.Count; i++)
        {
            if(AllTabs[i])
            {
                AllTabs[i].SetActive(false);
                AllTabs[i].SetActive(false);
            }
            
        }
    }
    public void ExitGame()
    {
        Exit.SetActive(true);
    }
}
