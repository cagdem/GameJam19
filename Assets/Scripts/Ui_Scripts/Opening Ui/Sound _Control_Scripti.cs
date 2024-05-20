using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    // Slider referansı
    public Slider soundSlider;

    private void Start()
    {
        // Slider'ın değerini mevcut ses seviyesi ile başlat
        soundSlider.value = AudioListener.volume;

        // Slider'ın değer değişim olayına dinleyici ekle
        soundSlider.onValueChanged.AddListener(SetVolume);
    }

    // Slider değeri değiştiğinde çağrılacak metod
    private void SetVolume(float value)
    {
        AudioListener.volume = value;
    }
}
