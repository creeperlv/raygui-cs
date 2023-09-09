using raygui_cs;
using Raylib_cs;

namespace Raygui_cs.Test
{
    internal class Program
    {
        private const string Text0 = "RAYGUI TEST, 你好";
        private const string Text1 = "Test, こにちわ\nLine 2";
        private const string Text2 = "Test Button";
        private const string Icon0 = "#112#";

        static void Main(string [ ] args)
        {
            Raylib.InitWindow(800 , 600 , "Raygui Test");
            bool ToggleButton0=false;
            int X=100;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText(Text0 , 400 , 280 , 20 , Color.BLACK);
                Raygui.GuiLabel(new Rectangle(100 , 100 , 100 , 40) , Text1);
                if (Raygui.GuiButton(new Rectangle(X , 140 , 200 , 20) , Text2))
                {
                    X++;
                }
                ToggleButton0=Raygui.GuiToggle(new Rectangle(100,160,20,20), Icon0 , ToggleButton0);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
