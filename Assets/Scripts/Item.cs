using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public string Name;

    public Sprite Artwork;

    public TypeList Type;

    public int value;

    public enum TypeList
    {
        Damage,
        defense,
        Healing
    }
}
