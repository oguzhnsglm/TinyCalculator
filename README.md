Tiny Calculator, basit matematiksel işlemleri gerçekleştirebilen bir WPF uygulamasıdır. Bu uygulama, MVVM (Model-View-ViewModel) mimarisini temel alarak geliştirilmiştir ve test odaklı bir yapı ile oluşturulmuştur. Kullanıcı, metin kutusuna matematiksel bir ifade girerek sonucu kolayca hesaplayabilir.

📋 Özellikler

Basit Matematiksel İşlemler: Toplama, çıkarma, çarpma ve bölme işlemlerini destekler.
MVVM Mimari Desteği: Modern ve temiz bir kod yapısı sunar.
Unit Test Entegrasyonu: MSTest ile kapsamlı bir şekilde test edilmiştir.
WPF Uygulaması: Windows Presentation Foundation kullanılarak geliştirilmiştir.

🚀 Başlarken

Aşağıdaki talimatları izleyerek projeyi sisteminizde çalıştırabilirsiniz.

Gereksinimler
Visual Studio 2022
.NET 7.0 SDK
NuGet Bağımlılıkları:
Prism.Core
Prism.Wpf


📐 Proje Yapısı

Model: Matematiksel işlemleri gerçekleştiren Calculator sınıfı.
ViewModel: CalculatorViewModel, MVVM mimarisinde veri bağlama ve komutlar için kullanılır.
View: WPF XAML dosyaları (MainWindow.xaml) kullanıcı arayüzünü oluşturur.
Tests: CalculatorViewModelTests, MSTest kullanılarak uygulamanın birim testlerini içerir.

🧪 Testler
Projede MSTest framework'ü kullanılarak birim testler yazılmıştır.

Testler arasında:

ViewModel birim testleri

CalculateCommand çalışabilirlik testleri


📂 Proje Dosyaları

TinyCalculator.sln: Çözüm dosyası
CalculatorViewModel.cs: ViewModel sınıfı
Calculator.cs: Matematiksel işlemleri yapan sınıf
MainWindow.xaml: Kullanıcı arayüzü tasarımı
CalculatorViewModelTests.cs: Test sınıfları
