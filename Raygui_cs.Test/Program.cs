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
            bool ToggleButton0 = false;
            int X = 100;
            int SelectedToggle = 0;
            int sb = 0;
            bool Window = true;
            string input="";
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText(Text0 , 400 , 280 , 20 , Color.BLACK);
                Raygui.GuiLabel(new Rectangle(100 , 100 , 100 , 40) , Text1);
                Raygui.GuiButton(new Rectangle(20 , 140 , 50 , 20) , (int)GuiIconName.ICON_FILE_OPEN,"");
                if (Raygui.GuiButton(new Rectangle(X , 140 , 200 , 20) , Text2))
                {
                    Window = true;
                }
                ToggleButton0 = Raygui.GuiToggle(new Rectangle(100 , 160 , 20 , 20) , Icon0 , ToggleButton0);
                SelectedToggle = Raygui.GuiToggleGroup(new Rectangle(100 , 180 , 40 , 20) , "1;2;3\n4;5;6" , SelectedToggle);
                sb = Raygui.GuiScrollBar(new Rectangle(400 , 120 , 100 , 20) , sb , 0 , 100);
                sb = Raygui.GuiScrollBar(new Rectangle(400 , 20 , 20 , 100) , sb , 0 , 100);
                if (Window)
                    Window = !Raygui.GuiWindowBox(new Rectangle(200 , 300 , 400 , 300) , "Window");
                Raygui.GuiTextBox(new Rectangle(100,300,100,20),input,80,true);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
