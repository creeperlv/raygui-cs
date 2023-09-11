using Microsoft.VisualBasic;
using raygui_cs;
using Raylib_cs;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System.Reflection;
using System;

namespace Raygui_cs.Test
{
    internal class Program
    {
        private const string Text0 = "RAYGUI TEST, 你好";
        private const string Text1 = "Test, こにちわ\nLine 2";
        private const string Text2 = "Show Window";
        private const string Icon0 = "#112#";

        static void Main(string [ ] args)
        {
            Raylib.InitWindow(800 , 600 , "Raygui Test");
            bool Window = true;
            float Slider = 0;
            int ListView0 = 0;
            int ListView1 = 0;
            int PageIndex = 0;
            int PageSelectorActive = 0;
            bool CheckBox0 = false;
            int ComboBox0 = 0;
            int Dropbox0 = 0;
            bool Dropbox1 = false;
            int Spin = 0;
            Color picker0 = Color.WHITE;
            Color picker1 = Color.WHITE;
            bool Spin0 = false;
            Raylib.SetWindowState(ConfigFlags.FLAG_VSYNC_HINT);
            ReadonlyString [ ] Tabs = new ReadonlyString [ 4 ];
            Tabs [ 0 ] = "Tab0";
            Tabs [ 1 ] = "Tab1";
            Tabs [ 2 ] = "Tab2";
            Tabs [ 3 ] = "Tab3";
            int TabRef = 0;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                {
                    PageSelectorActive = Raygui.GuiListView(new Rectangle(0 , 0 , 150 , 600) , "General;Window;Inputs;Grid;Color;Panel and Tab" , ref PageIndex , PageSelectorActive);
                    switch (PageSelectorActive)
                    {
                        case 0:
                            {
                                {
                                    CheckBox0 = Raygui.GuiCheckBox(new Rectangle(150 , 0 , 20 , 20) , "Checkbox" , CheckBox0);
                                    ComboBox0 = Raygui.GuiComboBox(new Rectangle(150 , 20 , 100 , 20) , "A;B;C;D" , ComboBox0);
                                    Raygui.GuiGroupBox(new Rectangle(250 , 180 , 300 , 200) , "Content");
                                    if (Raygui.GuiDropdownBox(new Rectangle(150 , 40 , 100 , 20) , "A;B;C;D" , ref Dropbox0 , Dropbox1)) Dropbox1 = !Dropbox1;
                                }
                            }
                            break;
                        case 1:
                            {
                                if (Raygui.GuiButton(new Rectangle(150 , 10 , 200 , 20) , Text2))
                                {
                                    Window = true;
                                }
                                if (Window)
                                {
                                    Window = !Raygui.GuiWindowBox(new Rectangle(200 , 100 , 400 , 300) , "Window");
                                    Slider = Raygui.GuiSlider(new Rectangle(250 , 140 , 200 , 20) , "Left" , "Right" , Slider , 0 , 100);
                                    Slider = Raygui.GuiSlider(new Rectangle(250 , 160 , 200 , 20) , "L" , "R" , Slider , 0 , 100);
                                    Slider = Raygui.GuiProgressBar(new Rectangle(250 , 180 , 200 , 20) , ReadonlyString.NULL , ReadonlyString.NULL , Slider , 0 , 100);
                                    Slider = Raygui.GuiProgressBar(new Rectangle(250 , 200 , 200 , 20) , "L" , "R" , Slider , 0 , 100);
                                    ListView1 = Raygui.GuiListView(new Rectangle(250 , 220 , 200 , 100) , "123;321;1234567;ASD;DSA;dfghjd" , ref ListView0 , ListView1);
                                }
                                else
                                {

                                    switch (Raygui.GuiMessageBox(new Rectangle(200 , 150 , 300 , 150) , "MesageBox" , "Content" , "OK;CANCEL"))
                                    {
                                        case 1: Window = true; break;
                                        case 2: Window = false; break;
                                    }
                                }
                            }
                            break;
                        case 2:
                            {
                                    if (Raygui.GuiSpinner(new Rectangle(200 , 60 , 140 , 20) , "Header" , ref Spin , 0 , 100 , Spin0)) Spin0 = !Spin0;

                            }
                            break;
                        case 3:
                            {
                                Raygui.GuiGrid(new Rectangle(150 , 0 , 300 , 300) , ReadonlyString.NULL , 50 , 1);
                            }
                            break;
                        case 4:
                            {
                                picker0 = Raygui.GuiColorPicker(new Rectangle(150 , 0 , 250 , 250) , "Color" , picker0);
                                picker1 = Raygui.GuiColorPanel(new Rectangle(150 , 250 , 250 , 250) , "Color" , picker1);
                            }
                            break;
                        case 5:
                            {
                                Raygui.GuiPanel(new Rectangle(150 , 0 , 250 , 250) , "Panel");
                                Raygui.GuiTabBar(new Rectangle(150 , 250 , 250 , 20) , Tabs , 4 , ref TabRef);
                            }
                            break;

                        default:
                            break;
                    }
                }
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }

    }
}
