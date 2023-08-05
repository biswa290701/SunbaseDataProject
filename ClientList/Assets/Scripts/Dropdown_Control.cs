using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dropdown_Control : MonoBehaviour
{
    public void HandleInput_AllClients(int val)
    {
        if (val == 1)
        {
            SceneManager.LoadScene("ManagerList");
        }
        if (val == 2)
        {
            SceneManager.LoadScene("NonManagerList");
        }
    }
    public void HandleInput_Manager(int val)
    {
        if (val == 1)
        {
            SceneManager.LoadScene("ClientList");
        }
        if (val == 2)
        {
            SceneManager.LoadScene("NonManagerList");
        }
    }
    public void HandleInput_NonManager(int val)
    {
        if (val == 1)
        {
            SceneManager.LoadScene("ClientList");
        }
        if (val == 2)
        {
            SceneManager.LoadScene("ManagerList");
        }
    }
}
