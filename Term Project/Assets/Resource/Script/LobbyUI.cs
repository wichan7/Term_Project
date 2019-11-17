﻿using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class LobbyUI : MonoBehaviour
{
    public GameObject go_LobbyUI;

    public void StartButton()
    {
        go_LobbyUI.SetActive( false );
        GameManager.instance.ChapterSelectStageStart();

        DataSet ds = SaveLoad.instance.DBReadByAdapter("SELECT * FROM user");
        DataRowCollection rows = ds.Tables[0].Rows;
        foreach (DataRow dr in rows)
        {
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                Debug.Log(dr[i]);
            }
        }
        Debug.Log(rows[0]);
    }
}
