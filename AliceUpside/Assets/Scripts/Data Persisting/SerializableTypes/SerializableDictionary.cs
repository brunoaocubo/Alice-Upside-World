using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
[System.Serializable]
public class SerializableDictionary<TKey, TValue>: Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
    [SerializeField] private List<TKey> keys = new List<TKey>();
    [SerializeField] private List<TValue> values = new List<TValue>();

    //Salve o dicion�rio nas listas
    public void OnBeforeSerialize() 
    {
        keys.Clear();
        values.Clear();
        foreach (KeyValuePair<TKey, TValue> pair in this)
        {
            keys.Add(pair.Key);
            values.Add(pair.Value);
        }
    }

    //Carregue os dicion�rio das listas
    public void OnAfterDeserialize() 
    {
        this.Clear();
        if(keys.Count != values.Count) 
        {
            Debug.LogError("Tentativa de desserializar um SerializableDictionary, mas a quantidade de chaves (" + keys.Count + ") n�o corresponde ao n�mero de valores(" + values.Count + ") que indica");
        }
        for (int i = 0; i < keys.Count; i++)
        {
            this.Add(keys[i], values[i]);
        }
    }
}
*/