using Game.Component;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Utils
{
    /// <summary>
    /// UnitySerializedDictionary for Dictionary
    /// </summary>
    /// <inheritdoc cref="UnitySerializedDictionary{string, StatType}"/>
    [Serializable]
    public class StatTypeScriptableObjectDictionary : UnitySerializedDictionary<string, StatType> { }

    /// <summary>
    /// Base class to create Unity Serialized Dictionary
    /// </summary>
    /// <typeparam name="TKey">key type</typeparam>
    /// <typeparam name="TValue">value type</typeparam>
    public abstract class UnitySerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField, HideInInspector]
        protected List<TKey> keyData = new List<TKey>();

        [SerializeField, HideInInspector]
        protected List<TValue> valueData = new List<TValue>();

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            this.Clear();
            for (int i = 0; i < this.keyData.Count && i < this.valueData.Count; i++)
            {
                this[this.keyData[i]] = this.valueData[i];
            }
        }

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
            this.keyData.Clear();
            this.valueData.Clear();

            foreach (var item in this)
            {
                this.keyData.Add(item.Key);
                this.valueData.Add(item.Value);
            }
        }
    }
}
