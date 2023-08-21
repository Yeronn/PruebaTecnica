using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCard : MonoBehaviour
{
    public Item ItemData;

    public TextMeshProUGUI NameText;

    public Image ArtWorkImage;

    public TextMeshProUGUI TypeText;

    public TextMeshProUGUI TypeValueText;

    private void Start()
    {
        NameText.text = ItemData.Name;

        ArtWorkImage.sprite = ItemData.Artwork;

        TypeText.text = ItemData.Type.ToString();

        TypeValueText.text = ItemData.value.ToString();
    }
}
