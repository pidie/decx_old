using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class DataManager
{
    public string GetJsonFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            Debug.LogWarning("File not found!");
            return "";
        }
    }
}
