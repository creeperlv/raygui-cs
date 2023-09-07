using raygui_cs;
using Raylib_cs;

namespace Raygui_cs.Test
{
    internal class Program
    {
        static void Main(string [ ] args)
        {
            Raylib.InitWindow(800 , 600 , "Raygui Test");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("RAYGUI TEST, 你好",400,280,20, Color.BLACK);
                Raygui.GuiLabel(new Rectangle(100,100,100,100),"Test");
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
