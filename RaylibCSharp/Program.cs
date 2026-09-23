using Raylib_cs;

Raylib.InitWindow(1920, 1080, "fps");
float xCoordinate = 480;
float yCoordinate = 800;
float Radius = 40.0f;
float defaultPosition = 500;
float hiz = 10f;
float force = 0;

float sabit_adim = 0.016f;
float artanMiktar = 0.0f;

float xCoordinate2 = 1440;
float yCoordinate2 = 800;
float Radius2 = 40.0f;
float defaultPosition2 = 500;
float hiz2 = 10f;
float force2 = 0;
float yayKatSayisi = 100.1f;
int[] fpsSecenekleri = { 5, 60 };
int fpsSirasi = 1;
int fps = fpsSecenekleri[fpsSirasi];
Raylib.SetTargetFPS(fps);
while (!Raylib.WindowShouldClose())
{
    // Yukari ok: 60 FPS, asagi ok: 5 FPS
    if (Raylib.IsKeyPressed(KeyboardKey.Up) && fpsSirasi < fpsSecenekleri.Length - 1)
    {
        fpsSirasi++;
    }
    if (Raylib.IsKeyPressed(KeyboardKey.Down) && fpsSirasi > 0)
    {
        fpsSirasi--;
    }
    if (fps != fpsSecenekleri[fpsSirasi])
    {
        fps = fpsSecenekleri[fpsSirasi];
        Raylib.SetTargetFPS(fps);
    }

    // F: kenarliksiz tam ekran ac/kapa
    if (Raylib.IsKeyPressed(KeyboardKey.F))
    {
        Raylib.ToggleBorderlessWindowed();
    }

    // Toplar ekranin dortte birinde ve dortte ucunde dursun, ekran boyu ne olursa olsun
    xCoordinate = Raylib.GetScreenWidth() / 4f;
    xCoordinate2 = Raylib.GetScreenWidth() * 3 / 4f;

    float dt = Raylib.GetFrameTime();
    artanMiktar += dt;
    while (artanMiktar >= sabit_adim)
    {
        artanMiktar -= sabit_adim;
        force2 = (defaultPosition2 - yCoordinate2) * yayKatSayisi;
        hiz2 += force2 * sabit_adim;
        yCoordinate2 += sabit_adim * hiz2;
    }
    force = (defaultPosition - yCoordinate) * yayKatSayisi;
    hiz += force * dt;
    yCoordinate += hiz * dt;

    // force2 = defaultPosition2 - yCoordinate2;
    // hiz2 += dt2 * force2;
    // yCoordinate2 += hiz2 * dt2;

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Black);
    Raylib.DrawText($"FPS: {fps}\n Yay Kat Sayisi: {yayKatSayisi}", 20, 20, 40, Color.White);

    Raylib.DrawCircle((int)xCoordinate, (int)yCoordinate, Radius, Color.Blue);
    Raylib.DrawCircle((int)xCoordinate2, (int)yCoordinate2, Radius2, Color.Blue);
    Raylib.EndDrawing();
}
Raylib.CloseWindow();
