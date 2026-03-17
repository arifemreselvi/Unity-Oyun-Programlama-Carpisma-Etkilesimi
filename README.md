# 🚀 Unity Oyun Programlama - Çarpışma Etkileşimi

Unity üzerinde geliştirilmiş dinamik çarpışma ve fizik simülasyonu projesi

## 🛠️ Proje Detayları
* **Geliştirici:** Arif Emre Selvi
* **Bölüm:** Yönetim Bilişim Sistemleri
* **Oyun Motoru:** Unity
* **Dil:** C#

## ⚙️ Mekanikler
* Çarpışma anında patlama efekti instantiate edilir
* Particle System ile görsel şölen sağlanır
* Patlama sonrasında zeminde kalıntı izi aktifleşir
* Optimizasyon için ana obje yok edilir

## 💻 Çarpışma Kodu
```csharp
void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.CompareTag("Zemin")) {
        Instantiate(patlamaEfekti, transform.position, transform.rotation);
        saklananIz.SetActive(true);
        Destroy(gameObject);
    }
}
```
## 📺 Proje Tanıtım Videosu
[![Unity Oyun Programlama - Çarpışma Etkileşimi](https://img.youtube.com/vi/jNYoFAluyWU/hqdefault.jpg)](https://www.youtube.com/watch?v=jNYoFAluyWU)
