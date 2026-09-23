# Videodaki raylib + C# simülasyonu

İki top aynı yayın üzerinde:
- **Soldaki top** fizik hesabını her karede bir kez, karenin süresiyle (`dt`) yapar → FPS düşünce bozulur.
- **Sağdaki top** geçen süreyi bir "kovada" biriktirir ve hep sabit 16 ms'lik adımlarla hesaplar → FPS ne olursa olsun bozulmaz.

## Çalıştırma

.NET 10 SDK gerekir.

```bash
cd RaylibCSharp
dotnet run
```

## Tuşlar

| Tuş | İş |
|---|---|
| ↑ | 60 FPS |
| ↓ | 5 FPS |
| F | Tam ekran aç/kapa |

`yayKatSayisi` değerini değiştirerek dene: 5 FPS'te 100'ün altında sol top sapıtır ama ekranda kalır, 100'ün üstünde ekrandan kaçar.
