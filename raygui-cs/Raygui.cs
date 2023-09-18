using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace raygui_cs
{//----------------------------------------------------------------------------------
 // Icons enumeration
 //----------------------------------------------------------------------------------
    public enum GuiIconName
    {
        ICON_NONE = 0,
        ICON_FOLDER_FILE_OPEN = 1,
        ICON_FILE_SAVE_CLASSIC = 2,
        ICON_FOLDER_OPEN = 3,
        ICON_FOLDER_SAVE = 4,
        ICON_FILE_OPEN = 5,
        ICON_FILE_SAVE = 6,
        ICON_FILE_EXPORT = 7,
        ICON_FILE_ADD = 8,
        ICON_FILE_DELETE = 9,
        ICON_FILETYPE_TEXT = 10,
        ICON_FILETYPE_AUDIO = 11,
        ICON_FILETYPE_IMAGE = 12,
        ICON_FILETYPE_PLAY = 13,
        ICON_FILETYPE_VIDEO = 14,
        ICON_FILETYPE_INFO = 15,
        ICON_FILE_COPY = 16,
        ICON_FILE_CUT = 17,
        ICON_FILE_PASTE = 18,
        ICON_CURSOR_HAND = 19,
        ICON_CURSOR_POINTER = 20,
        ICON_CURSOR_CLASSIC = 21,
        ICON_PENCIL = 22,
        ICON_PENCIL_BIG = 23,
        ICON_BRUSH_CLASSIC = 24,
        ICON_BRUSH_PAINTER = 25,
        ICON_WATER_DROP = 26,
        ICON_COLOR_PICKER = 27,
        ICON_RUBBER = 28,
        ICON_COLOR_BUCKET = 29,
        ICON_TEXT_T = 30,
        ICON_TEXT_A = 31,
        ICON_SCALE = 32,
        ICON_RESIZE = 33,
        ICON_FILTER_POINT = 34,
        ICON_FILTER_BILINEAR = 35,
        ICON_CROP = 36,
        ICON_CROP_ALPHA = 37,
        ICON_SQUARE_TOGGLE = 38,
        ICON_SYMMETRY = 39,
        ICON_SYMMETRY_HORIZONTAL = 40,
        ICON_SYMMETRY_VERTICAL = 41,
        ICON_LENS = 42,
        ICON_LENS_BIG = 43,
        ICON_EYE_ON = 44,
        ICON_EYE_OFF = 45,
        ICON_FILTER_TOP = 46,
        ICON_FILTER = 47,
        ICON_TARGET_POINT = 48,
        ICON_TARGET_SMALL = 49,
        ICON_TARGET_BIG = 50,
        ICON_TARGET_MOVE = 51,
        ICON_CURSOR_MOVE = 52,
        ICON_CURSOR_SCALE = 53,
        ICON_CURSOR_SCALE_RIGHT = 54,
        ICON_CURSOR_SCALE_LEFT = 55,
        ICON_UNDO = 56,
        ICON_REDO = 57,
        ICON_REREDO = 58,
        ICON_MUTATE = 59,
        ICON_ROTATE = 60,
        ICON_REPEAT = 61,
        ICON_SHUFFLE = 62,
        ICON_EMPTYBOX = 63,
        ICON_TARGET = 64,
        ICON_TARGET_SMALL_FILL = 65,
        ICON_TARGET_BIG_FILL = 66,
        ICON_TARGET_MOVE_FILL = 67,
        ICON_CURSOR_MOVE_FILL = 68,
        ICON_CURSOR_SCALE_FILL = 69,
        ICON_CURSOR_SCALE_RIGHT_FILL = 70,
        ICON_CURSOR_SCALE_LEFT_FILL = 71,
        ICON_UNDO_FILL = 72,
        ICON_REDO_FILL = 73,
        ICON_REREDO_FILL = 74,
        ICON_MUTATE_FILL = 75,
        ICON_ROTATE_FILL = 76,
        ICON_REPEAT_FILL = 77,
        ICON_SHUFFLE_FILL = 78,
        ICON_EMPTYBOX_SMALL = 79,
        ICON_BOX = 80,
        ICON_BOX_TOP = 81,
        ICON_BOX_TOP_RIGHT = 82,
        ICON_BOX_RIGHT = 83,
        ICON_BOX_BOTTOM_RIGHT = 84,
        ICON_BOX_BOTTOM = 85,
        ICON_BOX_BOTTOM_LEFT = 86,
        ICON_BOX_LEFT = 87,
        ICON_BOX_TOP_LEFT = 88,
        ICON_BOX_CENTER = 89,
        ICON_BOX_CIRCLE_MASK = 90,
        ICON_POT = 91,
        ICON_ALPHA_MULTIPLY = 92,
        ICON_ALPHA_CLEAR = 93,
        ICON_DITHERING = 94,
        ICON_MIPMAPS = 95,
        ICON_BOX_GRID = 96,
        ICON_GRID = 97,
        ICON_BOX_CORNERS_SMALL = 98,
        ICON_BOX_CORNERS_BIG = 99,
        ICON_FOUR_BOXES = 100,
        ICON_GRID_FILL = 101,
        ICON_BOX_MULTISIZE = 102,
        ICON_ZOOM_SMALL = 103,
        ICON_ZOOM_MEDIUM = 104,
        ICON_ZOOM_BIG = 105,
        ICON_ZOOM_ALL = 106,
        ICON_ZOOM_CENTER = 107,
        ICON_BOX_DOTS_SMALL = 108,
        ICON_BOX_DOTS_BIG = 109,
        ICON_BOX_CONCENTRIC = 110,
        ICON_BOX_GRID_BIG = 111,
        ICON_OK_TICK = 112,
        ICON_CROSS = 113,
        ICON_ARROW_LEFT = 114,
        ICON_ARROW_RIGHT = 115,
        ICON_ARROW_DOWN = 116,
        ICON_ARROW_UP = 117,
        ICON_ARROW_LEFT_FILL = 118,
        ICON_ARROW_RIGHT_FILL = 119,
        ICON_ARROW_DOWN_FILL = 120,
        ICON_ARROW_UP_FILL = 121,
        ICON_AUDIO = 122,
        ICON_FX = 123,
        ICON_WAVE = 124,
        ICON_WAVE_SINUS = 125,
        ICON_WAVE_SQUARE = 126,
        ICON_WAVE_TRIANGULAR = 127,
        ICON_CROSS_SMALL = 128,
        ICON_PLAYER_PREVIOUS = 129,
        ICON_PLAYER_PLAY_BACK = 130,
        ICON_PLAYER_PLAY = 131,
        ICON_PLAYER_PAUSE = 132,
        ICON_PLAYER_STOP = 133,
        ICON_PLAYER_NEXT = 134,
        ICON_PLAYER_RECORD = 135,
        ICON_MAGNET = 136,
        ICON_LOCK_CLOSE = 137,
        ICON_LOCK_OPEN = 138,
        ICON_CLOCK = 139,
        ICON_TOOLS = 140,
        ICON_GEAR = 141,
        ICON_GEAR_BIG = 142,
        ICON_BIN = 143,
        ICON_HAND_POINTER = 144,
        ICON_LASER = 145,
        ICON_COIN = 146,
        ICON_EXPLOSION = 147,
        ICON_1UP = 148,
        ICON_PLAYER = 149,
        ICON_PLAYER_JUMP = 150,
        ICON_KEY = 151,
        ICON_DEMON = 152,
        ICON_TEXT_POPUP = 153,
        ICON_GEAR_EX = 154,
        ICON_CRACK = 155,
        ICON_CRACK_POINTS = 156,
        ICON_STAR = 157,
        ICON_DOOR = 158,
        ICON_EXIT = 159,
        ICON_MODE_2D = 160,
        ICON_MODE_3D = 161,
        ICON_CUBE = 162,
        ICON_CUBE_FACE_TOP = 163,
        ICON_CUBE_FACE_LEFT = 164,
        ICON_CUBE_FACE_FRONT = 165,
        ICON_CUBE_FACE_BOTTOM = 166,
        ICON_CUBE_FACE_RIGHT = 167,
        ICON_CUBE_FACE_BACK = 168,
        ICON_CAMERA = 169,
        ICON_SPECIAL = 170,
        ICON_LINK_NET = 171,
        ICON_LINK_BOXES = 172,
        ICON_LINK_MULTI = 173,
        ICON_LINK = 174,
        ICON_LINK_BROKE = 175,
        ICON_TEXT_NOTES = 176,
        ICON_NOTEBOOK = 177,
        ICON_SUITCASE = 178,
        ICON_SUITCASE_ZIP = 179,
        ICON_MAILBOX = 180,
        ICON_MONITOR = 181,
        ICON_PRINTER = 182,
        ICON_PHOTO_CAMERA = 183,
        ICON_PHOTO_CAMERA_FLASH = 184,
        ICON_HOUSE = 185,
        ICON_HEART = 186,
        ICON_CORNER = 187,
        ICON_VERTICAL_BARS = 188,
        ICON_VERTICAL_BARS_FILL = 189,
        ICON_LIFE_BARS = 190,
        ICON_INFO = 191,
        ICON_CROSSLINE = 192,
        ICON_HELP = 193,
        ICON_FILETYPE_ALPHA = 194,
        ICON_FILETYPE_HOME = 195,
        ICON_LAYERS_VISIBLE = 196,
        ICON_LAYERS = 197,
        ICON_WINDOW = 198,
        ICON_HIDPI = 199,
        ICON_FILETYPE_BINARY = 200,
        ICON_HEX = 201,
        ICON_SHIELD = 202,
        ICON_FILE_NEW = 203,
        ICON_FOLDER_ADD = 204,
        ICON_ALARM = 205,
        ICON_CPU = 206,
        ICON_ROM = 207,
        ICON_STEP_OVER = 208,
        ICON_STEP_INTO = 209,
        ICON_STEP_OUT = 210,
        ICON_RESTART = 211,
        ICON_BREAKPOINT_ON = 212,
        ICON_BREAKPOINT_OFF = 213,
        ICON_BURGER_MENU = 214,
        ICON_CASE_SENSITIVE = 215,
        ICON_REG_EXP = 216,
        ICON_FOLDER = 217,
        ICON_FILE = 218,
        ICON_SAND_TIMER = 219,
        ICON_220 = 220,
        ICON_221 = 221,
        ICON_222 = 222,
        ICON_223 = 223,
        ICON_224 = 224,
        ICON_225 = 225,
        ICON_226 = 226,
        ICON_227 = 227,
        ICON_228 = 228,
        ICON_229 = 229,
        ICON_230 = 230,
        ICON_231 = 231,
        ICON_232 = 232,
        ICON_233 = 233,
        ICON_234 = 234,
        ICON_235 = 235,
        ICON_236 = 236,
        ICON_237 = 237,
        ICON_238 = 238,
        ICON_239 = 239,
        ICON_240 = 240,
        ICON_241 = 241,
        ICON_242 = 242,
        ICON_243 = 243,
        ICON_244 = 244,
        ICON_245 = 245,
        ICON_246 = 246,
        ICON_247 = 247,
        ICON_248 = 248,
        ICON_249 = 249,
        ICON_250 = 250,
        ICON_251 = 251,
        ICON_252 = 252,
        ICON_253 = 253,
        ICON_254 = 254,
        ICON_255 = 255,
    };

    public enum GuiState
    {
        STATE_NORMAL = 0,
        STATE_FOCUSED,
        STATE_PRESSED,
        STATE_DISABLED,
    };
    public enum GuiTextBoxProperty
    {
        TEXT_INNER_PADDING = 16,    // TextBox/TextBoxMulti/ValueBox/Spinner inner text padding
        TEXT_LINES_SPACING,         // TextBoxMulti lines separation
        TEXT_ALIGNMENT_VERTICAL,    // TextBoxMulti vertical alignment: 0-CENTERED, 1-UP, 2-DOWN
        TEXT_MULTILINE,             // TextBox supports multiple lines
        TEXT_WRAP_MODE              // TextBox wrap mode for multiline: 0-NO_WRAP, 1-CHAR_WRAP, 2-WORD_WRAP
    };

    public struct GlyphInfo
    {
        public int value;              // Character value (Unicode)
        public int offsetX;            // Character offset X when drawing
        public int offsetY;            // Character offset Y when drawing
        public int advanceX;           // Character advance position X
        public Image image;            // Character image data

        public GlyphInfo()
        {
            value=0;
            offsetX=0;
            offsetX=0;
            advanceX=0;
            image=default;
        }
        public GlyphInfo(int value , int offsetX , int offsetY , int advanceX , Image image)
        {
            this.value = value;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
            this.advanceX = advanceX;
            this.image = image;
        }
    }

    public enum GuiPropertyElement
    {
        BORDER = 0,
        BASE,
        TEXT,
        OTHER
    };
    public struct GuiStyleProp
    {
        public ushort controlId;   // Control identifier
        public ushort propertyId;  // Property identifier
        public uint propertyValue;          // Property value

        public GuiStyleProp()
        {
            controlId = 0;
            propertyId = 0;
            propertyValue = 0;
        }
        public GuiStyleProp(ushort controlId , ushort propertyId , uint propertyValue)
        {
            this.controlId = controlId;
            this.propertyId = propertyId;
            this.propertyValue = propertyValue;
        }
    }

    public enum GuiControlProperty
    {
        BORDER_COLOR_NORMAL = 0,
        BASE_COLOR_NORMAL,
        TEXT_COLOR_NORMAL,
        BORDER_COLOR_FOCUSED,
        BASE_COLOR_FOCUSED,
        TEXT_COLOR_FOCUSED,
        BORDER_COLOR_PRESSED,
        BASE_COLOR_PRESSED,
        TEXT_COLOR_PRESSED,
        BORDER_COLOR_DISABLED,
        BASE_COLOR_DISABLED,
        TEXT_COLOR_DISABLED,
        BORDER_WIDTH,
        TEXT_PADDING,
        TEXT_ALIGNMENT,
        RESERVED
    };
    public enum GuiControl
    {
        // Default -> populates to all controls when set
        DEFAULT = 0,
        // Basic controls
        LABEL,          // Used also for: LABELBUTTON
        BUTTON,
        TOGGLE,         // Used also for: TOGGLEGROUP
        SLIDER,         // Used also for: SLIDERBAR
        PROGRESSBAR,
        CHECKBOX,
        COMBOBOX,
        DROPDOWNBOX,
        TEXTBOX,        // Used also for: TEXTBOXMULTI
        VALUEBOX,
        SPINNER,        // Uses: BUTTON, VALUEBOX
        LISTVIEW,
        COLORPICKER,
        SCROLLBAR,
        STATUSBAR
    };

    public enum GuiTextAlignment
    {
        TEXT_ALIGN_LEFT = 0,
        TEXT_ALIGN_CENTER,
        TEXT_ALIGN_RIGHT,
    };

    public enum GuiDefaultProperty
    {
        TEXT_SIZE = 16,             // Text size (glyphs max height)
        TEXT_SPACING,               // Text spacing between glyphs
        LINE_COLOR,                 // Line control color
        BACKGROUND_COLOR,           // Background color
    };
    public enum GuiToggleProperty
    {
        GROUP_PADDING = 16,         // ToggleGroup separation between toggles
    };

    // Slider/SliderBar
    public enum GuiSliderProperty
    {
        SLIDER_WIDTH = 16,          // Slider size of internal bar
        SLIDER_PADDING              // Slider/SliderBar internal bar padding
    };

    // ProgressBar
    public enum GuiProgressBarProperty
    {
        PROGRESS_PADDING = 16,      // ProgressBar internal padding
    };

    // CheckBox
    public enum GuiCheckBoxProperty
    {
        CHECK_PADDING = 16          // CheckBox internal check padding
    };

    // ComboBox
    public enum GuiComboBoxProperty
    {
        COMBO_BUTTON_WIDTH = 16,    // ComboBox right button width
        COMBO_BUTTON_SPACING        // ComboBox button separation
    };

    // DropdownBox
    public enum GuiDropdownBoxProperty
    {
        ARROW_PADDING = 16,         // DropdownBox arrow separation from border and items
        DROPDOWN_ITEMS_SPACING      // DropdownBox items separation
    };


    // Spinner
    public enum GuiSpinnerProperty
    {
        SPIN_BUTTON_WIDTH = 16,     // Spinner left/right buttons width
        SPIN_BUTTON_SPACING,        // Spinner buttons separation
    };

    // ListView
    public enum GuiListViewProperty
    {
        LIST_ITEMS_HEIGHT = 16,     // ListView items height
        LIST_ITEMS_SPACING,         // ListView items separation
        SCROLLBAR_WIDTH,            // ListView scrollbar size (usually width)
        SCROLLBAR_SIDE,             // ListView scrollbar side (0-left, 1-right)
    };

    // ColorPicker
    public enum GuiColorPickerProperty
    {
        COLOR_SELECTOR_SIZE = 16,
        HUEBAR_WIDTH,               // ColorPicker right hue bar width
        HUEBAR_PADDING,             // ColorPicker right hue bar separation from panel
        HUEBAR_SELECTOR_HEIGHT,     // ColorPicker right hue bar selector height
        HUEBAR_SELECTOR_OVERFLOW    // ColorPicker right hue bar selector overflow
    };

    public enum GuiScrollBarProperty
    {
        ARROWS_SIZE = 16,
        ARROWS_VISIBLE,
        SCROLL_SLIDER_PADDING,      // (SLIDERBAR, SLIDER_PADDING)
        SCROLL_SLIDER_SIZE,
        SCROLL_PADDING,
        SCROLL_SPEED,
    };
    public static class Raygui
    {


        public const int RAYGUI_VERSION_MAJOR = 3;
        public const int RAYGUI_VERSION_MINOR = 6;
        public const int RAYGUI_VERSION_PATCH = 0;
        public const string RAYGUI_VERSION = "3.6";

        public const int STATE_NORMAL = 0;
        public const int STATE_FOCUSED = 1;
        public const int STATE_PRESSED = 2;
        public const int STATE_DISABLED = 3;

        public const int DEFAULT = 0;// Basic controls
        public const int LABEL = 1;          // Used also for: LABELBUTTON
        public const int BUTTON = 2;
        public const int TOGGLE = 3;         // Used also for: TOGGLEGROUP
        public const int SLIDER = 4;         // Used also for: SLIDERBAR
        public const int PROGRESSBAR = 5;
        public const int CHECKBOX = 6;
        public const int COMBOBOX = 7;
        public const int DROPDOWNBOX = 8;
        public const int TEXTBOX = 9;        // Used also for: TEXTBOXMULTI
        public const int VALUEBOX = 10;
        public const int SPINNER = 11;        // Uses: BUTTON; VALUEBOX
        public const int LISTVIEW = 12;
        public const int COLORPICKER = 13;
        public const int SCROLLBAR = 14;
        public const int STATUSBAR = 15;
        public static bool guiStyleLoaded = false;
        public const int TEXT_INNER_PADDING = 16;    // TextBox/TextBoxMulti/ValueBox/Spinner inner text padding
        public const int TEXT_LINES_SPACING = 17;         // TextBoxMulti lines separation
        public const int TEXT_ALIGNMENT_VERTICAL = 18;    // TextBoxMulti vertical alignment: 0-CENTERED, 1-UP, 2-DOWN
        public const int TEXT_MULTILINE = 19;             // TextBox supports multiple lines
        public const int TEXT_WRAP_MODE = 20;              // TextBox wrap mode for multiline: 0-NO_WRAP, 1-CHAR_WRAP, 2-WORD_WRAP


        public const int BORDER_COLOR_NORMAL = 0;
        public const int BASE_COLOR_NORMAL = 1;
        public const int TEXT_COLOR_NORMAL = 2;
        public const int BORDER_COLOR_FOCUSED = 3;
        public const int BASE_COLOR_FOCUSED = 4;
        public const int TEXT_COLOR_FOCUSED = 5;
        public const int BORDER_COLOR_PRESSED = 6;
        public const int BASE_COLOR_PRESSED = 7;
        public const int TEXT_COLOR_PRESSED = 8;
        public const int BORDER_COLOR_DISABLED = 9;
        public const int BASE_COLOR_DISABLED = 10;
        public const int TEXT_COLOR_DISABLED = 11;
        public const int BORDER_WIDTH = 12;
        public const int TEXT_PADDING = 13;
        public const int TEXT_ALIGNMENT = 14;
        public const int RESERVED = 15;


        public const int TEXT_ALIGN_LEFT = 0;
        public const int TEXT_ALIGN_CENTER = 1;
        public const int TEXT_ALIGN_RIGHT = 2;

        public const int TEXT_SIZE = 16;             // Text size (glyphs max height)
        public const int TEXT_SPACING = 17;               // Text spacing between glyphs
        public const int LINE_COLOR = 18;                 // Line control color
        public const int BACKGROUND_COLOR = 19;           // Background color

        public static GuiState guiState = GuiState.STATE_NORMAL;

        public const int RAYGUI_MAX_CONTROLS = 16;   // Maximum number of standard controls
        public const int RAYGUI_MAX_PROPS_BASE = 16;   // Maximum number of standard properties
        public const int RAYGUI_MAX_PROPS_EXTENDED = 8;   // Maximum number of extended properties


        public const int GROUP_PADDING = 16;         // ToggleGroup separation between toggles


        // Slider/SliderBar
        public const int SLIDER_WIDTH = 16;          // Slider size of internal bar
        public const int SLIDER_PADDING = 17;

        // ProgressBar
        public const int PROGRESS_PADDING = 16;      // ProgressBar internal padding

        // CheckBox
        public const int CHECK_PADDING = 16;        // CheckBox internal check padding


        // ComboBox
        public const int COMBO_BUTTON_WIDTH = 16;    // ComboBox right button width
        public const int COMBO_BUTTON_SPACING = 17;// ComboBox button separation


        // DropdownBox
        public const int ARROW_PADDING = 16;         // DropdownBox arrow separation from border and items
        public const int DROPDOWN_ITEMS_SPACING = 17;// DropdownBox items separation

        // Spinner
        public const int SPIN_BUTTON_WIDTH = 16;     // Spinner left/right buttons width
        public const int SPIN_BUTTON_SPACING = 17;        // Spinner buttons separation


        // ListView
        public const int LIST_ITEMS_HEIGHT = 16;     // ListView items height
        public const int LIST_ITEMS_SPACING = 17;         // ListView items separation
        public const int SCROLLBAR_WIDTH = 18;            // ListView scrollbar size (usually width)
        public const int SCROLLBAR_SIDE = 19;             // ListView scrollbar side (0-left, 1-right)


        // ColorPicker
        public const int COLOR_SELECTOR_SIZE = 16;
        public const int HUEBAR_WIDTH = 17;               // ColorPicker right hue bar width
        public const int HUEBAR_PADDING = 18;             // ColorPicker right hue bar separation from panel
        public const int HUEBAR_SELECTOR_HEIGHT = 19;    // ColorPicker right hue bar selector height
        public const int HUEBAR_SELECTOR_OVERFLOW = 20;    // ColorPicker right hue bar selector overflow


        public const int ARROWS_SIZE = 16;
        public const int ARROWS_VISIBLE = 17;
        public const int SCROLL_SLIDER_PADDING = 18;      // (SLIDERBAR, SLIDER_PADDING)
        public const int SCROLL_SLIDER_SIZE = 19;
        public const int SCROLL_PADDING = 20;
        public const int SCROLL_SPEED = 21;

        public const int SCROLLBAR_LEFT_SIDE = 0;
        public const int SCROLLBAR_RIGHT_SIDE = 1;

        public static Rectangle guiSliderActive = default;
        public static uint textBoxCursorIndex = 0;

        public static int autoCursorCooldownCounter = 0;       // Cooldown frame counter for automatic cursor movement on key-down
        public static int autoCursorDelayCounter = 0;          // Delay frame counter for automatic cursor movement
        // GuiPropertyElement

        public const int BORDER = 0;
        public const int BASE = 1;
        public const int TEXT = 2;
        public const int OTHER = 3;
        //Defines
        public static int RAYGUI_PANEL_BORDER_WIDTH = 1;
        public static int RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT = 24;
        public static int RAYGUI_TOGGLEGROUP_MAX_ITEMS = 32;
        public static int MAX_LINE_BUFFER_SIZE = 256;
        public static int RAYGUI_MAX_TEXT_LINES = 128;
        public static int RAYGUI_TEXTSPLIT_MAX_ITEMS = 128;
        public static int RAYGUI_TEXTSPLIT_MAX_TEXT_SIZE = 1024;
        public static bool RAYGUI_NO_ICONS = false;
        public static bool SUPPORT_SCROLLBAR_KEY_INPUT = false;
        public static int AUTO_CURSOR_COOLDOWN = 40;        // Frames to wait for autocursor movement
        public static int AUTO_CURSOR_DELAY = 1;       // Frames delay for autocursor movement
        public static int RAYGUI_TEXTINPUTBOX_BUTTON_HEIGHT = 24;
        public static int RAYGUI_TEXTINPUTBOX_BUTTON_PADDING = 12;
        public static int RAYGUI_TEXTINPUTBOX_HEIGHT = 26;
        public static int RAYGUI_COLORBARALPHA_CHECKED_SIZE = 10;
        public static int RAYGUI_MESSAGEBOX_BUTTON_HEIGHT = 24;
        public static int RAYGUI_TABBAR_ITEM_WIDTH = 160;
        public static int RAYGUI_MESSAGEBOX_BUTTON_PADDING = 12;
        public static int RAYGUI_VALUEBOX_MAX_CHARS = 32;
        public static int RAYGUI_GROUPBOX_LINE_THICK = 1;
        public static int RAYGUI_LINE_MARGIN_TEXT = 12;
        public static int RAYGUI_MIN_SCROLLBAR_WIDTH = 40;
        public static int RAYGUI_MIN_SCROLLBAR_HEIGHT = 40;
        public static int RAYGUI_LINE_TEXT_PADDING = 4;

        public static float RAYGUI_GRID_ALPHA = 0.15f;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TEXT_VALIGN_PIXEL_OFFSET(int h) => (h % 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int TEXT_VALIGN_PIXEL_OFFSET(float h) => ((int)h % 2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool CHECK_BOUNDS_ID(Rectangle src , Rectangle dst) => ((src.x == dst.x) && (src.y == dst.y) &&
            (src.width == dst.width) && (src.height == dst.height));

        public static int ICON_TEXT_PADDING = 4;
        public static bool guiLocked = false;                  // Gui lock state (no inputs processed)
        public static float guiAlpha = 1.0f;                   // Gui element transpacency on drawing
        public static bool guiSliderDragging = false;
        public static uint guiIconScale = 1;
        public static int RAYGUI_ICON_SIZE = 16;          // Size of icons in pixels (squared)
        public static int RAYGUI_ICON_MAX_ICONS = 256;          // Maximum number of icons
        public static int RAYGUI_ICON_MAX_NAME_LENGTH = 32;          // Maximum length of icon name id
        public static uint [ ] guiStyle;
        public static Font guiFont;
        public static int RAYGUI_ICON_DATA_ELEMENTS = (RAYGUI_ICON_SIZE * RAYGUI_ICON_SIZE / 32);
        public static uint [ ] guiIcons;

        public static bool guiTooltip = false;                 // Tooltip enabled/disabled
        public static string? guiTooltipPtr = null;        // Tooltip string pointer (string provided by user)
        static Raygui()
        {
            guiIcons = new uint [ ]{
0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_NONE
    0x3ff80000, 0x2f082008, 0x2042207e, 0x40027fc2, 0x40024002, 0x40024002, 0x40024002, 0x00007ffe,      // ICON_FOLDER_FILE_OPEN
    0x3ffe0000, 0x44226422, 0x400247e2, 0x5ffa4002, 0x57ea500a, 0x500a500a, 0x40025ffa, 0x00007ffe,      // ICON_FILE_SAVE_CLASSIC
    0x00000000, 0x0042007e, 0x40027fc2, 0x40024002, 0x41024002, 0x44424282, 0x793e4102, 0x00000100,      // ICON_FOLDER_OPEN
    0x00000000, 0x0042007e, 0x40027fc2, 0x40024002, 0x41024102, 0x44424102, 0x793e4282, 0x00000000,      // ICON_FOLDER_SAVE
    0x3ff00000, 0x201c2010, 0x20042004, 0x21042004, 0x24442284, 0x21042104, 0x20042104, 0x00003ffc,      // ICON_FILE_OPEN
    0x3ff00000, 0x201c2010, 0x20042004, 0x21042004, 0x21042104, 0x22842444, 0x20042104, 0x00003ffc,      // ICON_FILE_SAVE
    0x3ff00000, 0x201c2010, 0x00042004, 0x20041004, 0x20844784, 0x00841384, 0x20042784, 0x00003ffc,      // ICON_FILE_EXPORT
    0x3ff00000, 0x201c2010, 0x20042004, 0x20042004, 0x22042204, 0x22042f84, 0x20042204, 0x00003ffc,      // ICON_FILE_ADD
    0x3ff00000, 0x201c2010, 0x20042004, 0x20042004, 0x25042884, 0x25042204, 0x20042884, 0x00003ffc,      // ICON_FILE_DELETE
    0x3ff00000, 0x201c2010, 0x20042004, 0x20042ff4, 0x20042ff4, 0x20042ff4, 0x20042004, 0x00003ffc,      // ICON_FILETYPE_TEXT
    0x3ff00000, 0x201c2010, 0x27042004, 0x244424c4, 0x26442444, 0x20642664, 0x20042004, 0x00003ffc,      // ICON_FILETYPE_AUDIO
    0x3ff00000, 0x201c2010, 0x26042604, 0x20042004, 0x35442884, 0x2414222c, 0x20042004, 0x00003ffc,      // ICON_FILETYPE_IMAGE
    0x3ff00000, 0x201c2010, 0x20c42004, 0x22442144, 0x22442444, 0x20c42144, 0x20042004, 0x00003ffc,      // ICON_FILETYPE_PLAY
    0x3ff00000, 0x3ffc2ff0, 0x3f3c2ff4, 0x3dbc2eb4, 0x3dbc2bb4, 0x3f3c2eb4, 0x3ffc2ff4, 0x00002ff4,      // ICON_FILETYPE_VIDEO
    0x3ff00000, 0x201c2010, 0x21842184, 0x21842004, 0x21842184, 0x21842184, 0x20042184, 0x00003ffc,      // ICON_FILETYPE_INFO
    0x0ff00000, 0x381c0810, 0x28042804, 0x28042804, 0x28042804, 0x28042804, 0x20102ffc, 0x00003ff0,      // ICON_FILE_COPY
    0x00000000, 0x701c0000, 0x079c1e14, 0x55a000f0, 0x079c00f0, 0x701c1e14, 0x00000000, 0x00000000,      // ICON_FILE_CUT
    0x01c00000, 0x13e41bec, 0x3f841004, 0x204420c4, 0x20442044, 0x20442044, 0x207c2044, 0x00003fc0,      // ICON_FILE_PASTE
    0x00000000, 0x3aa00fe0, 0x2abc2aa0, 0x2aa42aa4, 0x20042aa4, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_CURSOR_HAND
    0x00000000, 0x003c000c, 0x030800c8, 0x30100c10, 0x10202020, 0x04400840, 0x01800280, 0x00000000,      // ICON_CURSOR_POINTER
    0x00000000, 0x00180000, 0x01f00078, 0x03e007f0, 0x07c003e0, 0x04000e40, 0x00000000, 0x00000000,      // ICON_CURSOR_CLASSIC
    0x00000000, 0x04000000, 0x11000a00, 0x04400a80, 0x01100220, 0x00580088, 0x00000038, 0x00000000,      // ICON_PENCIL
    0x04000000, 0x15000a00, 0x50402880, 0x14102820, 0x05040a08, 0x015c028c, 0x007c00bc, 0x00000000,      // ICON_PENCIL_BIG
    0x01c00000, 0x01400140, 0x01400140, 0x0ff80140, 0x0ff80808, 0x0aa80808, 0x0aa80aa8, 0x00000ff8,      // ICON_BRUSH_CLASSIC
    0x1ffc0000, 0x5ffc7ffe, 0x40004000, 0x00807f80, 0x01c001c0, 0x01c001c0, 0x01c001c0, 0x00000080,      // ICON_BRUSH_PAINTER
    0x00000000, 0x00800000, 0x01c00080, 0x03e001c0, 0x07f003e0, 0x036006f0, 0x000001c0, 0x00000000,      // ICON_WATER_DROP
    0x00000000, 0x3e003800, 0x1f803f80, 0x0c201e40, 0x02080c10, 0x00840104, 0x00380044, 0x00000000,      // ICON_COLOR_PICKER
    0x00000000, 0x07800300, 0x1fe00fc0, 0x3f883fd0, 0x0e021f04, 0x02040402, 0x00f00108, 0x00000000,      // ICON_RUBBER
    0x00c00000, 0x02800140, 0x08200440, 0x20081010, 0x2ffe3004, 0x03f807fc, 0x00e001f0, 0x00000040,      // ICON_COLOR_BUCKET
    0x00000000, 0x21843ffc, 0x01800180, 0x01800180, 0x01800180, 0x01800180, 0x03c00180, 0x00000000,      // ICON_TEXT_T
    0x00800000, 0x01400180, 0x06200340, 0x0c100620, 0x1ff80c10, 0x380c1808, 0x70067004, 0x0000f80f,      // ICON_TEXT_A
    0x78000000, 0x50004000, 0x00004800, 0x03c003c0, 0x03c003c0, 0x00100000, 0x0002000a, 0x0000000e,      // ICON_SCALE
    0x75560000, 0x5e004002, 0x54001002, 0x41001202, 0x408200fe, 0x40820082, 0x40820082, 0x00006afe,      // ICON_RESIZE
    0x00000000, 0x3f003f00, 0x3f003f00, 0x3f003f00, 0x00400080, 0x001c0020, 0x001c001c, 0x00000000,      // ICON_FILTER_POINT
    0x6d800000, 0x00004080, 0x40804080, 0x40800000, 0x00406d80, 0x001c0020, 0x001c001c, 0x00000000,      // ICON_FILTER_BILINEAR
    0x40080000, 0x1ffe2008, 0x14081008, 0x11081208, 0x10481088, 0x10081028, 0x10047ff8, 0x00001002,      // ICON_CROP
    0x00100000, 0x3ffc0010, 0x2ab03550, 0x22b02550, 0x20b02150, 0x20302050, 0x2000fff0, 0x00002000,      // ICON_CROP_ALPHA
    0x40000000, 0x1ff82000, 0x04082808, 0x01082208, 0x00482088, 0x00182028, 0x35542008, 0x00000002,      // ICON_SQUARE_TOGGLE
    0x00000000, 0x02800280, 0x06c006c0, 0x0ea00ee0, 0x1e901eb0, 0x3e883e98, 0x7efc7e8c, 0x00000000,      // ICON_SYMMETRY
    0x01000000, 0x05600100, 0x1d480d50, 0x7d423d44, 0x3d447d42, 0x0d501d48, 0x01000560, 0x00000100,      // ICON_SYMMETRY_HORIZONTAL
    0x01800000, 0x04200240, 0x10080810, 0x00001ff8, 0x00007ffe, 0x0ff01ff8, 0x03c007e0, 0x00000180,      // ICON_SYMMETRY_VERTICAL
    0x00000000, 0x010800f0, 0x02040204, 0x02040204, 0x07f00308, 0x1c000e00, 0x30003800, 0x00000000,      // ICON_LENS
    0x00000000, 0x061803f0, 0x08240c0c, 0x08040814, 0x0c0c0804, 0x23f01618, 0x18002400, 0x00000000,      // ICON_LENS_BIG
    0x00000000, 0x00000000, 0x1c7007c0, 0x638e3398, 0x1c703398, 0x000007c0, 0x00000000, 0x00000000,      // ICON_EYE_ON
    0x00000000, 0x10002000, 0x04700fc0, 0x610e3218, 0x1c703098, 0x001007a0, 0x00000008, 0x00000000,      // ICON_EYE_OFF
    0x00000000, 0x00007ffc, 0x40047ffc, 0x10102008, 0x04400820, 0x02800280, 0x02800280, 0x00000100,      // ICON_FILTER_TOP
    0x00000000, 0x40027ffe, 0x10082004, 0x04200810, 0x02400240, 0x02400240, 0x01400240, 0x000000c0,      // ICON_FILTER
    0x00800000, 0x00800080, 0x00000080, 0x3c9e0000, 0x00000000, 0x00800080, 0x00800080, 0x00000000,      // ICON_TARGET_POINT
    0x00800000, 0x00800080, 0x00800080, 0x3f7e01c0, 0x008001c0, 0x00800080, 0x00800080, 0x00000000,      // ICON_TARGET_SMALL
    0x00800000, 0x00800080, 0x03e00080, 0x3e3e0220, 0x03e00220, 0x00800080, 0x00800080, 0x00000000,      // ICON_TARGET_BIG
    0x01000000, 0x04400280, 0x01000100, 0x43842008, 0x43849ab2, 0x01002008, 0x04400100, 0x01000280,      // ICON_TARGET_MOVE
    0x01000000, 0x04400280, 0x01000100, 0x41042108, 0x41049ff2, 0x01002108, 0x04400100, 0x01000280,      // ICON_CURSOR_MOVE
    0x781e0000, 0x500a4002, 0x04204812, 0x00000240, 0x02400000, 0x48120420, 0x4002500a, 0x0000781e,      // ICON_CURSOR_SCALE
    0x00000000, 0x20003c00, 0x24002800, 0x01000200, 0x00400080, 0x00140024, 0x003c0004, 0x00000000,      // ICON_CURSOR_SCALE_RIGHT
    0x00000000, 0x0004003c, 0x00240014, 0x00800040, 0x02000100, 0x28002400, 0x3c002000, 0x00000000,      // ICON_CURSOR_SCALE_LEFT
    0x00000000, 0x00100020, 0x10101fc8, 0x10001020, 0x10001000, 0x10001000, 0x00001fc0, 0x00000000,      // ICON_UNDO
    0x00000000, 0x08000400, 0x080813f8, 0x00080408, 0x00080008, 0x00080008, 0x000003f8, 0x00000000,      // ICON_REDO
    0x00000000, 0x3ffc0000, 0x20042004, 0x20002000, 0x20402000, 0x3f902020, 0x00400020, 0x00000000,      // ICON_REREDO
    0x00000000, 0x3ffc0000, 0x20042004, 0x27fc2004, 0x20202000, 0x3fc82010, 0x00200010, 0x00000000,      // ICON_MUTATE
    0x00000000, 0x0ff00000, 0x10081818, 0x11801008, 0x10001180, 0x18101020, 0x00100fc8, 0x00000020,      // ICON_ROTATE
    0x00000000, 0x04000200, 0x240429fc, 0x20042204, 0x20442004, 0x3f942024, 0x00400020, 0x00000000,      // ICON_REPEAT
    0x00000000, 0x20001000, 0x22104c0e, 0x00801120, 0x11200040, 0x4c0e2210, 0x10002000, 0x00000000,      // ICON_SHUFFLE
    0x7ffe0000, 0x50024002, 0x44024802, 0x41024202, 0x40424082, 0x40124022, 0x4002400a, 0x00007ffe,      // ICON_EMPTYBOX
    0x00800000, 0x03e00080, 0x08080490, 0x3c9e0808, 0x08080808, 0x03e00490, 0x00800080, 0x00000000,      // ICON_TARGET
    0x00800000, 0x00800080, 0x00800080, 0x3ffe01c0, 0x008001c0, 0x00800080, 0x00800080, 0x00000000,      // ICON_TARGET_SMALL_FILL
    0x00800000, 0x00800080, 0x03e00080, 0x3ffe03e0, 0x03e003e0, 0x00800080, 0x00800080, 0x00000000,      // ICON_TARGET_BIG_FILL
    0x01000000, 0x07c00380, 0x01000100, 0x638c2008, 0x638cfbbe, 0x01002008, 0x07c00100, 0x01000380,      // ICON_TARGET_MOVE_FILL
    0x01000000, 0x07c00380, 0x01000100, 0x610c2108, 0x610cfffe, 0x01002108, 0x07c00100, 0x01000380,      // ICON_CURSOR_MOVE_FILL
    0x781e0000, 0x6006700e, 0x04204812, 0x00000240, 0x02400000, 0x48120420, 0x700e6006, 0x0000781e,      // ICON_CURSOR_SCALE_FILL
    0x00000000, 0x38003c00, 0x24003000, 0x01000200, 0x00400080, 0x000c0024, 0x003c001c, 0x00000000,      // ICON_CURSOR_SCALE_RIGHT_FILL
    0x00000000, 0x001c003c, 0x0024000c, 0x00800040, 0x02000100, 0x30002400, 0x3c003800, 0x00000000,      // ICON_CURSOR_SCALE_LEFT_FILL
    0x00000000, 0x00300020, 0x10301ff8, 0x10001020, 0x10001000, 0x10001000, 0x00001fc0, 0x00000000,      // ICON_UNDO_FILL
    0x00000000, 0x0c000400, 0x0c081ff8, 0x00080408, 0x00080008, 0x00080008, 0x000003f8, 0x00000000,      // ICON_REDO_FILL
    0x00000000, 0x3ffc0000, 0x20042004, 0x20002000, 0x20402000, 0x3ff02060, 0x00400060, 0x00000000,      // ICON_REREDO_FILL
    0x00000000, 0x3ffc0000, 0x20042004, 0x27fc2004, 0x20202000, 0x3ff82030, 0x00200030, 0x00000000,      // ICON_MUTATE_FILL
    0x00000000, 0x0ff00000, 0x10081818, 0x11801008, 0x10001180, 0x18301020, 0x00300ff8, 0x00000020,      // ICON_ROTATE_FILL
    0x00000000, 0x06000200, 0x26042ffc, 0x20042204, 0x20442004, 0x3ff42064, 0x00400060, 0x00000000,      // ICON_REPEAT_FILL
    0x00000000, 0x30001000, 0x32107c0e, 0x00801120, 0x11200040, 0x7c0e3210, 0x10003000, 0x00000000,      // ICON_SHUFFLE_FILL
    0x00000000, 0x30043ffc, 0x24042804, 0x21042204, 0x20442084, 0x20142024, 0x3ffc200c, 0x00000000,      // ICON_EMPTYBOX_SMALL
    0x00000000, 0x20043ffc, 0x20042004, 0x20042004, 0x20042004, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX
    0x00000000, 0x23c43ffc, 0x23c423c4, 0x200423c4, 0x20042004, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX_TOP
    0x00000000, 0x3e043ffc, 0x3e043e04, 0x20043e04, 0x20042004, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX_TOP_RIGHT
    0x00000000, 0x20043ffc, 0x20042004, 0x3e043e04, 0x3e043e04, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX_RIGHT
    0x00000000, 0x20043ffc, 0x20042004, 0x20042004, 0x3e042004, 0x3e043e04, 0x3ffc3e04, 0x00000000,      // ICON_BOX_BOTTOM_RIGHT
    0x00000000, 0x20043ffc, 0x20042004, 0x20042004, 0x23c42004, 0x23c423c4, 0x3ffc23c4, 0x00000000,      // ICON_BOX_BOTTOM
    0x00000000, 0x20043ffc, 0x20042004, 0x20042004, 0x207c2004, 0x207c207c, 0x3ffc207c, 0x00000000,      // ICON_BOX_BOTTOM_LEFT
    0x00000000, 0x20043ffc, 0x20042004, 0x207c207c, 0x207c207c, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX_LEFT
    0x00000000, 0x207c3ffc, 0x207c207c, 0x2004207c, 0x20042004, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX_TOP_LEFT
    0x00000000, 0x20043ffc, 0x20042004, 0x23c423c4, 0x23c423c4, 0x20042004, 0x3ffc2004, 0x00000000,      // ICON_BOX_CENTER
    0x7ffe0000, 0x40024002, 0x47e24182, 0x4ff247e2, 0x47e24ff2, 0x418247e2, 0x40024002, 0x00007ffe,      // ICON_BOX_CIRCLE_MASK
    0x7fff0000, 0x40014001, 0x40014001, 0x49555ddd, 0x4945495d, 0x400149c5, 0x40014001, 0x00007fff,      // ICON_POT
    0x7ffe0000, 0x53327332, 0x44ce4cce, 0x41324332, 0x404e40ce, 0x48125432, 0x4006540e, 0x00007ffe,      // ICON_ALPHA_MULTIPLY
    0x7ffe0000, 0x53327332, 0x44ce4cce, 0x41324332, 0x5c4e40ce, 0x44124432, 0x40065c0e, 0x00007ffe,      // ICON_ALPHA_CLEAR
    0x7ffe0000, 0x42fe417e, 0x42fe417e, 0x42fe417e, 0x42fe417e, 0x42fe417e, 0x42fe417e, 0x00007ffe,      // ICON_DITHERING
    0x07fe0000, 0x1ffa0002, 0x7fea000a, 0x402a402a, 0x5b2a512a, 0x5128552a, 0x40205128, 0x00007fe0,      // ICON_MIPMAPS
    0x00000000, 0x1ff80000, 0x12481248, 0x12481ff8, 0x1ff81248, 0x12481248, 0x00001ff8, 0x00000000,      // ICON_BOX_GRID
    0x12480000, 0x7ffe1248, 0x12481248, 0x12487ffe, 0x7ffe1248, 0x12481248, 0x12487ffe, 0x00001248,      // ICON_GRID
    0x00000000, 0x1c380000, 0x1c3817e8, 0x08100810, 0x08100810, 0x17e81c38, 0x00001c38, 0x00000000,      // ICON_BOX_CORNERS_SMALL
    0x700e0000, 0x700e5ffa, 0x20042004, 0x20042004, 0x20042004, 0x20042004, 0x5ffa700e, 0x0000700e,      // ICON_BOX_CORNERS_BIG
    0x3f7e0000, 0x21422142, 0x21422142, 0x00003f7e, 0x21423f7e, 0x21422142, 0x3f7e2142, 0x00000000,      // ICON_FOUR_BOXES
    0x00000000, 0x3bb80000, 0x3bb83bb8, 0x3bb80000, 0x3bb83bb8, 0x3bb80000, 0x3bb83bb8, 0x00000000,      // ICON_GRID_FILL
    0x7ffe0000, 0x7ffe7ffe, 0x77fe7000, 0x77fe77fe, 0x777e7700, 0x777e777e, 0x777e777e, 0x0000777e,      // ICON_BOX_MULTISIZE
    0x781e0000, 0x40024002, 0x00004002, 0x01800000, 0x00000180, 0x40020000, 0x40024002, 0x0000781e,      // ICON_ZOOM_SMALL
    0x781e0000, 0x40024002, 0x00004002, 0x03c003c0, 0x03c003c0, 0x40020000, 0x40024002, 0x0000781e,      // ICON_ZOOM_MEDIUM
    0x781e0000, 0x40024002, 0x07e04002, 0x07e007e0, 0x07e007e0, 0x400207e0, 0x40024002, 0x0000781e,      // ICON_ZOOM_BIG
    0x781e0000, 0x5ffa4002, 0x1ff85ffa, 0x1ff81ff8, 0x1ff81ff8, 0x5ffa1ff8, 0x40025ffa, 0x0000781e,      // ICON_ZOOM_ALL
    0x00000000, 0x2004381c, 0x00002004, 0x00000000, 0x00000000, 0x20040000, 0x381c2004, 0x00000000,      // ICON_ZOOM_CENTER
    0x00000000, 0x1db80000, 0x10081008, 0x10080000, 0x00001008, 0x10081008, 0x00001db8, 0x00000000,      // ICON_BOX_DOTS_SMALL
    0x35560000, 0x00002002, 0x00002002, 0x00002002, 0x00002002, 0x00002002, 0x35562002, 0x00000000,      // ICON_BOX_DOTS_BIG
    0x7ffe0000, 0x40024002, 0x48124ff2, 0x49924812, 0x48124992, 0x4ff24812, 0x40024002, 0x00007ffe,      // ICON_BOX_CONCENTRIC
    0x00000000, 0x10841ffc, 0x10841084, 0x1ffc1084, 0x10841084, 0x10841084, 0x00001ffc, 0x00000000,      // ICON_BOX_GRID_BIG
    0x00000000, 0x00000000, 0x10000000, 0x04000800, 0x01040200, 0x00500088, 0x00000020, 0x00000000,      // ICON_OK_TICK
    0x00000000, 0x10080000, 0x04200810, 0x01800240, 0x02400180, 0x08100420, 0x00001008, 0x00000000,      // ICON_CROSS
    0x00000000, 0x02000000, 0x00800100, 0x00200040, 0x00200010, 0x00800040, 0x02000100, 0x00000000,      // ICON_ARROW_LEFT
    0x00000000, 0x00400000, 0x01000080, 0x04000200, 0x04000800, 0x01000200, 0x00400080, 0x00000000,      // ICON_ARROW_RIGHT
    0x00000000, 0x00000000, 0x00000000, 0x08081004, 0x02200410, 0x00800140, 0x00000000, 0x00000000,      // ICON_ARROW_DOWN
    0x00000000, 0x00000000, 0x01400080, 0x04100220, 0x10040808, 0x00000000, 0x00000000, 0x00000000,      // ICON_ARROW_UP
    0x00000000, 0x02000000, 0x03800300, 0x03e003c0, 0x03e003f0, 0x038003c0, 0x02000300, 0x00000000,      // ICON_ARROW_LEFT_FILL
    0x00000000, 0x00400000, 0x01c000c0, 0x07c003c0, 0x07c00fc0, 0x01c003c0, 0x004000c0, 0x00000000,      // ICON_ARROW_RIGHT_FILL
    0x00000000, 0x00000000, 0x00000000, 0x0ff81ffc, 0x03e007f0, 0x008001c0, 0x00000000, 0x00000000,      // ICON_ARROW_DOWN_FILL
    0x00000000, 0x00000000, 0x01c00080, 0x07f003e0, 0x1ffc0ff8, 0x00000000, 0x00000000, 0x00000000,      // ICON_ARROW_UP_FILL
    0x00000000, 0x18a008c0, 0x32881290, 0x24822686, 0x26862482, 0x12903288, 0x08c018a0, 0x00000000,      // ICON_AUDIO
    0x00000000, 0x04800780, 0x004000c0, 0x662000f0, 0x08103c30, 0x130a0e18, 0x0000318e, 0x00000000,      // ICON_FX
    0x00000000, 0x00800000, 0x08880888, 0x2aaa0a8a, 0x0a8a2aaa, 0x08880888, 0x00000080, 0x00000000,      // ICON_WAVE
    0x00000000, 0x00600000, 0x01080090, 0x02040108, 0x42044204, 0x24022402, 0x00001800, 0x00000000,      // ICON_WAVE_SINUS
    0x00000000, 0x07f80000, 0x04080408, 0x04080408, 0x04080408, 0x7c0e0408, 0x00000000, 0x00000000,      // ICON_WAVE_SQUARE
    0x00000000, 0x00000000, 0x00a00040, 0x22084110, 0x08021404, 0x00000000, 0x00000000, 0x00000000,      // ICON_WAVE_TRIANGULAR
    0x00000000, 0x00000000, 0x04200000, 0x01800240, 0x02400180, 0x00000420, 0x00000000, 0x00000000,      // ICON_CROSS_SMALL
    0x00000000, 0x18380000, 0x12281428, 0x10a81128, 0x112810a8, 0x14281228, 0x00001838, 0x00000000,      // ICON_PLAYER_PREVIOUS
    0x00000000, 0x18000000, 0x11801600, 0x10181060, 0x10601018, 0x16001180, 0x00001800, 0x00000000,      // ICON_PLAYER_PLAY_BACK
    0x00000000, 0x00180000, 0x01880068, 0x18080608, 0x06081808, 0x00680188, 0x00000018, 0x00000000,      // ICON_PLAYER_PLAY
    0x00000000, 0x1e780000, 0x12481248, 0x12481248, 0x12481248, 0x12481248, 0x00001e78, 0x00000000,      // ICON_PLAYER_PAUSE
    0x00000000, 0x1ff80000, 0x10081008, 0x10081008, 0x10081008, 0x10081008, 0x00001ff8, 0x00000000,      // ICON_PLAYER_STOP
    0x00000000, 0x1c180000, 0x14481428, 0x15081488, 0x14881508, 0x14281448, 0x00001c18, 0x00000000,      // ICON_PLAYER_NEXT
    0x00000000, 0x03c00000, 0x08100420, 0x10081008, 0x10081008, 0x04200810, 0x000003c0, 0x00000000,      // ICON_PLAYER_RECORD
    0x00000000, 0x0c3007e0, 0x13c81818, 0x14281668, 0x14281428, 0x1c381c38, 0x08102244, 0x00000000,      // ICON_MAGNET
    0x07c00000, 0x08200820, 0x3ff80820, 0x23882008, 0x21082388, 0x20082108, 0x1ff02008, 0x00000000,      // ICON_LOCK_CLOSE
    0x07c00000, 0x08000800, 0x3ff80800, 0x23882008, 0x21082388, 0x20082108, 0x1ff02008, 0x00000000,      // ICON_LOCK_OPEN
    0x01c00000, 0x0c180770, 0x3086188c, 0x60832082, 0x60034781, 0x30062002, 0x0c18180c, 0x01c00770,      // ICON_CLOCK
    0x0a200000, 0x1b201b20, 0x04200e20, 0x04200420, 0x04700420, 0x0e700e70, 0x0e700e70, 0x04200e70,      // ICON_TOOLS
    0x01800000, 0x3bdc318c, 0x0ff01ff8, 0x7c3e1e78, 0x1e787c3e, 0x1ff80ff0, 0x318c3bdc, 0x00000180,      // ICON_GEAR
    0x01800000, 0x3ffc318c, 0x1c381ff8, 0x781e1818, 0x1818781e, 0x1ff81c38, 0x318c3ffc, 0x00000180,      // ICON_GEAR_BIG
    0x00000000, 0x08080ff8, 0x08081ffc, 0x0aa80aa8, 0x0aa80aa8, 0x0aa80aa8, 0x08080aa8, 0x00000ff8,      // ICON_BIN
    0x00000000, 0x00000000, 0x20043ffc, 0x08043f84, 0x04040f84, 0x04040784, 0x000007fc, 0x00000000,      // ICON_HAND_POINTER
    0x00000000, 0x24400400, 0x00001480, 0x6efe0e00, 0x00000e00, 0x24401480, 0x00000400, 0x00000000,      // ICON_LASER
    0x00000000, 0x03c00000, 0x08300460, 0x11181118, 0x11181118, 0x04600830, 0x000003c0, 0x00000000,      // ICON_COIN
    0x00000000, 0x10880080, 0x06c00810, 0x366c07e0, 0x07e00240, 0x00001768, 0x04200240, 0x00000000,      // ICON_EXPLOSION
    0x00000000, 0x3d280000, 0x2528252c, 0x3d282528, 0x05280528, 0x05e80528, 0x00000000, 0x00000000,      // ICON_1UP
    0x01800000, 0x03c003c0, 0x018003c0, 0x0ff007e0, 0x0bd00bd0, 0x0a500bd0, 0x02400240, 0x02400240,      // ICON_PLAYER
    0x01800000, 0x03c003c0, 0x118013c0, 0x03c81ff8, 0x07c003c8, 0x04400440, 0x0c080478, 0x00000000,      // ICON_PLAYER_JUMP
    0x3ff80000, 0x30183ff8, 0x30183018, 0x3ff83ff8, 0x03000300, 0x03c003c0, 0x03e00300, 0x000003e0,      // ICON_KEY
    0x3ff80000, 0x3ff83ff8, 0x33983ff8, 0x3ff83398, 0x3ff83ff8, 0x00000540, 0x0fe00aa0, 0x00000fe0,      // ICON_DEMON
    0x00000000, 0x0ff00000, 0x20041008, 0x25442004, 0x10082004, 0x06000bf0, 0x00000300, 0x00000000,      // ICON_TEXT_POPUP
    0x00000000, 0x11440000, 0x07f00be8, 0x1c1c0e38, 0x1c1c0c18, 0x07f00e38, 0x11440be8, 0x00000000,      // ICON_GEAR_EX
    0x00000000, 0x20080000, 0x0c601010, 0x07c00fe0, 0x07c007c0, 0x0c600fe0, 0x20081010, 0x00000000,      // ICON_CRACK
    0x00000000, 0x20080000, 0x0c601010, 0x04400fe0, 0x04405554, 0x0c600fe0, 0x20081010, 0x00000000,      // ICON_CRACK_POINTS
    0x00000000, 0x00800080, 0x01c001c0, 0x1ffc3ffe, 0x03e007f0, 0x07f003e0, 0x0c180770, 0x00000808,      // ICON_STAR
    0x0ff00000, 0x08180810, 0x08100818, 0x0a100810, 0x08180810, 0x08100818, 0x08100810, 0x00001ff8,      // ICON_DOOR
    0x0ff00000, 0x08100810, 0x08100810, 0x10100010, 0x4f902010, 0x10102010, 0x08100010, 0x00000ff0,      // ICON_EXIT
    0x00040000, 0x001f000e, 0x0ef40004, 0x12f41284, 0x0ef41214, 0x10040004, 0x7ffc3004, 0x10003000,      // ICON_MODE_2D
    0x78040000, 0x501f600e, 0x0ef44004, 0x12f41284, 0x0ef41284, 0x10140004, 0x7ffc300c, 0x10003000,      // ICON_MODE_3D
    0x7fe00000, 0x50286030, 0x47fe4804, 0x44224402, 0x44224422, 0x241275e2, 0x0c06140a, 0x000007fe,      // ICON_CUBE
    0x7fe00000, 0x5ff87ff0, 0x47fe4ffc, 0x44224402, 0x44224422, 0x241275e2, 0x0c06140a, 0x000007fe,      // ICON_CUBE_FACE_TOP
    0x7fe00000, 0x50386030, 0x47c2483c, 0x443e443e, 0x443e443e, 0x241e75fe, 0x0c06140e, 0x000007fe,      // ICON_CUBE_FACE_LEFT
    0x7fe00000, 0x50286030, 0x47fe4804, 0x47fe47fe, 0x47fe47fe, 0x27fe77fe, 0x0ffe17fe, 0x000007fe,      // ICON_CUBE_FACE_FRONT
    0x7fe00000, 0x50286030, 0x47fe4804, 0x44224402, 0x44224422, 0x3bf27be2, 0x0bfe1bfa, 0x000007fe,      // ICON_CUBE_FACE_BOTTOM
    0x7fe00000, 0x70286030, 0x7ffe7804, 0x7c227c02, 0x7c227c22, 0x3c127de2, 0x0c061c0a, 0x000007fe,      // ICON_CUBE_FACE_RIGHT
    0x7fe00000, 0x6fe85ff0, 0x781e77e4, 0x7be27be2, 0x7be27be2, 0x24127be2, 0x0c06140a, 0x000007fe,      // ICON_CUBE_FACE_BACK
    0x00000000, 0x2a0233fe, 0x22022602, 0x22022202, 0x2a022602, 0x00a033fe, 0x02080110, 0x00000000,      // ICON_CAMERA
    0x00000000, 0x200c3ffc, 0x000c000c, 0x3ffc000c, 0x30003000, 0x30003000, 0x3ffc3004, 0x00000000,      // ICON_SPECIAL
    0x00000000, 0x0022003e, 0x012201e2, 0x0100013e, 0x01000100, 0x79000100, 0x4f004900, 0x00007800,      // ICON_LINK_NET
    0x00000000, 0x44007c00, 0x45004600, 0x00627cbe, 0x00620022, 0x45007cbe, 0x44004600, 0x00007c00,      // ICON_LINK_BOXES
    0x00000000, 0x0044007c, 0x0010007c, 0x3f100010, 0x3f1021f0, 0x3f100010, 0x3f0021f0, 0x00000000,      // ICON_LINK_MULTI
    0x00000000, 0x0044007c, 0x00440044, 0x0010007c, 0x00100010, 0x44107c10, 0x440047f0, 0x00007c00,      // ICON_LINK
    0x00000000, 0x0044007c, 0x00440044, 0x0000007c, 0x00000010, 0x44007c10, 0x44004550, 0x00007c00,      // ICON_LINK_BROKE
    0x02a00000, 0x22a43ffc, 0x20042004, 0x20042ff4, 0x20042ff4, 0x20042ff4, 0x20042004, 0x00003ffc,      // ICON_TEXT_NOTES
    0x3ffc0000, 0x20042004, 0x245e27c4, 0x27c42444, 0x2004201e, 0x201e2004, 0x20042004, 0x00003ffc,      // ICON_NOTEBOOK
    0x00000000, 0x07e00000, 0x04200420, 0x24243ffc, 0x24242424, 0x24242424, 0x3ffc2424, 0x00000000,      // ICON_SUITCASE
    0x00000000, 0x0fe00000, 0x08200820, 0x40047ffc, 0x7ffc5554, 0x40045554, 0x7ffc4004, 0x00000000,      // ICON_SUITCASE_ZIP
    0x00000000, 0x20043ffc, 0x3ffc2004, 0x13c81008, 0x100813c8, 0x10081008, 0x1ff81008, 0x00000000,      // ICON_MAILBOX
    0x00000000, 0x40027ffe, 0x5ffa5ffa, 0x5ffa5ffa, 0x40025ffa, 0x03c07ffe, 0x1ff81ff8, 0x00000000,      // ICON_MONITOR
    0x0ff00000, 0x6bfe7ffe, 0x7ffe7ffe, 0x68167ffe, 0x08106816, 0x08100810, 0x0ff00810, 0x00000000,      // ICON_PRINTER
    0x3ff80000, 0xfffe2008, 0x870a8002, 0x904a888a, 0x904a904a, 0x870a888a, 0xfffe8002, 0x00000000,      // ICON_PHOTO_CAMERA
    0x0fc00000, 0xfcfe0cd8, 0x8002fffe, 0x84428382, 0x84428442, 0x80028382, 0xfffe8002, 0x00000000,      // ICON_PHOTO_CAMERA_FLASH
    0x00000000, 0x02400180, 0x08100420, 0x20041008, 0x23c42004, 0x22442244, 0x3ffc2244, 0x00000000,      // ICON_HOUSE
    0x00000000, 0x1c700000, 0x3ff83ef8, 0x3ff83ff8, 0x0fe01ff0, 0x038007c0, 0x00000100, 0x00000000,      // ICON_HEART
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x80000000, 0xe000c000,      // ICON_CORNER
    0x00000000, 0x14001c00, 0x15c01400, 0x15401540, 0x155c1540, 0x15541554, 0x1ddc1554, 0x00000000,      // ICON_VERTICAL_BARS
    0x00000000, 0x03000300, 0x1b001b00, 0x1b601b60, 0x1b6c1b60, 0x1b6c1b6c, 0x1b6c1b6c, 0x00000000,      // ICON_VERTICAL_BARS_FILL
    0x00000000, 0x00000000, 0x403e7ffe, 0x7ffe403e, 0x7ffe0000, 0x43fe43fe, 0x00007ffe, 0x00000000,      // ICON_LIFE_BARS
    0x7ffc0000, 0x43844004, 0x43844284, 0x43844004, 0x42844284, 0x42844284, 0x40044384, 0x00007ffc,      // ICON_INFO
    0x40008000, 0x10002000, 0x04000800, 0x01000200, 0x00400080, 0x00100020, 0x00040008, 0x00010002,      // ICON_CROSSLINE
    0x00000000, 0x1ff01ff0, 0x18301830, 0x1f001830, 0x03001f00, 0x00000300, 0x03000300, 0x00000000,      // ICON_HELP
    0x3ff00000, 0x2abc3550, 0x2aac3554, 0x2aac3554, 0x2aac3554, 0x2aac3554, 0x2aac3554, 0x00003ffc,      // ICON_FILETYPE_ALPHA
    0x3ff00000, 0x201c2010, 0x22442184, 0x28142424, 0x29942814, 0x2ff42994, 0x20042004, 0x00003ffc,      // ICON_FILETYPE_HOME
    0x07fe0000, 0x04020402, 0x7fe20402, 0x44224422, 0x44224422, 0x402047fe, 0x40204020, 0x00007fe0,      // ICON_LAYERS_VISIBLE
    0x07fe0000, 0x04020402, 0x7c020402, 0x44024402, 0x44024402, 0x402047fe, 0x40204020, 0x00007fe0,      // ICON_LAYERS
    0x00000000, 0x40027ffe, 0x7ffe4002, 0x40024002, 0x40024002, 0x40024002, 0x7ffe4002, 0x00000000,      // ICON_WINDOW
    0x09100000, 0x09f00910, 0x09100910, 0x00000910, 0x24a2779e, 0x27a224a2, 0x709e20a2, 0x00000000,      // ICON_HIDPI
    0x3ff00000, 0x201c2010, 0x2a842e84, 0x2e842a84, 0x2ba42004, 0x2aa42aa4, 0x20042ba4, 0x00003ffc,      // ICON_FILETYPE_BINARY
    0x00000000, 0x00000000, 0x00120012, 0x4a5e4bd2, 0x485233d2, 0x00004bd2, 0x00000000, 0x00000000,      // ICON_HEX
    0x01800000, 0x381c0660, 0x23c42004, 0x23c42044, 0x13c82204, 0x08101008, 0x02400420, 0x00000180,      // ICON_SHIELD
    0x007e0000, 0x20023fc2, 0x40227fe2, 0x400a403a, 0x400a400a, 0x400a400a, 0x4008400e, 0x00007ff8,      // ICON_FILE_NEW
    0x00000000, 0x0042007e, 0x40027fc2, 0x44024002, 0x5f024402, 0x44024402, 0x7ffe4002, 0x00000000,      // ICON_FOLDER_ADD
    0x44220000, 0x12482244, 0xf3cf0000, 0x14280420, 0x48122424, 0x08100810, 0x1ff81008, 0x03c00420,      // ICON_ALARM
    0x0aa00000, 0x1ff80aa0, 0x1068700e, 0x1008706e, 0x1008700e, 0x1008700e, 0x0aa01ff8, 0x00000aa0,      // ICON_CPU
    0x07e00000, 0x04201db8, 0x04a01c38, 0x04a01d38, 0x04a01d38, 0x04a01d38, 0x04201d38, 0x000007e0,      // ICON_ROM
    0x00000000, 0x03c00000, 0x3c382ff0, 0x3c04380c, 0x01800000, 0x03c003c0, 0x00000180, 0x00000000,      // ICON_STEP_OVER
    0x01800000, 0x01800180, 0x01800180, 0x03c007e0, 0x00000180, 0x01800000, 0x03c003c0, 0x00000180,      // ICON_STEP_INTO
    0x01800000, 0x07e003c0, 0x01800180, 0x01800180, 0x00000180, 0x01800000, 0x03c003c0, 0x00000180,      // ICON_STEP_OUT
    0x00000000, 0x0ff003c0, 0x181c1c34, 0x303c301c, 0x30003000, 0x1c301800, 0x03c00ff0, 0x00000000,      // ICON_RESTART
    0x00000000, 0x00000000, 0x07e003c0, 0x0ff00ff0, 0x0ff00ff0, 0x03c007e0, 0x00000000, 0x00000000,      // ICON_BREAKPOINT_ON
    0x00000000, 0x00000000, 0x042003c0, 0x08100810, 0x08100810, 0x03c00420, 0x00000000, 0x00000000,      // ICON_BREAKPOINT_OFF
    0x00000000, 0x00000000, 0x1ff81ff8, 0x1ff80000, 0x00001ff8, 0x1ff81ff8, 0x00000000, 0x00000000,      // ICON_BURGER_MENU
    0x00000000, 0x00000000, 0x00880070, 0x0c880088, 0x1e8810f8, 0x3e881288, 0x00000000, 0x00000000,      // ICON_CASE_SENSITIVE
    0x00000000, 0x02000000, 0x07000a80, 0x07001fc0, 0x02000a80, 0x00300030, 0x00000000, 0x00000000,      // ICON_REG_EXP
    0x00000000, 0x0042007e, 0x40027fc2, 0x40024002, 0x40024002, 0x40024002, 0x7ffe4002, 0x00000000,      // ICON_FOLDER
    0x3ff00000, 0x201c2010, 0x20042004, 0x20042004, 0x20042004, 0x20042004, 0x20042004, 0x00003ffc,      // ICON_FILE
    0x1ff00000, 0x20082008, 0x17d02fe8, 0x05400ba0, 0x09200540, 0x23881010, 0x2fe827c8, 0x00001ff0,      // ICON_SAND_TIMER
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_220
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_221
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_222
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_223
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_224
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_225
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_226
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_227
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_228
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_229
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_230
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_231
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_232
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_233
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_234
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_235
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_236
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_237
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_238
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_239
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_240
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_241
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_242
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_243
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_244
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_245
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_246
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_247
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_248
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_249
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_250
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_251
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_252
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_253
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,      // ICON_254
    0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,       // ICON_255
};
            guiIconsPtr = guiIcons;
            guiStyle = new uint [ RAYGUI_MAX_CONTROLS * (RAYGUI_MAX_PROPS_BASE + RAYGUI_MAX_PROPS_EXTENDED) ];
            for (int i = 0 ; i < guiStyle.Length ; i++)
            {
                guiStyle [ i ] = 0;
            }
            guiFont = new Font();
        }
        // Gui draw text using default font

        static Rectangle GetTextBounds(int control , Rectangle bounds)
        {
            Rectangle textBounds = bounds;

            textBounds.x = bounds.x + GuiGetStyle(control , BORDER_WIDTH);
            textBounds.y = bounds.y + GuiGetStyle(control , BORDER_WIDTH) + GuiGetStyle(control , TEXT_PADDING);
            textBounds.width = bounds.width - 2 * GuiGetStyle(control , BORDER_WIDTH) - 2 * GuiGetStyle(control , TEXT_PADDING);
            textBounds.height = bounds.height - 2 * GuiGetStyle(control , BORDER_WIDTH) - 2 * GuiGetStyle(control , TEXT_PADDING);

            // Consider TEXT_PADDING properly, depends on control type and TEXT_ALIGNMENT
            // TODO: Special cases (no label): COMBOBOX, DROPDOWNBOX, LISTVIEW (scrollbar?)
            // More special cases (label on side): CHECKBOX, SLIDER, VALUEBOX, SPINNER
            switch (control)
            {
                default:
                    {
                        if (GuiGetStyle(control , TEXT_ALIGNMENT) == TEXT_ALIGN_RIGHT) textBounds.x -= GuiGetStyle(control , TEXT_PADDING);
                        else textBounds.x += GuiGetStyle(control , TEXT_PADDING);
                    }
                    break;
            }

            return textBounds;
        }

        public static Color Fade(Color color , float alpha)
        {
            if (alpha < 0.0f) alpha = 0.0f;
            else if (alpha > 1.0f) alpha = 1.0f;

            Color result = new Color(color.r , color.g , color.b , (byte)(255.0f * alpha));

            return result;
        }
        public static Color GetColor(int hexValue)
        {
            Color color;

            color.r = (byte)((hexValue >> 24) & 0xFF);
            color.g = (byte)((hexValue >> 16) & 0xFF);
            color.b = (byte)((hexValue >> 8) & 0xFF);
            color.a = (byte)(hexValue & 0xFF);

            return color;
        }
        public static Color GetColor(uint hexValue)
        {
            Color color;

            color.r = (byte)((hexValue >> 24) & 0xFF);
            color.g = (byte)((hexValue >> 16) & 0xFF);
            color.b = (byte)((hexValue >> 8) & 0xFF);
            color.a = (byte)(hexValue & 0xFF);

            return color;
        }

        // Toggle Button control, returns true when active
        public static int GuiToggle(Rectangle bounds , int iconID , ReadonlyString text , ref bool active)
        {
            int state = (int)guiState;

            int result = 0;
            // Update control
            //--------------------------------------------------------------------
            if ((state != STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check toggle button state
                if (Raylib.CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = STATE_PRESSED;
                    else if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = STATE_NORMAL;
                        active = !active;
                    }
                    else state = STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (state == STATE_NORMAL)
            {
                GuiDrawRectangle(bounds , (int)GuiGetStyle(TOGGLE , BORDER_WIDTH) , GetColor(GuiGetStyle(TOGGLE , (active ? BORDER_COLOR_PRESSED : (BORDER + state * 3)))) , GetColor(GuiGetStyle(TOGGLE , (active ? BASE_COLOR_PRESSED : (BASE + state * 3)))));
                GuiDrawText(iconID , text , GetTextBounds(TOGGLE , bounds) , (int)GuiGetStyle(TOGGLE , TEXT_ALIGNMENT) , (GetColor(GuiGetStyle(TOGGLE , active ? TEXT_COLOR_PRESSED : (TEXT + state * 3)))));
            }
            else
            {
                GuiDrawRectangle(bounds , (int)GuiGetStyle(TOGGLE , BORDER_WIDTH) , GetColor(GuiGetStyle(TOGGLE , BORDER + state * 3)) , GetColor(GuiGetStyle(TOGGLE , BASE + state * 3)));
                GuiDrawText(iconID , text , GetTextBounds(TOGGLE , bounds) , (int)GuiGetStyle(TOGGLE , TEXT_ALIGNMENT) , GetColor(GuiGetStyle(TOGGLE , TEXT + state * 3)));
            }

            if (state == STATE_FOCUSED) GuiTooltip(bounds);
            //--------------------------------------------------------------------

            return result;
        }
        public static int GuiToggle(Rectangle bounds , ReadonlyString text , ref bool active)
        {
            int result = 0;
            int state = (int)guiState;

            // Update control
            //--------------------------------------------------------------------
            if ((state != STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check toggle button state
                if (Raylib.CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = STATE_PRESSED;
                    else if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = STATE_NORMAL;
                        active = !active;
                    }
                    else state = STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (state == STATE_NORMAL)
            {
                GuiDrawRectangle(bounds , (int)GuiGetStyle(TOGGLE , BORDER_WIDTH) , (GetColor(GuiGetStyle(TOGGLE , (active ? BORDER_COLOR_PRESSED : (BORDER + state * 3))))) , (GetColor(GuiGetStyle(TOGGLE , (active ? BASE_COLOR_PRESSED : (BASE + state * 3))))));
                GuiDrawText(text , GetTextBounds(TOGGLE , bounds) , (int)GuiGetStyle(TOGGLE , TEXT_ALIGNMENT) , (GetColor(GuiGetStyle(TOGGLE , (active ? TEXT_COLOR_PRESSED : (TEXT + state * 3))))));
            }
            else
            {
                GuiDrawRectangle(bounds , (int)GuiGetStyle(TOGGLE , BORDER_WIDTH) , (GetColor(GuiGetStyle(TOGGLE , BORDER + state * 3))) , (GetColor(GuiGetStyle(TOGGLE , BASE + state * 3))));
                GuiDrawText(text , GetTextBounds(TOGGLE , bounds) , (int)GuiGetStyle(TOGGLE , TEXT_ALIGNMENT) , (GetColor(GuiGetStyle(TOGGLE , TEXT + state * 3))));
            }

            if (state == STATE_FOCUSED) GuiTooltip(bounds);
            //--------------------------------------------------------------------

            return result;
        }

        /**
         * Porter note: String in C# is UTF-8 already. 
         **/
        // Get next codepoint in a UTF-8 encoded text, scanning until '\0' is found
        // When a invalid UTF-8 byte is encountered we exit as soon as possible and a '?'(0x3f) codepoint is returned
        // Total number of bytes processed are returned as a parameter
        // NOTE: the standard says U+FFFD should be returned in case of errors
        // but that character is not supported by the default font in raylib
        public static int GetCodepointNext(ReadonlyString text , ref int codepointSize)
        {
            codepointSize = 1;
            return text [ 0 ];
            //string ptr = text;
            //int codepoint = 0x3f;       // Codepoint (defaults to '?')
            //codepointSize = 1;

            //// Get current codepoint and bytes processed
            //if (0xf0 == (0xf8 & ptr [ 0 ]))
            //{
            //    // 4 byte UTF-8 codepoint
            //    if ((((ptr [ 1 ] & 0xC0) ^ 0x80) != 0) || (((ptr [ 2 ] & 0xC0) ^ 0x80) != 0) || ((ptr [ 3 ] & 0xC0) ^ 0x80) != 0)
            //    {
            //        return codepoint;
            //    } //10xxxxxx checks
            //    codepoint = ((0x07 & ptr [ 0 ]) << 18) | ((0x3f & ptr [ 1 ]) << 12) | ((0x3f & ptr [ 2 ]) << 6) | (0x3f & ptr [ 3 ]);
            //    codepointSize = 4;
            //}
            //else if (0xe0 == (0xf0 & ptr [ 0 ]))
            //{
            //    // 3 byte UTF-8 codepoint */
            //    if (((ptr [ 1 ] & 0xC0) ^ 0x80) != 0 || ((ptr [ 2 ] & 0xC0) ^ 0x80) != 0) { return codepoint; } //10xxxxxx checks
            //    codepoint = ((0x0f & ptr [ 0 ]) << 12) | ((0x3f & ptr [ 1 ]) << 6) | (0x3f & ptr [ 2 ]);
            //    codepointSize = 3;
            //}
            //else if (0xc0 == (0xe0 & ptr [ 0 ]))
            //{
            //    // 2 byte UTF-8 codepoint
            //    if (((ptr [ 1 ] & 0xC0) ^ 0x80) != 0) { return codepoint; } //10xxxxxx checks
            //    codepoint = ((0x1f & ptr [ 0 ]) << 6) | (0x3f & ptr [ 1 ]);
            //    codepointSize = 2;
            //}
            //else if (0x00 == (0x80 & ptr [ 0 ]))
            //{
            //    // 1 byte UTF-8 codepoint
            //    codepoint = ptr [ 0 ];
            //    codepointSize = 1;
            //}


            //return codepoint;
        }
        // Gui get text width considering icon
        public static int GetTextWidth(string text)
        {
            Vector2 textSize = default;
            int textIconOffset = 0;

            if ((text != null) && (text.Length > 0))
            {
                if (text [ 0 ] == '#')
                {
                    for (int i = 1 ; (i < 5) && (i < text.Length) ; i++)
                    {
                        if (text [ i ] == '#')
                        {
                            textIconOffset = i;
                            break;
                        }
                    }
                }

                text += textIconOffset;

                // Make sure guiFont is set, GuiGetStyle() initializes it lazynessly
                float fontSize = GuiGetStyle(DEFAULT , TEXT_SIZE);

                // Custom MeasureText() implementation
                if ((guiFont.texture.id > 0) && (text != null))
                {
                    // Get size in bytes of text, considering end of line and line break
                    int size = text.Length;

                    float scaleFactor = fontSize / guiFont.baseSize;
                    textSize.Y = guiFont.baseSize * scaleFactor;
                    float glyphWidth = 0.0f;

                    for (int i = 0, codepointSize = 1 ; i < size ; i += codepointSize)
                    {
                        int codepoint = text [ i ];
                        int codepointIndex = Raylib.GetGlyphIndex(guiFont , codepoint);
                        unsafe
                        {
                            if (guiFont.glyphs [ codepointIndex ].advanceX == 0)
                                glyphWidth = (guiFont.recs [ codepointIndex ].width * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));
                            else glyphWidth = (guiFont.glyphs [ codepointIndex ].advanceX * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));

                        }

                        textSize.X += glyphWidth;
                    }
                }

                if (textIconOffset > 0) textSize.X += (RAYGUI_ICON_SIZE - ICON_TEXT_PADDING);
            }

            return (int)textSize.X;
        }
        static int GetTextWidth(ReadonlyString text)
        {
            Vector2 textSize = default;
            int textIconOffset = 0;

            if ((text.Ref != null) && (text.Length > 0))
            {
                if (text [ 0 ] == '#')
                {
                    for (int i = 1 ; (i < 5) && (i < text.Length) ; i++)
                    {
                        if (text [ i ] == '#')
                        {
                            textIconOffset = i;
                            break;
                        }
                    }
                }

                text.Start += textIconOffset;

                // Make sure guiFont is set, GuiGetStyle() initializes it lazynessly
                float fontSize = GuiGetStyle(DEFAULT , TEXT_SIZE);

                // Custom MeasureText() implementation
                if ((guiFont.texture.id > 0) && (text.Ref != null))
                {
                    // Get size in bytes of text, considering end of line and line break
                    int size = text.Length;

                    float scaleFactor = fontSize / guiFont.baseSize;
                    textSize.Y = guiFont.baseSize * scaleFactor;
                    float glyphWidth = 0.0f;

                    for (int i = 0, codepointSize = 1 ; i < size ; i += codepointSize)
                    {
                        int codepoint = text [ i ];
                        int codepointIndex = Raylib.GetGlyphIndex(guiFont , codepoint);
                        unsafe
                        {
                            if (guiFont.glyphs [ codepointIndex ].advanceX == 0)
                                glyphWidth = (guiFont.recs [ codepointIndex ].width * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));
                            else glyphWidth = (guiFont.glyphs [ codepointIndex ].advanceX * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));

                        }

                        textSize.X += glyphWidth;
                    }
                }

                if (textIconOffset > 0) textSize.X += (RAYGUI_ICON_SIZE - ICON_TEXT_PADDING);
            }

            return (int)textSize.X;
        }

        static int TextToInteger(char [ ] text)
        {
            int value = 0;
            int sign = 1;
            int s = 0;
            if ((text [ 0 ] == '+') || (text [ 0 ] == '-'))
            {
                if (text [ 0 ] == '-') sign = -1;
                s = 1;
            }

            for (int i = s ; i < text.Length ; ++i)
            {
                if (((text [ i ] >= '0') && (text [ i ] <= '9')))
                    value = value * 10 + (text [ i ] - '0');
                else break;
            }

            return value * sign;
        }
        public static ReadonlyString GetTextIcon(ReadonlyString text , ref int iconId)
        {
            iconId = -1;
            if (text [ 0 ] == '#')     // Maybe we have an icon!
            {
                char [ ] iconValue = new char [ 4 ];  // Maximum length for icon value: 3 digits + '\0'

                int pos = 1;
                while ((pos < 4) && (text [ pos ] >= '0') && (text [ pos ] <= '9'))
                {
                    iconValue [ pos - 1 ] = text [ pos ];
                    pos++;
                }

                if (text [ pos ] == '#')
                {
                    iconId = TextToInteger(iconValue);

                    // Move text pointer after icon
                    // WARNING: If only icon provided, it could point to EOL character: '\0'
                    if (iconId >= 0)
                    {
                        text.Start += (pos + 1);
                        text.Length -= (pos + 1);
                    }
                }
            }

            return text;
        }
        public static uint [ ] guiIconsPtr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool BIT_CHECK(int a , int b) => ((a) & (1u << (b))) != 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool BIT_CHECK(uint a , int b) => ((a) & (1u << (b))) != 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiDrawIcon(int iconId , int posX , int posY , int pixelSize , Color color)
        {

            for (int i = 0, y = 0 ; i < RAYGUI_ICON_SIZE * RAYGUI_ICON_SIZE / 32 ; i++)
            {
                for (int k = 0 ; k < 32 ; k++)
                {
                    if (BIT_CHECK(guiIconsPtr [ iconId * RAYGUI_ICON_DATA_ELEMENTS + i ] , k))
                    {
                        Raylib.DrawRectangle(posX + (k % RAYGUI_ICON_SIZE) * pixelSize , posY + y * pixelSize , pixelSize , pixelSize , color);

                    }

                    if ((k == 15) || (k == 31)) y++;
                }
            }
        }
        // Set icon drawing size
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiSetIconScale(int scale)
        {
            if (scale >= 1) guiIconScale = (uint)scale;
        }
        // Text Box control
        // NOTE: Returns true on ENTER pressed (useful for data validation)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GuiTextBox(Rectangle bounds , ref string text , int bufferSize , bool editMode)
        {

            GuiState state = guiState;
            bool pressed = false;

            Rectangle textBounds = GetTextBounds(TEXTBOX , bounds);
            int textWidth = GetTextWidth(text) - GetTextWidth(text + textBoxCursorIndex);
            int textIndexOffset = 0;        // Text index offset to start drawing in the box

            uint alignmentVertical = GuiGetStyle(TEXTBOX , TEXT_ALIGNMENT_VERTICAL);
            uint multiline = GuiGetStyle(TEXTBOX , TEXT_MULTILINE);

            // Cursor rectangle
            // NOTE: Position X value should be updated
            Rectangle cursor = new(textBounds.x + textWidth + GuiGetStyle(DEFAULT , TEXT_SPACING) ,
                                   textBounds.y + textBounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) ,
                                   2 ,
                                   (float)GuiGetStyle(DEFAULT , TEXT_SIZE) * 2);

            switch (alignmentVertical)
            {
                case 0: cursor.y = textBounds.y + textBounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE); break;  // CENTERED
                case 1: cursor.y = textBounds.y - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2; break;  // UP
                case 2: cursor.y = textBounds.y + textBounds.height; break;  // DOWN
                default: break;
            }

            if (cursor.height >= bounds.height) cursor.height = bounds.height - GuiGetStyle(TEXTBOX , BORDER_WIDTH) * 2;
            if (cursor.y < (bounds.y + GuiGetStyle(TEXTBOX , BORDER_WIDTH))) cursor.y = bounds.y + GuiGetStyle(TEXTBOX , BORDER_WIDTH);

            // Auto-cursor movement logic
            // NOTE: Cursor moves automatically when key down after some time
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)
                || Raylib.IsKeyDown(KeyboardKey.KEY_UP) || Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)
                || Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE) || Raylib.IsKeyDown(KeyboardKey.KEY_DELETE))
                autoCursorCooldownCounter++;
            else
            {
                autoCursorCooldownCounter = 0;      // GLOBAL: Cursor cooldown counter
                autoCursorDelayCounter = 0;         // GLOBAL: Cursor delay counter
            }

            // Blink-cursor frame counter
            //if (!autoCursorMode) blinkCursorFrameCounter++;
            //else blinkCursorFrameCounter = 0;

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (editMode)
                {
                    state = GuiState.STATE_PRESSED;

                    // If text does not fit in the textbox and current cursor position is out of bounds,
                    // we add an index offset to text for drawing only what requires depending on cursor
                    while (textWidth >= textBounds.width)
                    {
                        //int nextCodepointSize = 0;

                        textIndexOffset += 1;
                        var STR = (ReadonlyString)(text);
                        STR.Start += textIndexOffset;
                        STR.Length -= textIndexOffset;
                        var STR2 = (ReadonlyString)(text);
                        STR2.Start += (int)textBoxCursorIndex;
                        STR2.Length -= (int)textBoxCursorIndex;
                        textWidth = GetTextWidth(STR) - GetTextWidth(STR2);
                    }

                    int textLength = text.Length;     // Get current text length
                    int input_char = Raylib.GetCharPressed();       // Get Unicode codepoint
                    if (multiline != 0 && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)) input_char = '\n';

                    if (textBoxCursorIndex > textLength) textBoxCursorIndex = (uint)textLength;

                    // Encode codepoint as UTF-8
                    int codepointSize = 1;
                    //const char* charEncoded = CodepointToUTF8(input_char , &codepointSize);

                    // Add codepoint to text, at current cursor position
                    // NOTE: Make sure we do not overflow buffer size
                    if (((multiline != 0 && (input_char == '\n')) || (input_char >= 32)) && ((textLength + codepointSize) < bufferSize))
                    {
                        // Move forward data from cursor position
                        //for (int i = (textLength + codepointSize) ; i > textBoxCursorIndex ; i--) text [ i ] = text [ i - codepointSize ];
                        //text=text.Remove(textLength + codepointSize,1);
                        text = text.Insert((int)textBoxCursorIndex , ((char)input_char).ToString());
                        // Add new codepoint in current cursor position
                        //for (int i = 0 ; i < codepointSize ; i++) text [ textBoxCursorIndex + i ] = charEncoded [ i ];

                        textBoxCursorIndex += (uint)codepointSize;
                        textLength += codepointSize;

                    }

                    // Move cursor to start
                    if ((textLength > 0) && Raylib.IsKeyPressed(KeyboardKey.KEY_HOME))
                    {
                        textBoxCursorIndex = 0;
                    }

                    // Move cursor to end
                    if ((textLength > textBoxCursorIndex) && Raylib.IsKeyPressed(KeyboardKey.KEY_END))
                    {
                        textBoxCursorIndex = (uint)textLength;
                    }

                    // Delete codepoint from text, after current cursor position
                    if ((textLength > textBoxCursorIndex) && (Raylib.IsKeyPressed(KeyboardKey.KEY_DELETE)
                        || (Raylib.IsKeyDown(KeyboardKey.KEY_DELETE) && (autoCursorCooldownCounter >= AUTO_CURSOR_COOLDOWN))))
                    {
                        autoCursorDelayCounter++;

                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_DELETE) || (autoCursorDelayCounter % AUTO_CURSOR_DELAY) == 0)      // Delay every movement some frames
                        {
                            //int nextCodepointSize = 0;
                            //GetCodepointNext(text + textBoxCursorIndex , &nextCodepointSize);
                            text = text.Remove((int)textBoxCursorIndex , 1);
                            // Move backward text from cursor position
                            //for (int i = textBoxCursorIndex ; i < textLength ; i++) text [ i ] = text [ i + nextCodepointSize ];

                            textLength -= codepointSize;

                            // Make sure text last character is EOL
                            //text [ textLength ] = '\0';
                        }
                    }

                    // Delete codepoint from text, before current cursor position
                    if ((textLength > 0) && (Raylib.IsKeyPressed(KeyboardKey.KEY_BACKSPACE)
                        || (Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE) && (autoCursorCooldownCounter >= AUTO_CURSOR_COOLDOWN))))
                    {
                        autoCursorDelayCounter++;

                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_BACKSPACE) || (autoCursorDelayCounter % AUTO_CURSOR_DELAY) == 0)      // Delay every movement some frames
                        {
                            //int prevCodepointSize = 0;
                            //GetCodepointPrevious(text + textBoxCursorIndex , &prevCodepointSize);

                            //// Move backward text from cursor position
                            //for (int i = (textBoxCursorIndex - prevCodepointSize) ; i < textLength ; i++) text [ i ] = text [ i + prevCodepointSize ];
                            if (textBoxCursorIndex > 0)
                                text = text.Remove((int)textBoxCursorIndex - 1 , 1);
                            // Prevent cursor index from decrementing past 0
                            if (textBoxCursorIndex > 0)
                            {
                                textBoxCursorIndex -= (uint)codepointSize;
                                textLength -= codepointSize;
                            }

                            // Make sure text last character is EOL
                            //text [ textLength ] = '\0';
                        }
                    }

                    // Move cursor position with keys
                    //if (IsKeyDown(KEY_LEFT) && autoCursorMode)
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && (autoCursorCooldownCounter > AUTO_CURSOR_COOLDOWN)))
                    {
                        autoCursorDelayCounter++;

                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || (autoCursorDelayCounter % AUTO_CURSOR_DELAY) == 0)      // Delay every movement some frames
                        {
                            if (textBoxCursorIndex > 0)
                                textBoxCursorIndex -= 1;
                            //int prevCodepointSize = 0;
                            //GetCodepointPrevious(text + textBoxCursorIndex , &prevCodepointSize);

                            //if (textBoxCursorIndex >= prevCodepointSize) textBoxCursorIndex -= prevCodepointSize;
                        }
                    }
                    else if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT) || (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && (autoCursorCooldownCounter > AUTO_CURSOR_COOLDOWN)))
                    {
                        autoCursorDelayCounter++;

                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT) || (autoCursorDelayCounter % AUTO_CURSOR_DELAY) == 0)      // Delay every movement some frames
                        {
                            textBoxCursorIndex += 1;
                            if (textBoxCursorIndex >= textLength) textBoxCursorIndex = (uint)textLength;
                            //int nextCodepointSize = 0;
                            //GetCodepointNext(text + textBoxCursorIndex , &nextCodepointSize);

                            //if ((textBoxCursorIndex + nextCodepointSize) <= textLength) textBoxCursorIndex += nextCodepointSize;
                        }
                    }

                    // TODO: Get cursor rectangle from mouse position
                    //cursor = GetCursorFromMousePosition(bounds, text, mouse); // Gui style considered internally, including wrapMode

                    // TODO: Get cursor rectangle from buffer index
                    //cursor = GetCursorFromIndex(bounds, text, index);         // Gui style considered internally, including wrapMode

                    // Recalculate cursor position.y depending on textBoxCursorIndex
                    ReadonlyString _text0 = text;
                    _text0.Start += textIndexOffset;
                    _text0.Length -= textIndexOffset;
                    ReadonlyString _text1 = text;
                    _text1.Start += (int)textBoxCursorIndex;
                    _text1.Length -= (int)textBoxCursorIndex;
                    cursor.x = bounds.x + GuiGetStyle(TEXTBOX , TEXT_PADDING) +
                        GetTextWidth(_text0) - GetTextWidth(_text1) + GuiGetStyle(DEFAULT , TEXT_SPACING);
                    //if (multiline) cursor.y = GetTextLines()

                    // Finish text editing on ENTER (if not multiline mode) or mouse click outside bounds
                    if ((multiline == 0 && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)) ||
                        (!CheckCollisionPointRec(mousePoint , bounds) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON)))
                    {
                        pressed = true;             // Exiting edit mode
                        textBoxCursorIndex = 0;     // GLOBAL: Reset the shared cursor index
                    }
                }
                else
                {
                    if (CheckCollisionPointRec(mousePoint , bounds))
                    {
                        state = GuiState.STATE_FOCUSED;

                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            pressed = true;         // Entering edit mode
                            textBoxCursorIndex = (uint)text.Length;   // GLOBAL: Place cursor index to the end of current text
                        }
                    }
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (state == GuiState.STATE_PRESSED)
            {
                GuiDrawRectangle(bounds , (int)GuiGetStyle(TEXTBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(TEXTBOX , BORDER + ((int)state * 3))) , guiAlpha) , Fade(GetColor(GuiGetStyle(TEXTBOX , BASE_COLOR_PRESSED)) , guiAlpha));
            }
            else if (state == GuiState.STATE_DISABLED)
            {
                GuiDrawRectangle(bounds , (int)GuiGetStyle(TEXTBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(TEXTBOX , BORDER + ((int)state * 3))) , guiAlpha) , Fade(GetColor(GuiGetStyle(TEXTBOX , BASE_COLOR_DISABLED)) , guiAlpha));
            }
            else GuiDrawRectangle(bounds , (int)GuiGetStyle(TEXTBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(TEXTBOX , BORDER + ((int)state * 3))) , guiAlpha) , Color.BLANK);

            // Draw text considering index offset if required
            // NOTE: Text index offset depends on cursor position
            //textIndexOffset
            var t = (ReadonlyString)text;
            t.Start = textIndexOffset;
            t.Length -= textIndexOffset;
            GuiDrawText(t , textBounds , (int)GuiGetStyle(TEXTBOX , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(TEXTBOX , TEXT + ((int)state * 3))) , guiAlpha));

            // Draw cursor
            if (editMode)
            {
                //if (autoCursorMode || ((blinkCursorFrameCounter/40)%2 == 0))
                GuiDrawRectangle(cursor , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(TEXTBOX , BORDER_COLOR_PRESSED)) , guiAlpha));
            }
            else if (state == GuiState.STATE_FOCUSED) GuiTooltip(bounds);
            //--------------------------------------------------------------------

            return pressed;
        }

        // Line control
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiLine(Rectangle bounds , ReadonlyString text)
        {
            int result = 0;
            GuiState state = guiState;

            Color color = Fade(GetColor(GuiGetStyle(DEFAULT , (state == GuiState.STATE_DISABLED) ? BORDER_COLOR_DISABLED : LINE_COLOR)) , guiAlpha);

            // Draw control
            //--------------------------------------------------------------------
            if (text.IsNull()) GuiDrawRectangle(new Rectangle(bounds.x , bounds.y + bounds.height / 2 , bounds.width , 1) , 0 , Color.BLANK , color);
            else
            {
                Rectangle textBounds = default;
                textBounds.width = (float)GetTextWidth(text) + 2;
                textBounds.height = bounds.height;
                textBounds.x = bounds.x + RAYGUI_LINE_MARGIN_TEXT;
                textBounds.y = bounds.y;

                // Draw line with embedded text label: "--- text --------------"
                GuiDrawRectangle(new Rectangle(bounds.x , bounds.y + bounds.height / 2 , RAYGUI_LINE_MARGIN_TEXT - RAYGUI_LINE_TEXT_PADDING , 1) , 0 , Color.BLANK , color);
                GuiDrawText(text , textBounds , TEXT_ALIGN_LEFT , color);
                GuiDrawRectangle(new Rectangle(bounds.x + 12 + textBounds.width + 4 , bounds.y + bounds.height / 2 , bounds.width - textBounds.width - RAYGUI_LINE_MARGIN_TEXT - RAYGUI_LINE_TEXT_PADDING , 1) , 0 , Color.BLANK , color);
            }
            //--------------------------------------------------------------------
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiGroupBox(Rectangle bounds , ReadonlyString text)
        {
            GuiState state = guiState;

            int result = 0;
            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(new Rectangle(bounds.x , bounds.y , RAYGUI_GROUPBOX_LINE_THICK , bounds.height) , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(DEFAULT , (state == GuiState.STATE_DISABLED) ? BORDER_COLOR_DISABLED : LINE_COLOR)) , guiAlpha));
            GuiDrawRectangle(new Rectangle(bounds.x , bounds.y + bounds.height - 1 , bounds.width , RAYGUI_GROUPBOX_LINE_THICK) , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(DEFAULT , (state == GuiState.STATE_DISABLED) ? BORDER_COLOR_DISABLED : LINE_COLOR)) , guiAlpha));
            GuiDrawRectangle(new Rectangle(bounds.x + bounds.width - 1 , bounds.y , RAYGUI_GROUPBOX_LINE_THICK , bounds.height) , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(DEFAULT , (state == GuiState.STATE_DISABLED) ? BORDER_COLOR_DISABLED : LINE_COLOR)) , guiAlpha));

            GuiLine(new Rectangle(bounds.x , bounds.y - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2 , bounds.width , (float)GuiGetStyle(DEFAULT , TEXT_SIZE)) , text);
            //--------------------------------------------------------------------
            return result;
        }
        // Slider control with pro parameters
        // NOTE: Other GuiSlider*() controls use this one
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GuiSliderPro(Rectangle bounds , ReadonlyString textLeft , ReadonlyString textRight , float value , float minValue , float maxValue , int sliderWidth)
        {
            GuiState state = guiState;

            int sliderValue = (int)(((value - minValue) / (maxValue - minValue)) * (bounds.width - 2 * GuiGetStyle(SLIDER , BORDER_WIDTH)));

            Rectangle slider = new Rectangle(bounds.x , bounds.y + GuiGetStyle(SLIDER , BORDER_WIDTH) + GuiGetStyle(SLIDER , SLIDER_PADDING) ,
                                 0 , bounds.height - 2 * GuiGetStyle(SLIDER , BORDER_WIDTH) - 2 * GuiGetStyle(SLIDER , SLIDER_PADDING));

            if (sliderWidth > 0)        // Slider
            {
                slider.x += (sliderValue - sliderWidth / 2);
                slider.width = sliderWidth;
            }
            else if (sliderWidth == 0)  // SliderBar
            {
                slider.x += GuiGetStyle(SLIDER , BORDER_WIDTH);
                slider.width = sliderValue;
            }

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (guiSliderDragging) // Keep dragging outside of bounds
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        if (CHECK_BOUNDS_ID(bounds , guiSliderActive))
                        {
                            // Get equivalent value and slider position from mousePoint.x
                            value = ((maxValue - minValue) * (mousePoint.X - (float)(bounds.x + sliderWidth / 2))) / (float)(bounds.width - sliderWidth) + minValue;
                        }
                    }
                    else
                    {
                        guiSliderDragging = false;
                        guiSliderActive = new Rectangle(0 , 0 , 0 , 0);
                    }
                }
                else if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = GuiState.STATE_PRESSED;
                        guiSliderDragging = true;
                        guiSliderActive = bounds; // Store bounds as an identifier when dragging starts

                        // Get equivalent value and slider position from mousePoint.x
                        value = ((maxValue - minValue) * (mousePoint.X - (float)(bounds.x + sliderWidth / 2))) / (float)(bounds.width - sliderWidth) + minValue;

                        if (sliderWidth > 0) slider.x = mousePoint.X - slider.width / 2;  // Slider
                        else if (sliderWidth == 0) slider.width = sliderValue;          // SliderBar
                    }
                    else state = GuiState.STATE_FOCUSED;
                }

                if (value > maxValue) value = maxValue;
                else if (value < minValue) value = minValue;
            }

            // Bar limits check
            if (sliderWidth > 0)        // Slider
            {
                if (slider.x <= (bounds.x + GuiGetStyle(SLIDER , BORDER_WIDTH))) slider.x = bounds.x + GuiGetStyle(SLIDER , BORDER_WIDTH);
                else if ((slider.x + slider.width) >= (bounds.x + bounds.width)) slider.x = bounds.x + bounds.width - slider.width - GuiGetStyle(SLIDER , BORDER_WIDTH);
            }
            else if (sliderWidth == 0)  // SliderBar
            {
                if (slider.width > bounds.width) slider.width = bounds.width - 2 * GuiGetStyle(SLIDER , BORDER_WIDTH);
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds ,
                             (int)GuiGetStyle(SLIDER , BORDER_WIDTH) ,
                             Fade(GetColor(GuiGetStyle(SLIDER , BORDER + ((int)state * 3))) , guiAlpha) ,
                             Fade(GetColor(GuiGetStyle(SLIDER , (state != GuiState.STATE_DISABLED) ? BASE_COLOR_NORMAL : BASE_COLOR_DISABLED)) , guiAlpha));

            // Draw slider internal bar (depends on state)
            if ((state == STATE_NORMAL) || (state == GuiState.STATE_PRESSED)) GuiDrawRectangle(slider , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(SLIDER , BASE_COLOR_PRESSED)) , guiAlpha));
            else if (state == GuiState.STATE_FOCUSED) GuiDrawRectangle(slider , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(SLIDER , TEXT_COLOR_FOCUSED)) , guiAlpha));

            // Draw left/right text if provided
            if (textLeft.Ref != null)
            {
                Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);
                textBounds.width = GetTextWidth(textLeft);
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x - textBounds.width - GuiGetStyle(SLIDER , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;

                GuiDrawText(textLeft , textBounds , TEXT_ALIGN_RIGHT , Fade(GetColor(GuiGetStyle(SLIDER , TEXT + ((int)state * 3))) , guiAlpha));
            }

            if (textRight.Ref != null)
            {
                Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);
                textBounds.width = GetTextWidth(textRight);
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x + bounds.width + GuiGetStyle(SLIDER , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;

                GuiDrawText(textRight , textBounds , TEXT_ALIGN_LEFT , Fade(GetColor(GuiGetStyle(SLIDER , TEXT + ((int)state * 3))) , guiAlpha));
            }
            //--------------------------------------------------------------------

            return value;
        }

        // Slider control extended, returns selected value and has text
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GuiSlider(Rectangle bounds , ReadonlyString textLeft , ReadonlyString textRight , float value , float minValue , float maxValue)
        {
            return GuiSliderPro(bounds , textLeft , textRight , value , minValue , maxValue , (int)GuiGetStyle(SLIDER , SLIDER_WIDTH));
        }

        // Slider Bar control extended, returns selected value
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GuiSliderBar(Rectangle bounds , ReadonlyString textLeft , ReadonlyString textRight , float value , float minValue , float maxValue)
        {
            return GuiSliderPro(bounds , textLeft , textRight , value , minValue , maxValue , 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiDrawText(ReadonlyString? text , Rectangle bounds , int alignment , Color tint)
        {

            uint alignmentVertical = GuiGetStyle(TEXTBOX , TEXT_ALIGNMENT_VERTICAL);
            if (text.HasValue)
            {
                var _text = text.Value;
                // We process the text lines one by one
                if ((_text.Length > 0))
                {
                    // Get text lines ('\n' delimiter) to process lines individually
                    // NOTE: We can't use GuiTextSplit() because it can be already used before calling
                    // GuiDrawText() and static buffer would be overriden :(
                    int lineCount = 0;
                    //const char** lines = GetTextLines(text , &lineCount);
                    //string [ ] lines = text.Split('\n');
                    ReadOnlySpan<char> chars = _text;
                    var lines = chars.SplitSingleChar('\n');
                    lineCount = lines.Item1;
                    //Rectangle textBounds = GetTextBounds(LABEL, bounds);
                    float totalHeight = lineCount * GuiGetStyle(DEFAULT , TEXT_SIZE) + (lineCount - 1) * GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;
                    float posOffsetY = 0;

                    for (int i = 0 ; i < lineCount ; i++)
                    {
                        int iconId = 0;
                        ReadonlyString Line = new ReadonlyString
                        {
                            Ref = _text.Ref ,
                            Start = _text.Start + lines.Item2 [ i ].Item1 ,
                            Length = lines.Item2 [ i ].Item2
                        };
                        Line = GetTextIcon(Line , ref iconId);      // Check text for icon and move cursor

                        // Get text position depending on alignment and iconId
                        //---------------------------------------------------------------------------------
                        Vector2 position = new Vector2(bounds.x , bounds.y);

                        // NOTE: We get text size after icon has been processed
                        // WARNING: GetTextWidth() also processes text icon to get width! -> Really needed?
                        int textSizeX = GetTextWidth(Line);

                        // If text requires an icon, add size to measure
                        if (iconId >= 0)
                        {
                            textSizeX += RAYGUI_ICON_SIZE * (int)guiIconScale;

                            // WARNING: If only icon provided, text could be pointing to EOF character: '\0'
                            if ((Line.Ref != null) && (Line.Length > 0)) textSizeX += ICON_TEXT_PADDING;
                        }

                        // Check guiTextAlign global variables
                        switch (alignment)
                        {
                            case TEXT_ALIGN_LEFT: position.X = bounds.x; break;
                            case TEXT_ALIGN_CENTER: position.X = bounds.x + bounds.width / 2 - textSizeX / 2; break;
                            case TEXT_ALIGN_RIGHT: position.X = bounds.x + bounds.width - textSizeX; break;
                            default: break;
                        }

                        switch (alignmentVertical)
                        {
                            case 0: position.Y = bounds.y + posOffsetY + bounds.height / 2 - totalHeight / 2 + TEXT_VALIGN_PIXEL_OFFSET(bounds.height); break;  // CENTERED
                            case 1: position.Y = bounds.y + posOffsetY; break;  // UP
                            case 2: position.Y = bounds.y + posOffsetY + bounds.height - totalHeight + TEXT_VALIGN_PIXEL_OFFSET(bounds.height); break;  // DOWN
                            default: break;
                        }

                        // NOTE: Make sure we get pixel-perfect coordinates,
                        // In case of decimals we got weird text positioning
                        position.X = (int)position.X;
                        position.Y = (int)position.Y;
                        //---------------------------------------------------------------------------------

                        // Draw text (with icon if available)
                        //---------------------------------------------------------------------------------
                        //#if !defined(RAYGUI_NO_ICONS)
                        if (iconId >= 0)
                        {
                            // NOTE: We consider icon height, probably different than text size
                            GuiDrawIcon(iconId , (int)position.X , (int)(bounds.y + bounds.height / 2 - RAYGUI_ICON_SIZE * guiIconScale / 2 + TEXT_VALIGN_PIXEL_OFFSET(bounds.height)) , (int)guiIconScale , tint);
                            position.X += (RAYGUI_ICON_SIZE * guiIconScale + ICON_TEXT_PADDING);
                        }
                        //#endif
                        //DrawTextEx(guiFont, text, position, (float)GuiGetStyle(DEFAULT, TEXT_SIZE), (float)GuiGetStyle(DEFAULT, TEXT_SPACING), tint);

                        // Get size in bytes of text,
                        // considering end of line and line break
                        int size = Line.Length;
                        //for (int c = 0 ; (c<lines.Length) && (lines [ i ] [ c ] != '\n') ; c++, size++) { }
                        float scaleFactor = (float)GuiGetStyle(DEFAULT , TEXT_SIZE) / guiFont.baseSize;

                        int textOffsetY = 0;
                        float textOffsetX = 0.0f;
                        for (int c = 0 ; c < size ; c++)
                        {
                            int codepoint = Line [ c ];
                            int index = Raylib.GetGlyphIndex(guiFont , codepoint);

                            // NOTE: Normally we exit the decoding sequence as soon as a bad byte is found (and return 0x3f)
                            // but we need to draw all of the bad bytes using the '?' symbol moving one byte
                            //if (codepoint == 0x3f) codepointSize = 1;

                            if (codepoint == '\n') break;   // WARNING: Lines are already processed manually, no need to keep drawing after this codepoint
                            else
                            {
                                if ((codepoint != ' ') && (codepoint != '\t'))
                                {
                                    unsafe
                                    {
                                        // Draw only required text glyphs fitting the bounds.width
                                        if (textOffsetX < (bounds.width - guiFont.recs [ index ].width))
                                        {
                                            Raylib.DrawTextCodepoint(guiFont , codepoint , new Vector2(position.X + textOffsetX , position.Y + textOffsetY) , GuiGetStyle(DEFAULT , TEXT_SIZE) , tint);
                                        }

                                    }
                                }
                                unsafe
                                {
                                    if (guiFont.glyphs [ index ].advanceX == 0)
                                        textOffsetX += (guiFont.recs [ index ].width * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));
                                    else textOffsetX += (guiFont.glyphs [ index ].advanceX * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));

                                }
                            }
                        }

                        // TODO: Allow users to set line spacing for text: GuiSetStyle(TEXTBOX, TEXT_LINES_SPACING, x)
                        posOffsetY += GuiGetStyle(DEFAULT , TEXT_SIZE) * 1.5f;
                        //---------------------------------------------------------------------------------
                    }
                }
            }
        }
        public static void GuiDrawText(int iconId , ReadonlyString text , Rectangle bounds , int alignment , Color tint)
        {

            uint alignmentVertical = GuiGetStyle(TEXTBOX , TEXT_ALIGNMENT_VERTICAL);
            if (text.IsNotNull())
            {
                var _text = text;
                // We process the text lines one by one
                if ((_text.Length > 0) || iconId >= 0)
                {
                    // Get text lines ('\n' delimiter) to process lines individually
                    // NOTE: We can't use GuiTextSplit() because it can be already used before calling
                    // GuiDrawText() and static buffer would be overriden :(
                    int lineCount = 0;
                    //const char** lines = GetTextLines(text , &lineCount);
                    //string [ ] lines = text.Split('\n');
                    ReadOnlySpan<char> chars = _text;
                    var lines = chars.SplitSingleChar('\n');
                    lineCount = lines.Item1;
                    //Rectangle textBounds = GetTextBounds(LABEL, bounds);
                    float totalHeight = lineCount * GuiGetStyle(DEFAULT , TEXT_SIZE) + (lineCount - 1) * GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;
                    float posOffsetY = 0;

                    for (int i = 0 ; i < lineCount ; i++)
                    {
                        //int iconId = 0;
                        ReadonlyString Line = new ReadonlyString
                        {
                            Ref = _text.Ref ,
                            Start = _text.Start + lines.Item2 [ i ].Item1 ,
                            Length = lines.Item2 [ i ].Item2
                        };
                        //Line = GetTextIcon(Line , ref iconId);      // Check text for icon and move cursor

                        // Get text position depending on alignment and iconId
                        //---------------------------------------------------------------------------------
                        Vector2 position = new Vector2(bounds.x , bounds.y);

                        // NOTE: We get text size after icon has been processed
                        // WARNING: GetTextWidth() also processes text icon to get width! -> Really needed?
                        int textSizeX = GetTextWidth(Line);

                        // If text requires an icon, add size to measure
                        if (iconId >= 0)
                        {
                            textSizeX += RAYGUI_ICON_SIZE * (int)guiIconScale;

                            // WARNING: If only icon provided, text could be pointing to EOF character: '\0'
                            if ((Line.Ref != null) && (Line.Length > 0)) textSizeX += ICON_TEXT_PADDING;
                        }

                        // Check guiTextAlign global variables
                        switch (alignment)
                        {
                            case TEXT_ALIGN_LEFT: position.X = bounds.x; break;
                            case TEXT_ALIGN_CENTER: position.X = bounds.x + bounds.width / 2 - textSizeX / 2; break;
                            case TEXT_ALIGN_RIGHT: position.X = bounds.x + bounds.width - textSizeX; break;
                            default: break;
                        }

                        switch (alignmentVertical)
                        {
                            case 0: position.Y = bounds.y + posOffsetY + bounds.height / 2 - totalHeight / 2 + TEXT_VALIGN_PIXEL_OFFSET(bounds.height); break;  // CENTERED
                            case 1: position.Y = bounds.y + posOffsetY; break;  // UP
                            case 2: position.Y = bounds.y + posOffsetY + bounds.height - totalHeight + TEXT_VALIGN_PIXEL_OFFSET(bounds.height); break;  // DOWN
                            default: break;
                        }

                        // NOTE: Make sure we get pixel-perfect coordinates,
                        // In case of decimals we got weird text positioning
                        position.X = (int)position.X;
                        position.Y = (int)position.Y;
                        //---------------------------------------------------------------------------------

                        // Draw text (with icon if available)
                        //---------------------------------------------------------------------------------
                        //#if !defined(RAYGUI_NO_ICONS)
                        if (iconId >= 0)
                        {
                            // NOTE: We consider icon height, probably different than text size
                            GuiDrawIcon(iconId , (int)position.X , (int)(bounds.y + bounds.height / 2 - RAYGUI_ICON_SIZE * guiIconScale / 2 + TEXT_VALIGN_PIXEL_OFFSET(bounds.height)) , (int)guiIconScale , tint);
                            position.X += (RAYGUI_ICON_SIZE * guiIconScale + ICON_TEXT_PADDING);
                        }
                        //#endif
                        //DrawTextEx(guiFont, text, position, (float)GuiGetStyle(DEFAULT, TEXT_SIZE), (float)GuiGetStyle(DEFAULT, TEXT_SPACING), tint);

                        // Get size in bytes of text,
                        // considering end of line and line break
                        int size = Line.Length;
                        //for (int c = 0 ; (c<lines.Length) && (lines [ i ] [ c ] != '\n') ; c++, size++) { }
                        float scaleFactor = (float)GuiGetStyle(DEFAULT , TEXT_SIZE) / guiFont.baseSize;

                        int textOffsetY = 0;
                        float textOffsetX = 0.0f;
                        for (int c = 0 ; c < size ; c++)
                        {
                            int codepoint = Line [ c ];
                            int index = Raylib.GetGlyphIndex(guiFont , codepoint);

                            // NOTE: Normally we exit the decoding sequence as soon as a bad byte is found (and return 0x3f)
                            // but we need to draw all of the bad bytes using the '?' symbol moving one byte
                            //if (codepoint == 0x3f) codepointSize = 1;

                            if (codepoint == '\n') break;   // WARNING: Lines are already processed manually, no need to keep drawing after this codepoint
                            else
                            {
                                if ((codepoint != ' ') && (codepoint != '\t'))
                                {
                                    unsafe
                                    {
                                        // Draw only required text glyphs fitting the bounds.width
                                        if (textOffsetX < (bounds.width - guiFont.recs [ index ].width))
                                        {
                                            Raylib.DrawTextCodepoint(guiFont , codepoint , new Vector2(position.X + textOffsetX , position.Y + textOffsetY) , GuiGetStyle(DEFAULT , TEXT_SIZE) , tint);
                                        }

                                    }
                                }
                                unsafe
                                {
                                    if (guiFont.glyphs [ index ].advanceX == 0)
                                        textOffsetX += (guiFont.recs [ index ].width * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));
                                    else textOffsetX += (guiFont.glyphs [ index ].advanceX * scaleFactor + GuiGetStyle(DEFAULT , TEXT_SPACING));

                                }
                            }
                        }

                        // TODO: Allow users to set line spacing for text: GuiSetStyle(TEXTBOX, TEXT_LINES_SPACING, x)
                        posOffsetY += GuiGetStyle(DEFAULT , TEXT_SIZE) * 1.5f;
                        //---------------------------------------------------------------------------------
                    }
                }
            }
        }
        public static int GuiLabel(Rectangle bounds , ReadonlyString text)
        {
            int result = 0;
            GuiState state = guiState;

            // Update control
            //--------------------------------------------------------------------
            //...
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawText(text , GetTextBounds(LABEL , bounds) , (int)GuiGetStyle(LABEL , TEXT_ALIGNMENT) ,
                Fade(GetColor(GuiGetStyle(LABEL , TEXT + ((int)state * 3))) , guiAlpha));
            //--------------------------------------------------------------------
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Split controls text into multiple strings
        // Also check for multiple columns (required by GuiToggleGroup())
        public static ReadonlyString [ ] GuiTextSplit(ReadonlyString text , char delimiter , ref int count , ref int [ ] textRow)
        {
            // NOTE: Current implementation returns a copy of the provided string with '\0' (string end delimiter)
            // inserted between strings defined by "delimiter" parameter. No memory is dynamically allocated,
            // all used memory is static... it has some limitations:
            //      1. Maximum number of possible split strings is set by RAYGUI_TEXTSPLIT_MAX_ITEMS
            //      2. Maximum size of text to split is RAYGUI_TEXTSPLIT_MAX_TEXT_SIZE
            // NOTE: Those definitions could be externally provided if required

            // TODO: HACK: GuiTextSplit() - Review how textRows are returned to user
            // textRow is an externally provided array of integers that stores row number for every splitted string



            ReadonlyString [ ] result = new ReadonlyString [ RAYGUI_TEXTSPLIT_MAX_ITEMS ];   // String pointers array (points to buffer data)
            int Count = 0;
            ReadOnlySpan<char> input = text;
            (int LineCount, (int Start, int Length) [ ] Lines) Result = input.SplitSingleChar('\n');
            for (int LineNumber = 0 ; LineNumber < Result.LineCount ; LineNumber++)
            {
                var LineItem = Result.Lines [ LineNumber ];
                var line = new ReadonlyString { Ref = text.Ref , Start = text.Start + LineItem.Start , Length = LineItem.Length };
                ReadOnlySpan<char> SpanLine = line;
                (int ResultCount, (int Start, int Length) [ ] Items) LineResult = SpanLine.SplitSingleChar(delimiter);
                for (int LI = 0 ; LI < LineResult.ResultCount ; LI++)
                {
                    var Item = LineResult.Items [ LI ];
                    result [ Count ] = new ReadonlyString { Ref = line.Ref , Start = line.Start + Item.Start , Length = Item.Length };
                    textRow [ Count ] = LineNumber;
                    Count++;
                }
            }
            count = Count;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Convert color data from RGB to HSV
        // NOTE: Color data should be passed normalized
        public static Vector3 ConvertRGBtoHSV(Vector3 rgb)
        {
            Vector3 hsv = new Vector3();
            float min = 0.0f;
            float max = 0.0f;
            float delta = 0.0f;

            min = (rgb.X < rgb.Y) ? rgb.X : rgb.Y;
            min = (min < rgb.Z) ? min : rgb.Z;

            max = (rgb.X > rgb.Y) ? rgb.X : rgb.Y;
            max = (max > rgb.Z) ? max : rgb.Z;

            hsv.Z = max;            // Value
            delta = max - min;

            if (delta < 0.00001f)
            {
                hsv.Y = 0.0f;
                hsv.X = 0.0f;           // Undefined, maybe NAN?
                return hsv;
            }

            if (max > 0.0f)
            {
                // NOTE: If max is 0, this divide would cause a crash
                hsv.Y = (delta / max);    // Saturation
            }
            else
            {
                // NOTE: If max is 0, then r = g = b = 0, s = 0, h is undefined
                hsv.Y = 0.0f;
                hsv.X = 0.0f;           // Undefined, maybe NAN?
                return hsv;
            }

            // NOTE: Comparing float values could not work properly
            if (rgb.X >= max) hsv.X = (rgb.Y - rgb.Z) / delta;    // Between yellow & magenta
            else
            {
                if (rgb.Y >= max) hsv.X = 2.0f + (rgb.Z - rgb.X) / delta;  // Between cyan & yellow
                else hsv.X = 4.0f + (rgb.X - rgb.Y) / delta;      // Between magenta & cyan
            }

            hsv.X *= 60.0f;     // Convert to degrees

            if (hsv.X < 0.0f) hsv.X += 360.0f;

            return hsv;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Convert color data from HSV to RGB
        // NOTE: Color data should be passed normalized
        public static Vector3 ConvertHSVtoRGB(Vector3 hsv)
        {
            Vector3 rgb;
            float hh = 0.0f, p = 0.0f, q = 0.0f, t = 0.0f, ff = 0.0f;
            long i = 0;

            // NOTE: Comparing float values could not work properly
            if (hsv.Y <= 0.0f)
            {
                rgb.X = hsv.Z;
                rgb.Y = hsv.Z;
                rgb.Z = hsv.Z;
                return rgb;
            }

            hh = hsv.X;
            if (hh >= 360.0f) hh = 0.0f;
            hh /= 60.0f;

            i = (long)hh;
            ff = hh - i;
            p = hsv.Z * (1.0f - hsv.Y);
            q = hsv.Z * (1.0f - (hsv.Y * ff));
            t = hsv.Z * (1.0f - (hsv.Y * (1.0f - ff)));

            switch (i)
            {
                case 0:
                    {
                        rgb.X = hsv.Z;
                        rgb.Y = t;
                        rgb.Z = p;
                    }
                    break;
                case 1:
                    {
                        rgb.X = q;
                        rgb.Y = hsv.Z;
                        rgb.Z = p;
                    }
                    break;
                case 2:
                    {
                        rgb.X = p;
                        rgb.Y = hsv.Z;
                        rgb.Z = t;
                    }
                    break;
                case 3:
                    {
                        rgb.X = p;
                        rgb.Y = q;
                        rgb.Z = hsv.Z;
                    }
                    break;
                case 4:
                    {
                        rgb.X = t;
                        rgb.Y = p;
                        rgb.Z = hsv.Z;
                    }
                    break;
                case 5:
                default:
                    {
                        rgb.X = hsv.Z;
                        rgb.Y = p;
                        rgb.Z = q;
                    }
                    break;
            }

            return rgb;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Toggle Group control, returns toggled button codepointIndex
        public static int GuiToggleGroup(Rectangle bounds , string text , int active)
        {
            float initBoundsX = bounds.x;

            // Get substrings items from text (items pointers)
            int [ ] rows = new int [ RAYGUI_TOGGLEGROUP_MAX_ITEMS ];
            int itemCount = 0;
            var items = GuiTextSplit(text , ';' , ref itemCount , ref rows);

            int prevRow = rows [ 0 ];
            bool toggle = false;    // Required for individual toggles
            for (int i = 0 ; i < itemCount ; i++)
            {
                if (prevRow != rows [ i ])
                {
                    bounds.x = initBoundsX;
                    bounds.y += (bounds.height + GuiGetStyle(TOGGLE , GROUP_PADDING));
                    prevRow = rows [ i ];
                }
                if (i == active)
                {
                    toggle = true;
                    GuiToggle(bounds , items [ i ] , ref toggle);
                }
                else
                {
                    toggle = false;
                    GuiToggle(bounds , items [ i ] , ref toggle);
                    if (toggle) active = i;
                }
                bounds.x += (bounds.width + GuiGetStyle(TOGGLE , GROUP_PADDING));
            }

            return active;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Button control, returns true when clicked
        public static int GuiButton(Rectangle bounds , ReadonlyString text)
        {
            int result = 0;
            int state = (int)guiState;

            // Update control
            //--------------------------------------------------------------------
            if ((state != STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check button state
                if (Raylib.CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = STATE_PRESSED;
                    else state = STATE_FOCUSED;

                    if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON)) result = 1;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds ,
                             (int)GuiGetStyle(BUTTON , BORDER_WIDTH) ,
                             GetColor(GuiGetStyle(BUTTON , BORDER + (state * 3))) ,
                             GetColor(GuiGetStyle(BUTTON , BASE + (state * 3))));
            GuiDrawText(text ,
                        GetTextBounds(BUTTON , bounds) ,
                        (int)GuiGetStyle(BUTTON , TEXT_ALIGNMENT) ,
                        GetColor(GuiGetStyle(BUTTON , TEXT + (state * 3))));


            if (state == STATE_FOCUSED) GuiTooltip(bounds);
            //------------------------------------------------------------------

            return result;
        }
        // Button control, returns true when clicked
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiButton(Rectangle bounds , int iconId , ReadonlyString text)
        {
            int result = 0;
            int state = (int)guiState;

            // Update control
            //--------------------------------------------------------------------
            if ((state != STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check button state
                if (Raylib.CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = STATE_PRESSED;
                    else state = STATE_FOCUSED;

                    if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON)) result = 1;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds ,
                             (int)GuiGetStyle(BUTTON , BORDER_WIDTH) ,
                             GetColor(GuiGetStyle(BUTTON , BORDER + (state * 3))) ,
                             GetColor(GuiGetStyle(BUTTON , BASE + (state * 3))));
            GuiDrawText(iconId , text ,
                        GetTextBounds(BUTTON , bounds) ,
                        (int)GuiGetStyle(BUTTON , TEXT_ALIGNMENT) ,
                        GetColor(GuiGetStyle(BUTTON , TEXT + (state * 3))));

            if (state == STATE_FOCUSED) GuiTooltip(bounds);
            //------------------------------------------------------------------

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Font GuiGetFont()
        {
            return guiFont;
        }

        // Tab Bar control
        // NOTE: Using GuiToggle() for the TABS
        public static int GuiTabBar(Rectangle bounds , ReadonlyString [ ] text , int count , ref int active)
        {

            GuiState state = guiState;

            int result = -1;
            //int closing = -1;
            Rectangle tabBounds = new(bounds.x , bounds.y , RAYGUI_TABBAR_ITEM_WIDTH , bounds.height);

            if (active < 0) active = 0;
            else if (active > count - 1) active = count - 1;

            int offsetX = 0;    // Required in case tabs go out of screen
            offsetX = (active + 2) * RAYGUI_TABBAR_ITEM_WIDTH - Raylib.GetScreenWidth();
            if (offsetX < 0) offsetX = 0;

            bool toggle = false;    // Required for individual toggles
            // Draw control
            //--------------------------------------------------------------------
            for (int i = 0 ; i < count ; i++)
            {
                tabBounds.x = bounds.x + (RAYGUI_TABBAR_ITEM_WIDTH + 4) * i - offsetX;

                if (tabBounds.x < Raylib.GetScreenWidth())
                {
                    // Draw tabs as toggle controls
                    uint textAlignment = GuiGetStyle(TOGGLE , TEXT_ALIGNMENT);
                    uint textPadding = GuiGetStyle(TOGGLE , TEXT_PADDING);
                    GuiSetStyle(TOGGLE , TEXT_ALIGNMENT , TEXT_ALIGN_LEFT);
                    GuiSetStyle(TOGGLE , TEXT_PADDING , 8);
                    if (i == (active))
                    {
                        toggle = true;
                        GuiToggle(tabBounds , 12 , text [ i ] , ref toggle);
                    }
                    else
                    {
                        toggle = false;
                        GuiToggle(tabBounds , 12 , text [ i ] , ref toggle);
                        if (toggle) active = i;
                    }

                    GuiSetStyle(TOGGLE , TEXT_PADDING , textPadding);
                    GuiSetStyle(TOGGLE , TEXT_ALIGNMENT , textAlignment);

                    // Draw tab close button
                    // NOTE: Only draw close button for current tab: if (CheckCollisionPointRec(mousePosition, tabBounds))
                    uint tempBorderWidth = GuiGetStyle(BUTTON , BORDER_WIDTH);
                    uint tempTextAlignment = GuiGetStyle(BUTTON , TEXT_ALIGNMENT);
                    GuiSetStyle(BUTTON , BORDER_WIDTH , 1);
                    GuiSetStyle(BUTTON , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);
                    if (RAYGUI_NO_ICONS)
                    {

                        if (GuiButton(new Rectangle(tabBounds.x + tabBounds.width - 14 - 5 , tabBounds.y + 5 , 14 , 14) , "x") == 1) result = i;
                    }
                    else
                    {

                        if (GuiButton(new Rectangle(tabBounds.x + tabBounds.width - 14 - 5 , tabBounds.y + 5 , 14 , 14) , (int)GuiIconName.ICON_CROSS_SMALL , "") == 1) result = i;
                    }
                    GuiSetStyle(BUTTON , BORDER_WIDTH , tempBorderWidth);
                    GuiSetStyle(BUTTON , TEXT_ALIGNMENT , tempTextAlignment);
                }
            }

            // Draw tab-bar bottom line
            GuiDrawRectangle(new Rectangle(bounds.x , bounds.y + bounds.height - 1 , bounds.width , 1) , 0 , Color.BLANK , GetColor((int)GuiGetStyle(TOGGLE , BORDER_COLOR_NORMAL)));
            //--------------------------------------------------------------------

            return result;     // Return as result the current TAB closing requested
        }

        // Scroll Panel control
        public static int GuiScrollPanel(Rectangle bounds , ReadonlyString text , Rectangle content , ref Vector2? scroll , ref Rectangle? view)
        {
            int result = 0;
            Rectangle temp = default;
            if (!view.HasValue) view = temp;
            GuiState state = guiState;
            float mouseWheelSpeed = 20.0f;
            Vector2 scrollPos = new(0.0f , 0.0f);
            if (scroll.HasValue) scrollPos = scroll.Value;

            // Text will be drawn as a header bar (if provided)
            Rectangle statusBar = new(bounds.x , bounds.y , bounds.width , (float)RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT);
            if (bounds.height < RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT * 2.0f) bounds.height = RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT * 2.0f;

            if (text.IsNotNull())
            {
                // Move panel bounds after the header bar
                bounds.y += (float)RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT - 1;
                bounds.height -= (float)RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT + 1;
            }

            bool hasHorizontalScrollBar = (content.width > bounds.width - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH)) ? true : false;
            bool hasVerticalScrollBar = (content.height > bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH)) ? true : false;

            // Recheck to account for the other scrollbar being visible
            if (!hasHorizontalScrollBar) hasHorizontalScrollBar = (hasVerticalScrollBar && (content.width > (bounds.width - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH)))) ? true : false;
            if (!hasVerticalScrollBar) hasVerticalScrollBar = (hasHorizontalScrollBar && (content.height > (bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH)))) ? true : false;

            uint horizontalScrollBarWidth = hasHorizontalScrollBar ? GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH) : 0;
            uint verticalScrollBarWidth = hasVerticalScrollBar ? GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH) : 0;
            Rectangle horizontalScrollBar = new((float)((GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)bounds.x + verticalScrollBarWidth : (float)bounds.x)
                                                 + GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)bounds.y + bounds.height - horizontalScrollBarWidth - GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)bounds.width - verticalScrollBarWidth - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)horizontalScrollBarWidth);
            Rectangle verticalScrollBar = new(
                (float)((GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)bounds.x + GuiGetStyle(DEFAULT , BORDER_WIDTH) : (float)bounds.x + bounds.width - verticalScrollBarWidth - GuiGetStyle(DEFAULT , BORDER_WIDTH)) ,
                (float)bounds.y + GuiGetStyle(DEFAULT , BORDER_WIDTH) ,
                (float)verticalScrollBarWidth ,
                (float)bounds.height - horizontalScrollBarWidth - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH)
            );

            // Make sure scroll bars have a minimum width/height
            // NOTE: If content >>> bounds, size could be very small or even 0
            if (horizontalScrollBar.width < RAYGUI_MIN_SCROLLBAR_WIDTH)
            {
                horizontalScrollBar.width = RAYGUI_MIN_SCROLLBAR_WIDTH;
                mouseWheelSpeed = 30.0f;    // TODO: Calculate speed increment based on content.height vs bounds.height
            }
            if (verticalScrollBar.height < RAYGUI_MIN_SCROLLBAR_HEIGHT)
            {
                verticalScrollBar.height = RAYGUI_MIN_SCROLLBAR_HEIGHT;
                mouseWheelSpeed = 30.0f;    // TODO: Calculate speed increment based on content.width vs bounds.width
            }
            //Rectangle horizontalScrollBar = new((float)((GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)bounds.x + verticalScrollBarWidth : (float)bounds.x) + GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)bounds.y + bounds.height - horizontalScrollBarWidth - GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)bounds.width - verticalScrollBarWidth - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)horizontalScrollBarWidth);
            //Rectangle verticalScrollBar = new((float)((GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)bounds.x + GuiGetStyle(DEFAULT , BORDER_WIDTH) : (float)bounds.x + bounds.width - verticalScrollBarWidth - GuiGetStyle(DEFAULT , BORDER_WIDTH)) , (float)bounds.y + GuiGetStyle(DEFAULT , BORDER_WIDTH) , (float)verticalScrollBarWidth , (float)bounds.height - horizontalScrollBarWidth - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH));

            // Calculate view area (area without the scrollbars)
            view = (GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ?
                        new Rectangle(bounds.x + verticalScrollBarWidth + GuiGetStyle(DEFAULT , BORDER_WIDTH) , bounds.y + GuiGetStyle(DEFAULT , BORDER_WIDTH) , bounds.width - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - verticalScrollBarWidth , bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - horizontalScrollBarWidth
        ) :
                        new Rectangle(bounds.x + GuiGetStyle(DEFAULT , BORDER_WIDTH) , bounds.y + GuiGetStyle(DEFAULT , BORDER_WIDTH) , bounds.width - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - verticalScrollBarWidth , bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - horizontalScrollBarWidth);

            // Clip view area to the actual content size
            if (view.Value.width > content.width)
            {
                var v = view.Value;
                v.width = content.width;
                view = v;
            }

            if (view.Value.height > content.height)
            {
                var v = view.Value;
                v.height = content.height;
                view = v;
            }

            float horizontalMin = hasHorizontalScrollBar ? ((GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)-verticalScrollBarWidth : 0) - (float)GuiGetStyle(DEFAULT , BORDER_WIDTH) : (((float)GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)-verticalScrollBarWidth : 0) - (float)GuiGetStyle(DEFAULT , BORDER_WIDTH);
            float horizontalMax = hasHorizontalScrollBar ? content.width - bounds.width + (float)verticalScrollBarWidth + GuiGetStyle(DEFAULT , BORDER_WIDTH) - (((float)GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (float)verticalScrollBarWidth : 0) : (float)-GuiGetStyle(DEFAULT , BORDER_WIDTH);
            float verticalMin = hasVerticalScrollBar ? 0.0f : -1.0f;
            float verticalMax = hasVerticalScrollBar ? content.height - bounds.height + (float)horizontalScrollBarWidth + (float)GuiGetStyle(DEFAULT , BORDER_WIDTH) : (float)-GuiGetStyle(DEFAULT , BORDER_WIDTH);

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check button state
                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = GuiState.STATE_PRESSED;
                    else state = GuiState.STATE_FOCUSED;

                    if (SUPPORT_SCROLLBAR_KEY_INPUT)
                    {

                        if (hasHorizontalScrollBar)
                        {
                            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) scrollPos.X -= GuiGetStyle(SCROLLBAR , SCROLL_SPEED);
                            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) scrollPos.X += GuiGetStyle(SCROLLBAR , SCROLL_SPEED);
                        }

                        if (hasVerticalScrollBar)
                        {
                            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) scrollPos.Y -= GuiGetStyle(SCROLLBAR , SCROLL_SPEED);
                            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) scrollPos.Y += GuiGetStyle(SCROLLBAR , SCROLL_SPEED);
                        }
                    }

                    float wheelMove = Raylib.GetMouseWheelMove();

                    // Horizontal scroll ((Left Control or Left Shift) + Mouse wheel)
                    if (hasHorizontalScrollBar && (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_CONTROL) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))) scrollPos.X += wheelMove * 20;
                    else scrollPos.Y += wheelMove * mouseWheelSpeed; // Vertical scroll
                }
            }

            // Normalize scroll values
            if (scrollPos.X > -horizontalMin) scrollPos.X = -horizontalMin;
            if (scrollPos.X < -horizontalMax) scrollPos.X = -horizontalMax;
            if (scrollPos.Y > -verticalMin) scrollPos.Y = -verticalMin;
            if (scrollPos.Y < -verticalMax) scrollPos.Y = -verticalMax;
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (text.IsNotNull()) GuiStatusBar(statusBar , text);  // Draw panel header as status bar

            GuiDrawRectangle(bounds , 0 , Color.BLANK , GetColor(GuiGetStyle(DEFAULT , BACKGROUND_COLOR)));      // Draw background

            // Save size of the scrollbar slider
            uint slider = GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE);

            // Draw horizontal scrollbar if visible
            if (hasHorizontalScrollBar)
            {
                // Change scrollbar slider size to show the diff in size between the content width and the widget width
                GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE , (uint)(((bounds.width - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - verticalScrollBarWidth) / (int)content.width) * ((int)bounds.width - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - verticalScrollBarWidth)));
                scrollPos.X = (float)-GuiScrollBar(horizontalScrollBar , (int)-scrollPos.X , (int)horizontalMin , (int)horizontalMax);
            }
            else scrollPos.X = 0.0f;

            // Draw vertical scrollbar if visible
            if (hasVerticalScrollBar)
            {
                // Change scrollbar slider size to show the diff in size between the content height and the widget height
                GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE , (uint)(((bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - horizontalScrollBarWidth) / (int)content.height) * ((int)bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH) - horizontalScrollBarWidth)));
                scrollPos.Y = (float)-GuiScrollBar(verticalScrollBar , (int)-scrollPos.Y , (int)verticalMin , (int)verticalMax);
            }
            else scrollPos.Y = 0.0f;

            // Draw detail corner rectangle if both scroll bars are visible
            if (hasHorizontalScrollBar && hasVerticalScrollBar)
            {
                Rectangle corner = new((GuiGetStyle(LISTVIEW , SCROLLBAR_SIDE) == SCROLLBAR_LEFT_SIDE) ? (bounds.x + GuiGetStyle(DEFAULT , BORDER_WIDTH) + 2) : (horizontalScrollBar.x + horizontalScrollBar.width + 2) , verticalScrollBar.y + verticalScrollBar.height + 2 , (float)horizontalScrollBarWidth - 4 , (float)verticalScrollBarWidth - 4);
                GuiDrawRectangle(corner , 0 , Color.BLANK , GetColor(GuiGetStyle(LISTVIEW , TEXT + ((int)state * 3))));
            }

            // Draw scrollbar lines depending on current state
            GuiDrawRectangle(bounds , (int)GuiGetStyle(DEFAULT , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(LISTVIEW , BORDER + ((int)state * 3))) , guiAlpha) , Color.BLANK);

            // Set scrollbar slider size back to the way it was before
            GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE , slider);
            //--------------------------------------------------------------------

            if (scroll.HasValue) scroll = scrollPos;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Panel control
        public static int GuiPanel(Rectangle bounds , ReadonlyString text)
        {
            int result = 0;
            GuiState state = guiState;

            // Text will be drawn as a header bar (if provided)
            Rectangle statusBar = new Rectangle(bounds.x , bounds.y , bounds.width , RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT);
            if ((text.Ref != null) && (bounds.height < RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT * 2.0f)) bounds.height = RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT * 2.0f;

            if (text.Ref != null)
            {
                // Move panel bounds after the header bar
                bounds.y += (float)RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT - 1;
                bounds.height -= (float)RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT + 1;
            }

            // Draw control
            //--------------------------------------------------------------------
            if (text.Ref != null) GuiStatusBar(statusBar , text);  // Draw panel header as status bar

            GuiDrawRectangle(bounds ,
                             RAYGUI_PANEL_BORDER_WIDTH ,
                             Fade(GetColor(GuiGetStyle(DEFAULT , ((int)state == STATE_DISABLED) ? BORDER_COLOR_DISABLED : LINE_COLOR)) , guiAlpha) ,
                             Fade(GetColor(GuiGetStyle(DEFAULT , ((int)state == STATE_DISABLED) ? BASE_COLOR_DISABLED : BACKGROUND_COLOR)) , guiAlpha));
            //--------------------------------------------------------------------
            return result;
        }

        // Dummy rectangle control, intended for placeholding
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiDummyRec(Rectangle bounds , ReadonlyString text)
        {
            GuiState state = guiState;

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check button state
                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = GuiState.STATE_PRESSED;
                    else state = GuiState.STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(DEFAULT , (state != GuiState.STATE_DISABLED) ? BASE_COLOR_NORMAL : BASE_COLOR_DISABLED)) , guiAlpha));
            GuiDrawText(text , GetTextBounds(DEFAULT , bounds) , TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(BUTTON , (state != GuiState.STATE_DISABLED) ? TEXT_COLOR_NORMAL : TEXT_COLOR_DISABLED)) , guiAlpha));
            //------------------------------------------------------------------
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Status Bar control
        public static void GuiStatusBar(Rectangle bounds , ReadonlyString text)
        {
            GuiState state = guiState;

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds , (int)GuiGetStyle(STATUSBAR , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(STATUSBAR , ((int)state != STATE_DISABLED) ? BORDER_COLOR_NORMAL : BORDER_COLOR_DISABLED)) , guiAlpha) ,
                             Fade(GetColor(GuiGetStyle(STATUSBAR , ((int)state != STATE_DISABLED) ? BASE_COLOR_NORMAL : BASE_COLOR_DISABLED)) , guiAlpha));
            GuiDrawText(text , GetTextBounds(STATUSBAR , bounds) , (int)GuiGetStyle(STATUSBAR , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(STATUSBAR , ((int)state != STATE_DISABLED) ? TEXT_COLOR_NORMAL : TEXT_COLOR_DISABLED)) , guiAlpha));
            //--------------------------------------------------------------------
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Draw tooltip using control bounds
        public static void GuiTooltip(Rectangle controlRec)
        {
            if (!guiLocked && guiTooltip && (guiTooltipPtr != null) && !guiSliderDragging)
            {
                Vector2 textSize = Raylib.MeasureTextEx(GuiGetFont() , guiTooltipPtr , GuiGetStyle(DEFAULT , TEXT_SIZE) , GuiGetStyle(DEFAULT , TEXT_SPACING));

                if ((controlRec.x + textSize.X + 16) > Raylib.GetScreenWidth()) controlRec.x -= (textSize.X + 16 - controlRec.width);

                GuiPanel(new Rectangle(controlRec.x , controlRec.y + controlRec.height + 4 , textSize.Y + 16 , GuiGetStyle(DEFAULT , TEXT_SIZE) + 8.0f) , null);

                uint textPadding = GuiGetStyle(LABEL , TEXT_PADDING);
                uint textAlignment = GuiGetStyle(LABEL , TEXT_ALIGNMENT);
                GuiSetStyle(LABEL , TEXT_PADDING , 0);
                GuiSetStyle(LABEL , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);
                GuiLabel(new Rectangle(controlRec.x , controlRec.y + controlRec.height + 4 , textSize.X + 16 , GuiGetStyle(DEFAULT , TEXT_SIZE) + 8.0f) , guiTooltipPtr);
                GuiSetStyle(LABEL , TEXT_ALIGNMENT , textAlignment);
                GuiSetStyle(LABEL , TEXT_PADDING , textPadding);
            }
        }
        // Gui draw rectangle using default raygui plain style with borders
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiDrawRectangle(Rectangle rec , int borderWidth , Color borderColor , Color color)
        {
            if (color.a > 0)
            {
                // Draw rectangle filled with color
                Raylib.DrawRectangle((int)rec.x , (int)rec.y , (int)rec.width , (int)rec.height , color);
            }

            if (borderWidth > 0)
            {
                // Draw rectangle border lines with color
                Raylib.DrawRectangle((int)rec.x , (int)rec.y , (int)rec.width , borderWidth , borderColor);
                Raylib.DrawRectangle((int)rec.x , (int)rec.y + borderWidth , borderWidth , (int)rec.height - 2 * borderWidth , borderColor);
                Raylib.DrawRectangle((int)rec.x + (int)rec.width - borderWidth , (int)rec.y + borderWidth , borderWidth , (int)rec.height - 2 * borderWidth , borderColor);
                Raylib.DrawRectangle((int)rec.x , (int)rec.y + (int)rec.height - borderWidth , (int)rec.width , borderWidth , borderColor);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiSetStyle(int control , int property , uint value)
        {
            if (!guiStyleLoaded) GuiLoadStyleDefault();
            guiStyle [ control * (RAYGUI_MAX_PROPS_BASE + RAYGUI_MAX_PROPS_EXTENDED) + property ] = value;

            // Default properties are propagated to all controls
            if ((control == 0) && (property < RAYGUI_MAX_PROPS_BASE))
            {
                for (int i = 1 ; i < RAYGUI_MAX_CONTROLS ; i++) guiStyle [ i * (RAYGUI_MAX_PROPS_BASE + RAYGUI_MAX_PROPS_EXTENDED) + property ] = value;
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiWindowBox(Rectangle bounds , ReadonlyString title)
        {
            //GuiState state = guiState;
            int result = 0;

            int statusBarHeight = RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT;

            Rectangle statusBar = new Rectangle(bounds.x , bounds.y , bounds.width , statusBarHeight);
            if (bounds.height < statusBarHeight * 2.0f) bounds.height = statusBarHeight * 2.0f;

            Rectangle windowPanel = new(bounds.x , bounds.y + statusBarHeight - 1 , bounds.width , bounds.height - statusBarHeight + 1);
            Rectangle closeButtonRec = new(statusBar.x + statusBar.width - GuiGetStyle(STATUSBAR , BORDER_WIDTH) - 20 ,
                                         statusBar.y + statusBarHeight / 2.0f - 18.0f / 2.0f , 18 , 18);

            // Update control
            //--------------------------------------------------------------------
            // NOTE: Logic is directly managed by button
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiStatusBar(statusBar , title); // Draw window header as status bar
            GuiPanel(windowPanel , new ReadonlyString() { Ref = null });    // Draw window base

            // Draw window close button
            uint tempBorderWidth = GuiGetStyle(BUTTON , BORDER_WIDTH);
            uint tempTextAlignment = GuiGetStyle(BUTTON , TEXT_ALIGNMENT);
            GuiSetStyle(BUTTON , BORDER_WIDTH , 1);
            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);
            if (RAYGUI_NO_ICONS)

                result = GuiButton(closeButtonRec , "x");
            else
                result = GuiButton(closeButtonRec , (int)GuiIconName.ICON_CROSS_SMALL , "");

            GuiSetStyle(BUTTON , BORDER_WIDTH , tempBorderWidth);
            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , tempTextAlignment);
            //--------------------------------------------------------------------

            return result;
        }

        // Get text with icon id prepended
        // NOTE: Useful to add icons by name id (enum) instead of
        // a number that can change between ricon versions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyString GuiIconText(int iconId , ReadonlyString text)
        {
            if (RAYGUI_NO_ICONS)
                return ReadonlyString.NULL;
            else
            {
                if (text.Ref != null)
                {
                    Span<char> chars = stackalloc char [ text.Length + 5 ];
                    chars [ 0 ] = '#';
                    chars [ 1 ] = (char)((iconId / 100) + '0');
                    chars [ 2 ] = (char)((iconId / 10) + '0');
                    chars [ 3 ] = (char)((iconId % 10) + '0');
                    chars [ 4 ] = '#';
                    for (int i = 0 ; i < text.Length ; i++)
                    {
                        chars [ i + 5 ] = text [ i ];
                    }
                    return new ReadonlyString() { Ref = chars.ToString() };
                }
                else
                {
                    Span<char> chars = stackalloc char [ 5 ];
                    chars [ 0 ] = '#';
                    chars [ 1 ] = (char)((iconId / 100) + '0');
                    chars [ 2 ] = (char)((iconId / 10) + '0');
                    chars [ 3 ] = (char)((iconId % 10) + '0');
                    chars [ 4 ] = '#';
                    return new ReadonlyString() { Ref = chars.ToString() };
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiLoadStyleDefault()
        {
            // We set this variable first to avoid cyclic function calls
            // when calling GuiSetStyle() and GuiGetStyle()
            guiStyleLoaded = true;

            // Initialize default LIGHT style property values
            GuiSetStyle(DEFAULT , BORDER_COLOR_NORMAL , 0x838383ff);
            GuiSetStyle(DEFAULT , BASE_COLOR_NORMAL , 0xc9c9c9ff);
            GuiSetStyle(DEFAULT , TEXT_COLOR_NORMAL , 0x686868ff);
            GuiSetStyle(DEFAULT , BORDER_COLOR_FOCUSED , 0x5bb2d9ff);
            GuiSetStyle(DEFAULT , BASE_COLOR_FOCUSED , 0xc9effeff);
            GuiSetStyle(DEFAULT , TEXT_COLOR_FOCUSED , 0x6c9bbcff);
            GuiSetStyle(DEFAULT , BORDER_COLOR_PRESSED , 0x0492c7ff);
            GuiSetStyle(DEFAULT , BASE_COLOR_PRESSED , 0x97e8ffff);
            GuiSetStyle(DEFAULT , TEXT_COLOR_PRESSED , 0x368bafff);
            GuiSetStyle(DEFAULT , BORDER_COLOR_DISABLED , 0xb5c1c2ff);
            GuiSetStyle(DEFAULT , BASE_COLOR_DISABLED , 0xe6e9e9ff);
            GuiSetStyle(DEFAULT , TEXT_COLOR_DISABLED , 0xaeb7b8ff);
            GuiSetStyle(DEFAULT , BORDER_WIDTH , 1);                       // WARNING: Some controls use other values
            GuiSetStyle(DEFAULT , TEXT_PADDING , 0);                       // WARNING: Some controls use other values
            GuiSetStyle(DEFAULT , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER); // WARNING: Some controls use other values

            // Initialize control-specific property values
            // NOTE: Those properties are in default list but require specific values by control type
            GuiSetStyle(LABEL , TEXT_ALIGNMENT , TEXT_ALIGN_LEFT);
            GuiSetStyle(BUTTON , BORDER_WIDTH , 2);
            GuiSetStyle(SLIDER , TEXT_PADDING , 4);
            GuiSetStyle(CHECKBOX , TEXT_PADDING , 4);
            GuiSetStyle(CHECKBOX , TEXT_ALIGNMENT , TEXT_ALIGN_RIGHT);
            GuiSetStyle(TEXTBOX , TEXT_PADDING , 4);
            GuiSetStyle(TEXTBOX , TEXT_ALIGNMENT , TEXT_ALIGN_LEFT);
            GuiSetStyle(VALUEBOX , TEXT_PADDING , 0);
            GuiSetStyle(VALUEBOX , TEXT_ALIGNMENT , TEXT_ALIGN_LEFT);
            GuiSetStyle(SPINNER , TEXT_PADDING , 0);
            GuiSetStyle(SPINNER , TEXT_ALIGNMENT , TEXT_ALIGN_LEFT);
            GuiSetStyle(STATUSBAR , TEXT_PADDING , 8);
            GuiSetStyle(STATUSBAR , TEXT_ALIGNMENT , TEXT_ALIGN_LEFT);

            // Initialize extended property values
            // NOTE: By default, extended property values are initialized to 0
            GuiSetStyle(DEFAULT , TEXT_SIZE , 10);                // DEFAULT, shared by all controls
            GuiSetStyle(DEFAULT , TEXT_SPACING , 1);              // DEFAULT, shared by all controls
            GuiSetStyle(DEFAULT , LINE_COLOR , 0x90abb5ff);       // DEFAULT specific property
            GuiSetStyle(DEFAULT , BACKGROUND_COLOR , 0xf5f5f5ff); // DEFAULT specific property
            GuiSetStyle(TOGGLE , GROUP_PADDING , 2);
            GuiSetStyle(SLIDER , SLIDER_WIDTH , 16);
            GuiSetStyle(SLIDER , SLIDER_PADDING , 1);
            GuiSetStyle(PROGRESSBAR , PROGRESS_PADDING , 1);
            GuiSetStyle(CHECKBOX , CHECK_PADDING , 1);
            GuiSetStyle(COMBOBOX , COMBO_BUTTON_WIDTH , 32);
            GuiSetStyle(COMBOBOX , COMBO_BUTTON_SPACING , 2);
            GuiSetStyle(DROPDOWNBOX , ARROW_PADDING , 16);
            GuiSetStyle(DROPDOWNBOX , DROPDOWN_ITEMS_SPACING , 2);
            GuiSetStyle(TEXTBOX , TEXT_LINES_SPACING , (uint)(GuiGetStyle(DEFAULT , TEXT_SIZE) * 1.5f));
            GuiSetStyle(TEXTBOX , TEXT_INNER_PADDING , 4);
            GuiSetStyle(SPINNER , SPIN_BUTTON_WIDTH , 24);
            GuiSetStyle(SPINNER , SPIN_BUTTON_SPACING , 2);
            GuiSetStyle(SCROLLBAR , BORDER_WIDTH , 0);
            GuiSetStyle(SCROLLBAR , ARROWS_VISIBLE , 0);
            GuiSetStyle(SCROLLBAR , ARROWS_SIZE , 6);
            GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_PADDING , 0);
            GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE , 16);
            GuiSetStyle(SCROLLBAR , SCROLL_PADDING , 0);
            GuiSetStyle(SCROLLBAR , SCROLL_SPEED , 12);
            GuiSetStyle(LISTVIEW , LIST_ITEMS_HEIGHT , 28);
            GuiSetStyle(LISTVIEW , LIST_ITEMS_SPACING , 2);
            GuiSetStyle(LISTVIEW , SCROLLBAR_WIDTH , 12);
            GuiSetStyle(LISTVIEW , SCROLLBAR_SIDE , SCROLLBAR_RIGHT_SIDE);
            GuiSetStyle(COLORPICKER , COLOR_SELECTOR_SIZE , 8);
            GuiSetStyle(COLORPICKER , HUEBAR_WIDTH , 16);
            GuiSetStyle(COLORPICKER , HUEBAR_PADDING , 8);
            GuiSetStyle(COLORPICKER , HUEBAR_SELECTOR_HEIGHT , 8);
            GuiSetStyle(COLORPICKER , HUEBAR_SELECTOR_OVERFLOW , 2);

            if (guiFont.texture.id != Raylib.GetFontDefault().texture.id)
            {
                // Unload previous font texture
                Raylib.UnloadTexture(guiFont.texture);

                // Setup default raylib font
                guiFont = Raylib.GetFontDefault();

                // NOTE: Default raylib font character 95 is a white square
                Rectangle whiteChar;
                unsafe
                {
                    whiteChar = guiFont.recs [ 95 ];
                }
                // NOTE: We set up a 1px padding on char rectangle to avoid pixel bleeding on MSAA filtering
                Raylib.SetShapesTexture(guiFont.texture , new Rectangle(whiteChar.x + 1 , whiteChar.y + 1 , whiteChar.width - 2 , whiteChar.height - 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint GuiGetStyle(int control , int property)
        {
            if (!guiStyleLoaded) GuiLoadStyleDefault();
            return guiStyle [ control * (RAYGUI_MAX_PROPS_BASE + RAYGUI_MAX_PROPS_EXTENDED) + property ];
        }
        // Check if point is inside rectangle
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CheckCollisionPointRec(Vector2 point , Rectangle rec)
        {
            bool collision = false;

            if ((point.X >= rec.x) && (point.X <= (rec.x + rec.width)) &&
                (point.Y >= rec.y) && (point.Y <= (rec.y + rec.height))) collision = true;

            return collision;
        }
        // Scroll bar control (used by GuiScrollPanel())
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiScrollBar(Rectangle bounds , int value , int minValue , int maxValue)
        {
            GuiState state = guiState;

            // Is the scrollbar horizontal or vertical?
            bool isVertical = (bounds.width > bounds.height) ? false : true;

            // The size (width or height depending on scrollbar type) of the spinner buttons
            long spinnerSize = (GuiGetStyle(SCROLLBAR , ARROWS_VISIBLE) != 0) ?
                (isVertical ? (int)bounds.width - 2 * GuiGetStyle(SCROLLBAR , BORDER_WIDTH) :
                (int)bounds.height - 2 * GuiGetStyle(SCROLLBAR , BORDER_WIDTH)) : 0;

            // Arrow buttons [<] [>] [∧] [∨]
            Rectangle arrowUpLeft = default;
            Rectangle arrowDownRight = default;

            // Actual area of the scrollbar excluding the arrow buttons
            Rectangle scrollbar = default;

            // Slider bar that moves     --[///]-----
            Rectangle slider = default;

            // Normalize value
            if (value > maxValue) value = maxValue;
            if (value < minValue) value = minValue;

            int valueRange = maxValue - minValue;
            uint sliderSize = GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE);

            // Calculate rectangles for all of the components
            arrowUpLeft = new Rectangle(bounds.x + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) ,
                                        bounds.y + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) ,
                                        spinnerSize ,
                                        spinnerSize);

            if (isVertical)
            {
                arrowDownRight = new Rectangle(bounds.x + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) , bounds.y + bounds.height - spinnerSize - GuiGetStyle(SCROLLBAR , BORDER_WIDTH) , spinnerSize , spinnerSize);
                scrollbar = new Rectangle(bounds.x + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_PADDING) , arrowUpLeft.y + arrowUpLeft.height , bounds.width - 2 * (GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_PADDING)) , bounds.height - arrowUpLeft.height - arrowDownRight.height - 2 * GuiGetStyle(SCROLLBAR , BORDER_WIDTH));

                // Make sure the slider won't get outside of the scrollbar
                sliderSize = (sliderSize >= scrollbar.height) ? ((uint)scrollbar.height - 2) : sliderSize;
                slider = new Rectangle(bounds.x + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_PADDING) ,
                                       scrollbar.y + (int)(((float)(value - minValue) / valueRange) * (scrollbar.height - sliderSize)) ,
                                       bounds.width - 2 * (GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_PADDING)) ,
                                       sliderSize);
            }
            else    // horizontal
            {
                arrowDownRight = new Rectangle(bounds.x + bounds.width - spinnerSize - GuiGetStyle(SCROLLBAR , BORDER_WIDTH) , bounds.y + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) , spinnerSize , spinnerSize);
                scrollbar = new Rectangle(arrowUpLeft.x + arrowUpLeft.width , bounds.y + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_PADDING) , bounds.width - arrowUpLeft.width - arrowDownRight.width - 2 * GuiGetStyle(SCROLLBAR , BORDER_WIDTH) , bounds.height - 2 * (GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_PADDING)));

                // Make sure the slider won't get outside of the scrollbar
                sliderSize = (sliderSize >= scrollbar.width) ? ((uint)scrollbar.width - 2) : sliderSize;
                slider = new Rectangle(scrollbar.x + (int)(((float)(value - minValue) / valueRange) * (scrollbar.width - sliderSize)) ,
                                       bounds.y + GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_PADDING) ,
                                       sliderSize ,
                                       bounds.height - 2 * (GuiGetStyle(SCROLLBAR , BORDER_WIDTH) + GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_PADDING)));
            }

            // Update control
            //--------------------------------------------------------------------
            if (((int)state != STATE_DISABLED) && !guiLocked)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (guiSliderDragging) // Keep dragging outside of bounds
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        if (CHECK_BOUNDS_ID(bounds , guiSliderActive))
                        {
                            if (isVertical) value += (int)(Raylib.GetMouseDelta().Y / (scrollbar.height - slider.height) * valueRange);
                            else value += (int)(Raylib.GetMouseDelta().X / (scrollbar.width - slider.width) * valueRange);
                        }
                    }
                    else
                    {
                        guiSliderDragging = false;
                        guiSliderActive = new Rectangle(0 , 0 , 0 , 0);
                    }
                }
                else if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    state = GuiState.STATE_FOCUSED;
                    guiSliderActive = bounds; // Store bounds as an identifier when dragging starts

                    // Handle mouse wheel
                    int wheel = (int)Raylib.GetMouseWheelMove();
                    if (wheel != 0) value += wheel;

                    // Handle mouse button down
                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        guiSliderDragging = true;
                        // Check arrows click
                        if (Raylib.CheckCollisionPointRec(mousePoint , arrowUpLeft))
                            value -= valueRange / (int)GuiGetStyle(SCROLLBAR , SCROLL_SPEED);
                        else if (Raylib.CheckCollisionPointRec(mousePoint , arrowDownRight))
                            value += valueRange / (int)GuiGetStyle(SCROLLBAR , SCROLL_SPEED);
                        else if (!Raylib.CheckCollisionPointRec(mousePoint , slider))
                        {
                            // If click on scrollbar position but not on slider, place slider directly on that position
                            if (isVertical)
                                value = (int)(((float)(mousePoint.Y - scrollbar.y - slider.height / 2) * valueRange) / (scrollbar.height - slider.height) + minValue);
                            else
                                value = (int)(((float)(mousePoint.X - scrollbar.x - slider.width / 2) * valueRange) / (scrollbar.width - slider.width) + minValue);
                        }

                        //state = (GuiState)STATE_PRESSED;
                    }
                    else if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        guiSliderDragging = true;
                        if (isVertical) value += (int)(Raylib.GetMouseDelta().Y / (scrollbar.height - slider.height) * valueRange);
                        else value += (int)(Raylib.GetMouseDelta().X / (scrollbar.width - slider.width) * valueRange);
                    }

                    // Keyboard control on mouse hover scrollbar
                    /*
                    if (isVertical)
                    {
                        if (IsKeyDown(KEY_DOWN)) value += 5;
                        else if (IsKeyDown(KEY_UP)) value -= 5;
                    }
                    else
                    {
                        if (IsKeyDown(KEY_RIGHT)) value += 5;
                        else if (IsKeyDown(KEY_LEFT)) value -= 5;
                    }
                    */
                }

                // Normalize value
                if (value > maxValue) value = maxValue;
                if (value < minValue) value = minValue;
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds , (int)GuiGetStyle(SCROLLBAR , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(LISTVIEW , BORDER + (int)state * 3)) , guiAlpha) , Fade(GetColor(GuiGetStyle(DEFAULT , BORDER_COLOR_DISABLED)) , guiAlpha));   // Draw the background

            GuiDrawRectangle(scrollbar , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(BUTTON , BASE_COLOR_NORMAL)) , guiAlpha));     // Draw the scrollbar active area background
            GuiDrawRectangle(slider , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(SLIDER , BORDER + (int)state * 3)) , guiAlpha));         // Draw the slider bar

            // Draw arrows (using icon if available)
            if (GuiGetStyle(SCROLLBAR , ARROWS_VISIBLE) != 0)
            {
                if (RAYGUI_NO_ICONS)
                {
                    GuiDrawText(isVertical ? "^" : "<" ,
                        new Rectangle(arrowUpLeft.x , arrowUpLeft.y , isVertical ? bounds.width : bounds.height , isVertical ? bounds.width : bounds.height) ,
                        TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT + ((int)state * 3))) , guiAlpha));
                    GuiDrawText(isVertical ? "v" : ">" ,
                        new Rectangle(arrowDownRight.x , arrowDownRight.y , isVertical ? bounds.width : bounds.height , isVertical ? bounds.width : bounds.height) ,
                        TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT + ((int)state * 3))) , guiAlpha));

                }
                else
                {
                    GuiDrawText(isVertical ? "#121#" : "#118#" ,
                        new Rectangle(arrowUpLeft.x , arrowUpLeft.y , isVertical ? bounds.width : bounds.height , isVertical ? bounds.width : bounds.height) ,
                TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(SCROLLBAR , TEXT + (int)state * 3)) , guiAlpha));   // ICON_ARROW_UP_FILL / ICON_ARROW_LEFT_FILL
                    GuiDrawText(isVertical ? "#120#" : "#119#" ,
                        new Rectangle(arrowDownRight.x , arrowDownRight.y , isVertical ? bounds.width : bounds.height , isVertical ? bounds.width : bounds.height) ,
                TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(SCROLLBAR , TEXT + (int)state * 3)) , guiAlpha));   // ICON_ARROW_DOWN_FILL / ICON_ARROW_RIGHT_FILL
                }
                //#if defined(RAYGUI_NO_ICONS)
                //#else
                //#endif
            }
            //--------------------------------------------------------------------

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Progress Bar control extended, shows current progress value
        public static float GuiProgressBar(Rectangle bounds , ReadonlyString textLeft , ReadonlyString textRight , float value , float minValue , float maxValue)
        {
            GuiState state = guiState;

            Rectangle progress = new Rectangle(bounds.x + GuiGetStyle(PROGRESSBAR , BORDER_WIDTH) ,
                                   bounds.y + GuiGetStyle(PROGRESSBAR , BORDER_WIDTH) + GuiGetStyle(PROGRESSBAR , PROGRESS_PADDING) , 0 ,
                                   bounds.height - 2 * GuiGetStyle(PROGRESSBAR , BORDER_WIDTH) - 2 * GuiGetStyle(PROGRESSBAR , PROGRESS_PADDING));

            // Update control
            //--------------------------------------------------------------------
            if (value > maxValue) value = maxValue;

            if (state != GuiState.STATE_DISABLED) progress.width = ((float)(value / (maxValue - minValue)) * (float)(bounds.width - 2 * GuiGetStyle(PROGRESSBAR , BORDER_WIDTH)));
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds , (int)GuiGetStyle(PROGRESSBAR , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(PROGRESSBAR , BORDER + ((int)state * 3))) , guiAlpha) , Color.BLANK);

            // Draw slider internal progress bar (depends on state)
            if ((state == STATE_NORMAL) || (state == GuiState.STATE_PRESSED)) GuiDrawRectangle(progress , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(PROGRESSBAR , BASE_COLOR_PRESSED)) , guiAlpha));
            else if (state == GuiState.STATE_FOCUSED) GuiDrawRectangle(progress , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(PROGRESSBAR , TEXT_COLOR_FOCUSED)) , guiAlpha));

            // Draw left/right text if provided
            if (textLeft.Ref != null)
            {
                Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);
                textBounds.width = GetTextWidth(textLeft);
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x - textBounds.width - GuiGetStyle(PROGRESSBAR , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;

                GuiDrawText(textLeft , textBounds , TEXT_ALIGN_RIGHT , Fade(GetColor(GuiGetStyle(PROGRESSBAR , TEXT + ((int)state * 3))) , guiAlpha));
            }

            if (textRight.Ref != null)
            {
                Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);
                textBounds.width = GetTextWidth(textRight);
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x + bounds.width + GuiGetStyle(PROGRESSBAR , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;

                GuiDrawText(textRight , textBounds , TEXT_ALIGN_LEFT , Fade(GetColor(GuiGetStyle(PROGRESSBAR , TEXT + ((int)state * 3))) , guiAlpha));
            }
            //--------------------------------------------------------------------

            return value;
        }

        // List View control
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiListView(Rectangle bounds , ReadonlyString text , ref int scrollIndex , int active)
        {
            int itemCount = 0;
            ReadonlyString [ ] items;
            if (text.Length > 0)
            {
                var result = text.AsReadOnlySpan().SplitSingleChar(';');
                items = new ReadonlyString [ result.Item1 ];
                for (int i = 0 ; i < result.Item1 ; i++)
                {
                    items [ i ] = text;
                    items [ i ].Start = result.Item2 [ i ].Item1;
                    items [ i ].Length = result.Item2 [ i ].Item2;
                }
                itemCount = result.Item1;
            }
            else
            {
                items = new ReadonlyString [ 0 ];
            }
            //if (text != NULL) items = GuiTextSplit(text , ';' , &itemCount , NULL);
            int f = -1;
            return GuiListViewEx(bounds , items , itemCount , ref f , ref scrollIndex , active);
        }

        // Color Picker control that avoids conversion to RGB and back to HSV on each call, thus avoiding jittering.
        // The user can call ConvertHSVtoRGB() to convert *colorHsv value to RGB.
        // NOTE: It's divided in multiple controls:
        //      int GuiColorPanelHSV(Rectangle bounds, const char *text, Vector3 *colorHsv)
        //      int GuiColorBarAlpha(Rectangle bounds, const char *text, float *alpha)
        //      float GuiColorBarHue(Rectangle bounds, float value)
        // NOTE: bounds define GuiColorPanelHSV() size
        public static int GuiColorPickerHSV(Rectangle bounds , ReadonlyString text , ref Vector3 colorHsv)
        {
            int result = 0;


            var v = colorHsv;
            GuiColorPanelHSV(bounds , ReadonlyString.NULL , ref v);
            colorHsv = v;
            Rectangle boundsHue = new((float)bounds.x + bounds.width + GuiGetStyle(COLORPICKER , HUEBAR_PADDING) , (float)bounds.y , (float)GuiGetStyle(COLORPICKER , HUEBAR_WIDTH) , (float)bounds.height);

            GuiColorBarHue(boundsHue , ReadonlyString.NULL , ref colorHsv.X);

            return result;
        }

        // Color Panel control, returns HSV color value in *colorHsv.
        // Used by GuiColorPickerHSV()
        public static int GuiColorPanelHSV(Rectangle bounds , ReadonlyString text , ref Vector3 colorHsv)
        {
            int result = 0;
            GuiState state = guiState;
            Vector2 pickerSelector = default;

            Color colWhite = new(255 , 255 , 255 , 255);
            Color colBlack = new(0 , 0 , 0 , 255);

            pickerSelector.X = bounds.x + (float)colorHsv.Y * bounds.width;            // HSV: Saturation
            pickerSelector.Y = bounds.y + (1.0f - (float)colorHsv.Z) * bounds.height;  // HSV: Value

            float hue = -1.0f;
            Vector3 maxHue = new(hue >= 0.0f ? hue : colorHsv.X , 1.0f , 1.0f);
            Vector3 rgbHue = ConvertHSVtoRGB(maxHue);
            Color maxHueCol = new((byte)(255.0f * rgbHue.X) ,
                              (byte)(255.0f * rgbHue.Y) ,
                              (byte)(255.0f * rgbHue.Z) , (byte)255);

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = GuiState.STATE_PRESSED;
                        pickerSelector = mousePoint;

                        // Calculate color from picker
                        Vector2 colorPick = new(pickerSelector.X - bounds.x , pickerSelector.Y - bounds.y);

                        colorPick.X /= (float)bounds.width;     // Get normalized value on x
                        colorPick.Y /= (float)bounds.height;    // Get normalized value on y

                        colorHsv.Y = colorPick.X;
                        colorHsv.Z = 1.0f - colorPick.Y;
                    }
                    else state = GuiState.STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (state != GuiState.STATE_DISABLED)
            {
                Raylib.DrawRectangleGradientEx(bounds , Fade(colWhite , guiAlpha) , Fade(colWhite , guiAlpha) , Fade(maxHueCol , guiAlpha) , Fade(maxHueCol , guiAlpha));
                Raylib.DrawRectangleGradientEx(bounds , Fade(colBlack , 0) , Fade(colBlack , guiAlpha) , Fade(colBlack , guiAlpha) , Fade(colBlack , 0));

                // Draw color picker: selector
                Rectangle selector = new(pickerSelector.X - GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE) / 2 ,
                                          pickerSelector.Y - GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE) / 2 ,
                                          (float)GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE) ,
                                          (float)GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE));
                GuiDrawRectangle(selector , 0 , Color.BLANK , colWhite);
            }
            else
            {
                Raylib.DrawRectangleGradientEx(bounds , Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BASE_COLOR_DISABLED)) , 0.1f) , guiAlpha) , Fade(Fade(colBlack , 0.6f) , guiAlpha) , Fade(Fade(colBlack , 0.6f) , guiAlpha) , Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER_COLOR_DISABLED)) , 0.6f) , guiAlpha));
            }

            GuiDrawRectangle(bounds , (int)GuiGetStyle(COLORPICKER , BORDER_WIDTH) , GetColor(GuiGetStyle(COLORPICKER , BORDER + (int)state * 3)) , Color.BLANK);
            //--------------------------------------------------------------------

            return result;
        }
        // Message Box control
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiMessageBox(Rectangle bounds , ReadonlyString title , ReadonlyString message , ReadonlyString buttons)
        {

            int result = -1;    // Returns clicked button from buttons list, 0 refers to closed window button
            var buttonsText_result = buttons.AsReadOnlySpan().SplitSingleChar(';');
            int buttonCount = buttonsText_result.Item1;
            Rectangle buttonBounds = new Rectangle(0 , 0 , 0 , 0);
            buttonBounds.x = bounds.x + RAYGUI_MESSAGEBOX_BUTTON_PADDING;
            buttonBounds.y = bounds.y + bounds.height - RAYGUI_MESSAGEBOX_BUTTON_HEIGHT - RAYGUI_MESSAGEBOX_BUTTON_PADDING;
            buttonBounds.width = (bounds.width - RAYGUI_MESSAGEBOX_BUTTON_PADDING * (buttonCount + 1)) / buttonCount;
            buttonBounds.height = RAYGUI_MESSAGEBOX_BUTTON_HEIGHT;

            int textWidth = GetTextWidth(message) + 2;

            Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);
            textBounds.x = bounds.x + bounds.width / 2 - textWidth / 2;
            textBounds.y = bounds.y + RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT + RAYGUI_MESSAGEBOX_BUTTON_PADDING;
            textBounds.width = textWidth;
            textBounds.height = bounds.height - RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT - 3 * RAYGUI_MESSAGEBOX_BUTTON_PADDING - RAYGUI_MESSAGEBOX_BUTTON_HEIGHT;

            // Draw control
            //--------------------------------------------------------------------
            if (GuiWindowBox(bounds , title) == 1) result = 0;

            uint prevTextAlignment = GuiGetStyle(LABEL , TEXT_ALIGNMENT);
            GuiSetStyle(LABEL , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);
            GuiLabel(textBounds , message);
            GuiSetStyle(LABEL , TEXT_ALIGNMENT , prevTextAlignment);

            prevTextAlignment = GuiGetStyle(BUTTON , TEXT_ALIGNMENT);
            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);

            for (int i = 0 ; i < buttonCount ; i++)
            {
                {
                    ReadonlyString button = buttons.Ref;
                    button.Start = buttonsText_result.Item2 [ i ].Item1;
                    button.Length = buttonsText_result.Item2 [ i ].Item2;
                    if (GuiButton(buttonBounds , button) == 1) result = i + 1;
                }
                buttonBounds.x += (buttonBounds.width + RAYGUI_MESSAGEBOX_BUTTON_PADDING);
            }

            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , prevTextAlignment);
            //--------------------------------------------------------------------

            return result;
        }

        // List View control with extended parameters
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiListViewEx(Rectangle bounds , ReadonlyString [ ] text , int count , ref int focus , ref int scrollIndex , int active)
        {
            GuiState state = guiState;
            int itemFocused = focus;
            int itemSelected = active;

            // Check if we need a scroll bar
            bool useScrollBar = false;
            if ((GuiGetStyle(LISTVIEW , LIST_ITEMS_HEIGHT) + GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING)) * count > bounds.height) useScrollBar = true;

            // Define base item rectangle [0]
            Rectangle itemBounds = new Rectangle(0 , 0 , 0 , 0);
            itemBounds.x = bounds.x + GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING);
            itemBounds.y = bounds.y + GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING) + GuiGetStyle(DEFAULT , BORDER_WIDTH);
            itemBounds.width = bounds.width - 2 * GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING) - GuiGetStyle(DEFAULT , BORDER_WIDTH);
            itemBounds.height = GuiGetStyle(LISTVIEW , LIST_ITEMS_HEIGHT);
            if (useScrollBar) itemBounds.width -= GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH);

            // Get items on the list
            int visibleItems = (int)bounds.height / ((int)GuiGetStyle(LISTVIEW , LIST_ITEMS_HEIGHT) + (int)GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING));
            if (visibleItems > count) visibleItems = count;

            int startIndex = (scrollIndex == -1) ? 0 : scrollIndex;
            if ((startIndex < 0) || (startIndex > (count - visibleItems))) startIndex = 0;
            int endIndex = startIndex + visibleItems;

            // Update control
            //--------------------------------------------------------------------
            if ((state != (GuiState)STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check mouse inside list view
                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    state = GuiState.STATE_FOCUSED;

                    // Check focused and selected item
                    for (int i = 0 ; i < visibleItems ; i++)
                    {
                        if (CheckCollisionPointRec(mousePoint , itemBounds))
                        {
                            itemFocused = startIndex + i;
                            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                if (itemSelected == (startIndex + i)) itemSelected = -1;
                                else itemSelected = startIndex + i;
                            }
                            break;
                        }

                        // Update item rectangle y position for next item
                        itemBounds.y += (GuiGetStyle(LISTVIEW , LIST_ITEMS_HEIGHT) + GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING));
                    }

                    if (useScrollBar)
                    {
                        int wheelMove = (int)Raylib.GetMouseWheelMove();
                        startIndex -= wheelMove;

                        if (startIndex < 0) startIndex = 0;
                        else if (startIndex > (count - visibleItems)) startIndex = count - visibleItems;

                        endIndex = startIndex + visibleItems;
                        if (endIndex > count) endIndex = count;
                    }
                }
                else itemFocused = -1;

                // Reset item rectangle y to [0]
                itemBounds.y = bounds.y + GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING) + GuiGetStyle(DEFAULT , BORDER_WIDTH);
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds , (int)GuiGetStyle(DEFAULT , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(LISTVIEW , BORDER + (int)state * 3)) , guiAlpha) , GetColor(GuiGetStyle(DEFAULT , BACKGROUND_COLOR)));     // Draw background

            // Draw visible items
            for (int i = 0 ; ((i < visibleItems) && (text.Length > 0)) ; i++)
            {
                if (state == GuiState.STATE_DISABLED)
                {
                    if ((startIndex + i) == itemSelected)
                        GuiDrawRectangle(itemBounds , (int)GuiGetStyle(LISTVIEW , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(LISTVIEW , BORDER_COLOR_DISABLED)) , guiAlpha) , Fade(GetColor(GuiGetStyle(LISTVIEW , BASE_COLOR_DISABLED)) , guiAlpha));

                    GuiDrawText(text [ startIndex + i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(LISTVIEW , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(LISTVIEW , TEXT_COLOR_DISABLED)) , guiAlpha));
                }
                else
                {
                    if ((startIndex + i) == itemSelected)
                    {
                        // Draw item selected
                        GuiDrawRectangle(itemBounds , (int)GuiGetStyle(LISTVIEW , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(LISTVIEW , BORDER_COLOR_PRESSED)) , guiAlpha) , Fade(GetColor(GuiGetStyle(LISTVIEW , BASE_COLOR_PRESSED)) , guiAlpha));
                        GuiDrawText(text [ startIndex + i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(LISTVIEW , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(LISTVIEW , TEXT_COLOR_PRESSED)) , guiAlpha));
                    }
                    else if ((startIndex + i) == itemFocused)
                    {
                        // Draw item focused
                        GuiDrawRectangle(itemBounds , (int)GuiGetStyle(LISTVIEW , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(LISTVIEW , BORDER_COLOR_FOCUSED)) , guiAlpha) , Fade(GetColor(GuiGetStyle(LISTVIEW , BASE_COLOR_FOCUSED)) , guiAlpha));
                        GuiDrawText(text [ startIndex + i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(LISTVIEW , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(LISTVIEW , TEXT_COLOR_FOCUSED)) , guiAlpha));
                    }
                    else
                    {
                        // Draw item normal
                        GuiDrawText(text [ startIndex + i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(LISTVIEW , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(LISTVIEW , TEXT_COLOR_NORMAL)) , guiAlpha));
                    }
                }

                // Update item rectangle y position for next item
                itemBounds.y += (GuiGetStyle(LISTVIEW , LIST_ITEMS_HEIGHT) + GuiGetStyle(LISTVIEW , LIST_ITEMS_SPACING));
            }

            if (useScrollBar)
            {
                Rectangle scrollBarBounds = new(bounds.x + bounds.width - GuiGetStyle(LISTVIEW , BORDER_WIDTH) - GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH) ,
                                                bounds.y + GuiGetStyle(LISTVIEW , BORDER_WIDTH) ,
                                                GuiGetStyle(LISTVIEW , SCROLLBAR_WIDTH) ,
                                                bounds.height - 2 * GuiGetStyle(DEFAULT , BORDER_WIDTH));

                // Calculate percentage of visible items and apply same percentage to scrollbar
                float percentVisible = (float)(endIndex - startIndex) / count;
                float sliderSize = bounds.height * percentVisible;

                int prevSliderSize = (int)GuiGetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE);   // Save default slider size
                int prevScrollSpeed = (int)GuiGetStyle(SCROLLBAR , SCROLL_SPEED); // Save default scroll speed
                GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE , (uint)(int)sliderSize);            // Change slider size
                GuiSetStyle(SCROLLBAR , SCROLL_SPEED , (uint)(count - visibleItems)); // Change scroll speed

                startIndex = GuiScrollBar(scrollBarBounds , startIndex , 0 , count - visibleItems);

                GuiSetStyle(SCROLLBAR , SCROLL_SPEED , (uint)prevScrollSpeed); // Reset scroll speed to default
                GuiSetStyle(SCROLLBAR , SCROLL_SLIDER_SIZE , (uint)prevSliderSize); // Reset slider size to default
            }
            //--------------------------------------------------------------------

            focus = itemFocused;
            scrollIndex = startIndex;

            return itemSelected;
        }

        static bool TextInputBox_textEditMode = false;
        // Text Input Box control, ask for text
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiTextInputBox(Rectangle bounds , ReadonlyString title , ReadonlyString message , ReadonlyString buttons , ref string text , int textMaxSize , ref int? secretViewActive)
        {

            // Used to enable text edit mode
            // WARNING: No more than one GuiTextInputBox() should be open at the same time

            int btnIndex = -1;
            var buttonsText_Result = buttons.AsReadOnlySpan().SplitSingleChar(';');
            int buttonCount = buttonsText_Result.Item1;
            Rectangle buttonBounds = new Rectangle(0 , 0 , 0 , 0);
            buttonBounds.x = bounds.x + RAYGUI_TEXTINPUTBOX_BUTTON_PADDING;
            buttonBounds.y = bounds.y + bounds.height - RAYGUI_TEXTINPUTBOX_BUTTON_HEIGHT - RAYGUI_TEXTINPUTBOX_BUTTON_PADDING;
            buttonBounds.width = (bounds.width - RAYGUI_TEXTINPUTBOX_BUTTON_PADDING * (buttonCount + 1)) / buttonCount;
            buttonBounds.height = RAYGUI_TEXTINPUTBOX_BUTTON_HEIGHT;

            int messageInputHeight = (int)((int)bounds.height - RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT - GuiGetStyle(STATUSBAR , BORDER_WIDTH) - RAYGUI_TEXTINPUTBOX_BUTTON_HEIGHT - 2 * RAYGUI_TEXTINPUTBOX_BUTTON_PADDING);

            Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);
            if (message.Ref != null)
            {
                int textSize = GetTextWidth(message) + 2;

                textBounds.x = bounds.x + bounds.width / 2 - textSize / 2;
                textBounds.y = bounds.y + RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT + messageInputHeight / 4 - (float)GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;
                textBounds.width = textSize;
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
            }

            Rectangle textBoxBounds = new Rectangle(0 , 0 , 0 , 0);
            textBoxBounds.x = bounds.x + RAYGUI_TEXTINPUTBOX_BUTTON_PADDING;
            textBoxBounds.y = bounds.y + RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT - RAYGUI_TEXTINPUTBOX_HEIGHT / 2;
            if (message.Ref == null) textBoxBounds.y = bounds.y + 24 + RAYGUI_TEXTINPUTBOX_BUTTON_PADDING;
            else textBoxBounds.y += (messageInputHeight / 2 + messageInputHeight / 4);
            textBoxBounds.width = bounds.width - RAYGUI_TEXTINPUTBOX_BUTTON_PADDING * 2;
            textBoxBounds.height = RAYGUI_TEXTINPUTBOX_HEIGHT;

            // Draw control
            //--------------------------------------------------------------------
            if (GuiWindowBox(bounds , title) == 1) btnIndex = 0;

            // Draw message if available
            if (message.Ref != null)
            {
                uint prevTextAlignment = GuiGetStyle(LABEL , TEXT_ALIGNMENT);
                GuiSetStyle(LABEL , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);
                GuiLabel(textBounds , message);
                GuiSetStyle(LABEL , TEXT_ALIGNMENT , prevTextAlignment);
            }

            if (secretViewActive.HasValue)
            {
                string stars = "****************";
                if (secretViewActive.Value == 1 || TextInputBox_textEditMode)
                {

                    if (GuiTextBox(new Rectangle(textBoxBounds.x , textBoxBounds.y , textBoxBounds.width - 4 - RAYGUI_TEXTINPUTBOX_HEIGHT , textBoxBounds.height) ,
                                   ref text ,
                                   textMaxSize ,
                                   TextInputBox_textEditMode))
                        TextInputBox_textEditMode = !TextInputBox_textEditMode;
                }
                else if (GuiTextBox(new Rectangle(textBoxBounds.x , textBoxBounds.y , textBoxBounds.width - 4 - RAYGUI_TEXTINPUTBOX_HEIGHT , textBoxBounds.height) ,
                                    ref stars ,
                                    textMaxSize ,
                                    TextInputBox_textEditMode))
                    TextInputBox_textEditMode = !TextInputBox_textEditMode;
                bool V = secretViewActive.Value == 1;
                GuiToggle(new Rectangle(textBoxBounds.x + textBoxBounds.width - RAYGUI_TEXTINPUTBOX_HEIGHT , textBoxBounds.y , RAYGUI_TEXTINPUTBOX_HEIGHT , RAYGUI_TEXTINPUTBOX_HEIGHT) ,
                    (secretViewActive.Value == 1) ? "#44#" : "#45#" , ref V);
                secretViewActive = V ? 1 : 0;
            }
            else
            {
                if (GuiTextBox(textBoxBounds , ref text , textMaxSize , TextInputBox_textEditMode)) TextInputBox_textEditMode = !TextInputBox_textEditMode;
            }

            uint prevBtnTextAlignment = GuiGetStyle(BUTTON , TEXT_ALIGNMENT);
            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);

            for (int i = 0 ; i < buttonCount ; i++)
            {
                {
                    ReadonlyString button = buttons;
                    button.Start = buttonsText_Result.Item2 [ i ].Item1;
                    button.Length = buttonsText_Result.Item2 [ i ].Item2;
                    if (GuiButton(buttonBounds , button) == 1) btnIndex = i + 1;

                }
                buttonBounds.x += (buttonBounds.width + RAYGUI_MESSAGEBOX_BUTTON_PADDING);
            }

            if (btnIndex >= 0) TextInputBox_textEditMode = false;

            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , prevBtnTextAlignment);
            //--------------------------------------------------------------------

            return btnIndex;
        }

        // Grid control
        // NOTE: Returns grid mouse-hover selected cell
        // About drawing lines at subpixel spacing, simple put, not easy solution:
        // https://stackoverflow.com/questions/4435450/2d-opengl-drawing-lines-that-dont-exactly-fit-pixel-raster
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 GuiGrid(Rectangle bounds , ReadonlyString text , float spacing , int subdivs)
        {

            GuiState state = guiState;
            Vector2 mousePoint = Raylib.GetMousePosition();
            Vector2 currentCell = new Vector2(-1 , -1);

            int linesV = ((int)(bounds.width / spacing)) * subdivs + 1;
            int linesH = ((int)(bounds.height / spacing)) * subdivs + 1;

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    // NOTE: Cell values must be the upper left of the cell the mouse is in
                    currentCell.X = MathF.Floor((mousePoint.X - bounds.x) / spacing);
                    currentCell.Y = MathF.Floor((mousePoint.Y - bounds.y) / spacing);
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            switch (state)
            {
                case GuiState.STATE_NORMAL:
                    {
                        if (subdivs > 0)
                        {
                            // Draw vertical grid lines
                            for (int i = 0 ; i < linesV ; i++)
                            {
                                Rectangle lineV = new Rectangle(bounds.x + spacing * i / subdivs , bounds.y , 1 , bounds.height);
                                GuiDrawRectangle(lineV , 0 , Color.BLANK , ((i % subdivs) == 0) ? Fade(GetColor(GuiGetStyle(DEFAULT , LINE_COLOR)) , RAYGUI_GRID_ALPHA * 4) : Fade(GetColor(GuiGetStyle(DEFAULT , LINE_COLOR)) , RAYGUI_GRID_ALPHA));
                            }

                            // Draw horizontal grid lines
                            for (int i = 0 ; i < linesH ; i++)
                            {
                                Rectangle lineH = new(bounds.x , bounds.y + spacing * i / subdivs , bounds.width , 1);
                                GuiDrawRectangle(lineH , 0 , Color.BLANK , ((i % subdivs) == 0) ? Fade(GetColor(GuiGetStyle(DEFAULT , LINE_COLOR)) , RAYGUI_GRID_ALPHA * 4) : Fade(GetColor(GuiGetStyle(DEFAULT , LINE_COLOR)) , RAYGUI_GRID_ALPHA));
                            }
                        }
                    }
                    break;
                default: break;
            }

            return currentCell;
        }


        // Check Box control, returns true when active
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GuiCheckBox(Rectangle bounds , ReadonlyString text , bool _checked)
        {
            GuiState state = guiState;

            Rectangle textBounds = new Rectangle(0 , 0 , 0 , 0);

            if (!text.IsNull())
            {
                textBounds.width = (float)GetTextWidth(text) + 2;
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x + bounds.width + GuiGetStyle(CHECKBOX , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;
                if (GuiGetStyle(CHECKBOX , TEXT_ALIGNMENT) == TEXT_ALIGN_LEFT) textBounds.x = bounds.x - textBounds.width - GuiGetStyle(CHECKBOX , TEXT_PADDING);
            }

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                Rectangle totalBounds = new(
                    (GuiGetStyle(CHECKBOX , TEXT_ALIGNMENT) == TEXT_ALIGN_LEFT) ? textBounds.x : bounds.x ,
                    bounds.y ,
                    bounds.width + textBounds.width + GuiGetStyle(CHECKBOX , TEXT_PADDING) ,
                    bounds.height
                );

                // Check checkbox state
                if (CheckCollisionPointRec(mousePoint , totalBounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = GuiState.STATE_PRESSED;
                    else state = GuiState.STATE_FOCUSED;

                    if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON)) _checked = !_checked;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            GuiDrawRectangle(bounds , (int)GuiGetStyle(CHECKBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(CHECKBOX , BORDER + ((int)state * 3))) , guiAlpha) , Color.BLANK);

            if (_checked)
            {
                Rectangle check = new(bounds.x + GuiGetStyle(CHECKBOX , BORDER_WIDTH) + GuiGetStyle(CHECKBOX , CHECK_PADDING) ,
                                    bounds.y + GuiGetStyle(CHECKBOX , BORDER_WIDTH) + GuiGetStyle(CHECKBOX , CHECK_PADDING) ,
                                    bounds.width - 2 * (GuiGetStyle(CHECKBOX , BORDER_WIDTH) + GuiGetStyle(CHECKBOX , CHECK_PADDING)) ,
                                    bounds.height - 2 * (GuiGetStyle(CHECKBOX , BORDER_WIDTH) + GuiGetStyle(CHECKBOX , CHECK_PADDING)));
                GuiDrawRectangle(check , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(CHECKBOX , TEXT + (int)state * 3)) , guiAlpha));
            }

            GuiDrawText(text , textBounds , (GuiGetStyle(CHECKBOX , TEXT_ALIGNMENT) == TEXT_ALIGN_RIGHT) ? TEXT_ALIGN_LEFT : TEXT_ALIGN_RIGHT , Fade(GetColor(GuiGetStyle(LABEL , TEXT + ((int)state * 3))) , guiAlpha));
            //--------------------------------------------------------------------

            return _checked;
        }

        // Combo Box control, returns selected item codepointIndex
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiComboBox(Rectangle bounds , ReadonlyString text , int active)
        {
            GuiState state = guiState;

            bounds.width -= (GuiGetStyle(COMBOBOX , COMBO_BUTTON_WIDTH) + GuiGetStyle(COMBOBOX , COMBO_BUTTON_SPACING));

            Rectangle selector = new(bounds.x + bounds.width + GuiGetStyle(COMBOBOX , COMBO_BUTTON_SPACING) ,
                                   bounds.y , GuiGetStyle(COMBOBOX , COMBO_BUTTON_WIDTH) , bounds.height);

            // Get substrings items from text (items pointers, lengths and count)
            int itemCount = 0;
            var result = text.AsReadOnlySpan().SplitSingleChar(';');
            itemCount = result.Item1;
            if (active < 0) active = 0;
            else if (active > itemCount - 1) active = itemCount - 1;

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && (itemCount > 1) && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (CheckCollisionPointRec(mousePoint , bounds) ||
                    CheckCollisionPointRec(mousePoint , selector))
                {
                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        active += 1;
                        if (active >= itemCount) active = 0;
                    }

                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = GuiState.STATE_PRESSED;
                    else state = GuiState.STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            // Draw combo box main
            var items = new ReadonlyString [ itemCount ];
            for (int i = 0 ; i < itemCount ; i++)
            {
                items [ i ] = text;
                items [ i ].Start = result.Item2 [ i ].Item1;
                items [ i ].Length = result.Item2 [ i ].Item2;
            }
            GuiDrawRectangle(bounds , (int)GuiGetStyle(COMBOBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(COMBOBOX , BORDER + ((int)state * 3))) , guiAlpha) , Fade(GetColor(GuiGetStyle(COMBOBOX , BASE + ((int)state * 3))) , guiAlpha));
            GuiDrawText(items [ active ] , GetTextBounds(COMBOBOX , bounds) , (int)GuiGetStyle(COMBOBOX , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(COMBOBOX , TEXT + ((int)state * 3))) , guiAlpha));

            // Draw selector using a custom button
            // NOTE: BORDER_WIDTH and TEXT_ALIGNMENT forced values
            uint tempBorderWidth = GuiGetStyle(BUTTON , BORDER_WIDTH);
            uint tempTextAlign = GuiGetStyle(BUTTON , TEXT_ALIGNMENT);
            GuiSetStyle(BUTTON , BORDER_WIDTH , 1);
            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);

            GuiButton(selector , TextFormat("{0}/{1}" , active + 1 , itemCount));

            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , tempTextAlign);
            GuiSetStyle(BUTTON , BORDER_WIDTH , tempBorderWidth);
            //--------------------------------------------------------------------

            return active;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string TextFormat(string str , params object [ ] args)
        {
            return string.Format(str , args);
        }
        // Dropdown Box control
        // NOTE: Returns mouse click
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GuiDropdownBox(Rectangle bounds , ReadonlyString text , ref int active , bool editMode)
        {
            GuiState state = guiState;
            int itemSelected = active;
            int itemFocused = -1;

            // Get substrings items from text (items pointers, lengths and count)
            var result = text.AsReadOnlySpan().SplitSingleChar(';');
            int itemCount = result.Item1;

            var items = new ReadonlyString [ itemCount ];
            for (int i = 0 ; i < itemCount ; i++)
            {
                items [ i ] = text;
                items [ i ].Start = result.Item2 [ i ].Item1;
                items [ i ].Length = result.Item2 [ i ].Item2;
            }
            Rectangle boundsOpen = bounds;
            boundsOpen.height = (itemCount + 1) * (bounds.height + GuiGetStyle(DROPDOWNBOX , DROPDOWN_ITEMS_SPACING));

            Rectangle itemBounds = bounds;

            bool pressed = false;       // Check mouse button pressed

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && (editMode || !guiLocked) && (itemCount > 1) && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (editMode)
                {
                    state = GuiState.STATE_PRESSED;

                    // Check if mouse has been pressed or released outside limits
                    if (!CheckCollisionPointRec(mousePoint , boundsOpen))
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON) || Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON)) pressed = true;
                    }

                    // Check if already selected item has been pressed again
                    if (CheckCollisionPointRec(mousePoint , bounds) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON)) pressed = true;

                    // Check focused and selected item
                    for (int i = 0 ; i < itemCount ; i++)
                    {
                        // Update item rectangle y position for next item
                        itemBounds.y += (bounds.height + GuiGetStyle(DROPDOWNBOX , DROPDOWN_ITEMS_SPACING));

                        if (CheckCollisionPointRec(mousePoint , itemBounds))
                        {
                            itemFocused = i;
                            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                            {
                                itemSelected = i;
                                pressed = true;     // Item selected, change to editMode = false
                            }
                            break;
                        }
                    }

                    itemBounds = bounds;
                }
                else
                {
                    if (CheckCollisionPointRec(mousePoint , bounds))
                    {
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            pressed = true;
                            state = GuiState.STATE_PRESSED;
                        }
                        else state = GuiState.STATE_FOCUSED;
                    }
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (editMode) GuiPanel(boundsOpen , ReadonlyString.NULL);

            GuiDrawRectangle(bounds , (int)GuiGetStyle(DROPDOWNBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , BORDER + (int)state * 3)) , guiAlpha) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , BASE + (int)state * 3)) , guiAlpha));
            GuiDrawText(items [ itemSelected ] , GetTextBounds(DEFAULT , bounds) , (int)GuiGetStyle(DROPDOWNBOX , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT + (int)state * 3)) , guiAlpha));

            if (editMode)
            {
                // Draw visible items
                for (int i = 0 ; i < itemCount ; i++)
                {
                    // Update item rectangle y position for next item
                    itemBounds.y += (bounds.height + GuiGetStyle(DROPDOWNBOX , DROPDOWN_ITEMS_SPACING));

                    if (i == itemSelected)
                    {
                        GuiDrawRectangle(itemBounds , (int)GuiGetStyle(DROPDOWNBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , BORDER_COLOR_PRESSED)) , guiAlpha) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , BASE_COLOR_PRESSED)) , guiAlpha));
                        GuiDrawText(items [ i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(DROPDOWNBOX , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT_COLOR_PRESSED)) , guiAlpha));
                    }
                    else if (i == itemFocused)
                    {
                        GuiDrawRectangle(itemBounds , (int)GuiGetStyle(DROPDOWNBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , BORDER_COLOR_FOCUSED)) , guiAlpha) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , BASE_COLOR_FOCUSED)) , guiAlpha));
                        GuiDrawText(items [ i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(DROPDOWNBOX , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT_COLOR_FOCUSED)) , guiAlpha));
                    }
                    else GuiDrawText(items [ i ] , GetTextBounds(DEFAULT , itemBounds) , (int)GuiGetStyle(DROPDOWNBOX , TEXT_ALIGNMENT) , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT_COLOR_NORMAL)) , guiAlpha));
                }
            }

            // Draw arrows (using icon if available)
            if (RAYGUI_NO_ICONS)
                GuiDrawText("v" , new Rectangle(bounds.x + bounds.width - GuiGetStyle(DROPDOWNBOX , ARROW_PADDING) , bounds.y + bounds.height / 2 - 2 , 10 , 10) ,
                            TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT + ((int)state * 3))) , guiAlpha));
            else
                GuiDrawText("#120#" , new Rectangle(bounds.x + bounds.width - GuiGetStyle(DROPDOWNBOX , ARROW_PADDING) , bounds.y + bounds.height / 2 - 6 , 10 , 10) ,
                            TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(DROPDOWNBOX , TEXT + ((int)state * 3))) , guiAlpha));   // ICON_ARROW_DOWN_FILL
                                                                                                                                  //--------------------------------------------------------------------

            active = itemSelected;
            return pressed;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // Spinner control, returns selected value
        public static bool GuiSpinner(Rectangle bounds , ReadonlyString text , ref int value , int minValue , int maxValue , bool editMode)
        {
            GuiState state = guiState;

            bool pressed = false;
            int tempValue = value;

            Rectangle spinner = new(bounds.x + GuiGetStyle(SPINNER , SPIN_BUTTON_WIDTH) + GuiGetStyle(SPINNER , SPIN_BUTTON_SPACING) , bounds.y ,
                                  bounds.width - 2 * (GuiGetStyle(SPINNER , SPIN_BUTTON_WIDTH) + GuiGetStyle(SPINNER , SPIN_BUTTON_SPACING)) , bounds.height);
            Rectangle leftButtonBound = new(bounds.x , bounds.y , GuiGetStyle(SPINNER , SPIN_BUTTON_WIDTH) , bounds.height);
            Rectangle rightButtonBound = new(bounds.x + bounds.width - GuiGetStyle(SPINNER , SPIN_BUTTON_WIDTH) , bounds.y , GuiGetStyle(SPINNER , SPIN_BUTTON_WIDTH) , bounds.height);

            Rectangle textBounds = default;
            if (!text.IsNull())
            {
                textBounds.width = (float)GetTextWidth(text) + 2;
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x + bounds.width + GuiGetStyle(SPINNER , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;
                if (GuiGetStyle(SPINNER , TEXT_ALIGNMENT) == TEXT_ALIGN_LEFT) textBounds.x = bounds.x - textBounds.width - GuiGetStyle(SPINNER , TEXT_PADDING);
            }

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                // Check spinner state
                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) state = GuiState.STATE_PRESSED;
                    else state = GuiState.STATE_FOCUSED;
                }
            }

            if (RAYGUI_NO_ICONS)
            {
                if (GuiButton(leftButtonBound , "<") == 1) tempValue--;
                if (GuiButton(rightButtonBound , ">") == 1) tempValue++;
            }
            else
            {
                if (GuiButton(leftButtonBound , (int)GuiIconName.ICON_ARROW_LEFT_FILL , "") == 1) tempValue--;
                if (GuiButton(rightButtonBound , (int)GuiIconName.ICON_ARROW_RIGHT_FILL , "") == 1) tempValue++;
            }


            if (!editMode)
            {
                if (tempValue < minValue) tempValue = minValue;
                if (tempValue > maxValue) tempValue = maxValue;
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            pressed = GuiValueBox(spinner , ReadonlyString.NULL , ref tempValue , minValue , maxValue , editMode);

            // Draw value selector custom buttons
            // NOTE: BORDER_WIDTH and TEXT_ALIGNMENT forced values
            uint tempBorderWidth = GuiGetStyle(BUTTON , BORDER_WIDTH);
            uint tempTextAlign = GuiGetStyle(BUTTON , TEXT_ALIGNMENT);
            GuiSetStyle(BUTTON , BORDER_WIDTH , GuiGetStyle(SPINNER , BORDER_WIDTH));
            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , TEXT_ALIGN_CENTER);

            GuiSetStyle(BUTTON , TEXT_ALIGNMENT , tempTextAlign);
            GuiSetStyle(BUTTON , BORDER_WIDTH , tempBorderWidth);

            // Draw text label if provided
            GuiDrawText(text , textBounds , (GuiGetStyle(SPINNER , TEXT_ALIGNMENT) == TEXT_ALIGN_RIGHT) ? TEXT_ALIGN_LEFT : TEXT_ALIGN_RIGHT , Fade(GetColor(GuiGetStyle(LABEL , TEXT + ((int)state * 3))) , guiAlpha));
            //--------------------------------------------------------------------

            value = tempValue;
            return pressed;
        }

        // Value Box control, updates input text with numbers
        // NOTE: Requires static variables: frameCounter
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GuiValueBox(Rectangle bounds , ReadonlyString text , ref int value , int minValue , int maxValue , bool editMode)
        {
            GuiState state = guiState;
            bool pressed = false;

            //char textValue [ RAYGUI_VALUEBOX_MAX_CHARS + 1 ] = "\0";
            //sprintf(textValue , "%i" , *value);
            var str = value.ToString();
            Rectangle textBounds = default;
            if (text.IsNotNull())
            {
                textBounds.width = (float)GetTextWidth(text) + 2;
                textBounds.height = GuiGetStyle(DEFAULT , TEXT_SIZE);
                textBounds.x = bounds.x + bounds.width + GuiGetStyle(VALUEBOX , TEXT_PADDING);
                textBounds.y = bounds.y + bounds.height / 2 - GuiGetStyle(DEFAULT , TEXT_SIZE) / 2;
                if (GuiGetStyle(VALUEBOX , TEXT_ALIGNMENT) == TEXT_ALIGN_LEFT) textBounds.x = bounds.x - textBounds.width - GuiGetStyle(VALUEBOX , TEXT_PADDING);
            }

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                bool valueHasChanged = false;

                if (editMode)
                {
                    state = GuiState.STATE_PRESSED;

                    int keyCount = str.Length;

                    // Only allow keys in range [48..57]
                    if (keyCount < RAYGUI_VALUEBOX_MAX_CHARS)
                    {
                        if (GetTextWidth(str.ToString()) < bounds.width)
                        {
                            int key = Raylib.GetCharPressed();
                            if ((key >= 48) && (key <= 57))
                            {
                                str += (char)key;
                                keyCount++;
                                valueHasChanged = true;
                            }
                        }
                    }

                    // Delete text
                    if (keyCount > 0)
                    {
                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_BACKSPACE))
                        {
                            keyCount--;
                            str = str.Substring(0 , str.Length - 1);
                            valueHasChanged = true;
                        }
                    }

                    if (valueHasChanged) value = TextToInteger(str.ToCharArray());

                    // NOTE: We are not clamp values until user input finishes
                    //if (*value > maxValue) *value = maxValue;
                    //else if (*value < minValue) *value = minValue;

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER) || (!CheckCollisionPointRec(mousePoint , bounds) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))) pressed = true;
                }
                else
                {
                    if (value > maxValue) value = maxValue;
                    else if (value < minValue) value = minValue;

                    if (CheckCollisionPointRec(mousePoint , bounds))
                    {
                        state = GuiState.STATE_FOCUSED;
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON)) pressed = true;
                    }
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            Color baseColor = Color.BLANK;
            if (state == GuiState.STATE_PRESSED) baseColor = GetColor(GuiGetStyle(VALUEBOX , BASE_COLOR_PRESSED));
            else if (state == GuiState.STATE_DISABLED) baseColor = GetColor(GuiGetStyle(VALUEBOX , BASE_COLOR_DISABLED));
            var _tv = str;
            // WARNING: BLANK color does not work properly with Fade()
            GuiDrawRectangle(bounds , (int)GuiGetStyle(VALUEBOX , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(VALUEBOX , BORDER + ((int)state * 3))) , guiAlpha) , baseColor);
            GuiDrawText(_tv , GetTextBounds(VALUEBOX , bounds) , TEXT_ALIGN_CENTER , Fade(GetColor(GuiGetStyle(VALUEBOX , TEXT + ((int)state * 3))) , guiAlpha));

            // Draw cursor
            if (editMode)
            {
                // NOTE: ValueBox internal text is always centered
                Rectangle cursor = new(bounds.x + GetTextWidth(_tv) / 2 + bounds.width / 2 + 1 , bounds.y + 2 * GuiGetStyle(VALUEBOX , BORDER_WIDTH) , 4 , bounds.height - 4 * GuiGetStyle(VALUEBOX , BORDER_WIDTH));
                GuiDrawRectangle(cursor , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(VALUEBOX , BORDER_COLOR_PRESSED)) , guiAlpha));
            }

            // Draw text label if provided
            GuiDrawText(text , textBounds , (GuiGetStyle(VALUEBOX , TEXT_ALIGNMENT) == TEXT_ALIGN_RIGHT) ? TEXT_ALIGN_LEFT : TEXT_ALIGN_RIGHT , Fade(GetColor(GuiGetStyle(LABEL , TEXT + ((int)state * 3))) , guiAlpha));
            //--------------------------------------------------------------------

            return pressed;
        }

        // Color Panel control
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color GuiColorPanel(Rectangle bounds , ReadonlyString text , Color color)
        {
            Color colWhite = new(255 , 255 , 255 , 255);
            Color colBlack = new(0 , 0 , 0 , 255);

            GuiState state = guiState;
            Vector2 pickerSelector = new Vector2(0 , 0);
            Vector3 vcolor = new(color.r / 255.0f , color.g / 255.0f , color.b / 255.0f);
            Vector3 hsv = ConvertRGBtoHSV(vcolor);
            pickerSelector.X = bounds.x + hsv.Y * bounds.width;            // HSV: Saturation
            pickerSelector.Y = bounds.y + (1.0f - hsv.Z) * bounds.height;  // HSV: Value

            float hue = -1.0f;
            Vector3 maxHue = new(hue >= 0.0f ? hue : hsv.X , 1.0f , 1.0f);
            Vector3 rgbHue = ConvertHSVtoRGB(maxHue);
            Color maxHueCol = new((byte)(255.0f * rgbHue.X) ,
                              (byte)(255.0f * rgbHue.Y) ,
                              (byte)(255.0f * rgbHue.Z) , (byte)255);

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked && !guiSliderDragging)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (CheckCollisionPointRec(mousePoint , bounds))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = GuiState.STATE_PRESSED;
                        pickerSelector = mousePoint;

                        // Calculate color from picker
                        Vector2 colorPick = new(pickerSelector.X - bounds.x , pickerSelector.Y - bounds.y);

                        colorPick.X /= bounds.width;     // Get normalized value on x
                        colorPick.Y /= bounds.height;    // Get normalized value on y

                        hsv.Y = colorPick.X;
                        hsv.Z = 1.0f - colorPick.Y;

                        Vector3 rgb = ConvertHSVtoRGB(hsv);

                        // NOTE: Vector3ToColor() only available on raylib 1.8.1
                        color = new Color((byte)(255.0f * rgb.X) ,
                                         (byte)(255.0f * rgb.Y) ,
                                         (byte)(255.0f * rgb.Z) ,
                                         (byte)(255.0f * color.a / 255.0f));

                    }
                    else state = GuiState.STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (state != GuiState.STATE_DISABLED)
            {
                Raylib.DrawRectangleGradientEx(bounds , Fade(colWhite , guiAlpha) , Fade(colWhite , guiAlpha) , Fade(maxHueCol , guiAlpha) , Fade(maxHueCol , guiAlpha));
                Raylib.DrawRectangleGradientEx(bounds , Fade(colBlack , 0) , Fade(colBlack , guiAlpha) , Fade(colBlack , guiAlpha) , Fade(colBlack , 0));

                // Draw color picker: selector
                Rectangle selector = new(pickerSelector.X - GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE) / 2 ,
                                          pickerSelector.Y - GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE) / 2 ,
                                          GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE) ,
                                          GuiGetStyle(COLORPICKER , COLOR_SELECTOR_SIZE));
                GuiDrawRectangle(selector , 0 , Color.BLANK , Fade(colWhite , guiAlpha));
            }
            else
            {
                Raylib.DrawRectangleGradientEx(bounds , Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BASE_COLOR_DISABLED)) , 0.1f) , guiAlpha) , Fade(Fade(colBlack , 0.6f) , guiAlpha) , Fade(Fade(colBlack , 0.6f) , guiAlpha) , Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER_COLOR_DISABLED)) , 0.6f) , guiAlpha));
            }

            GuiDrawRectangle(bounds , (int)GuiGetStyle(COLORPICKER , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER + (int)state * 3)) , guiAlpha) , Color.BLANK);
            //--------------------------------------------------------------------

            return color;
        }

        // Color Bar Alpha control
        // NOTE: Returns alpha value normalized [0..1]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GuiColorBarAlpha(Rectangle bounds , ReadonlyString text , float alpha)
        {
            GuiState state = guiState;
            Rectangle selector = new(bounds.x + alpha * bounds.width - GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_HEIGHT) / 2 ,
                                      bounds.y - GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_OVERFLOW) ,
                                      GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_HEIGHT) ,
                                      bounds.height + GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_OVERFLOW) * 2);

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (guiSliderDragging) // Keep dragging outside of bounds
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        if (CHECK_BOUNDS_ID(bounds , guiSliderActive))
                        {
                            alpha = (mousePoint.X - bounds.x) / bounds.width;
                            if (alpha <= 0.0f) alpha = 0.0f;
                            if (alpha >= 1.0f) alpha = 1.0f;
                        }
                    }
                    else
                    {
                        guiSliderDragging = false;
                        guiSliderActive = default;
                    }
                }
                else if (CheckCollisionPointRec(mousePoint , bounds) || CheckCollisionPointRec(mousePoint , selector))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = GuiState.STATE_PRESSED;
                        guiSliderDragging = true;
                        guiSliderActive = bounds; // Store bounds as an identifier when dragging starts

                        alpha = (mousePoint.X - bounds.x) / bounds.width;
                        if (alpha <= 0.0f) alpha = 0.0f;
                        if (alpha >= 1.0f) alpha = 1.0f;
                        //selector.x = bounds.x + (int)(((alpha - 0)/(100 - 0))*(bounds.width - 2*GuiGetStyle(SLIDER, BORDER_WIDTH))) - selector.width/2;
                    }
                    else state = GuiState.STATE_FOCUSED;
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------

            // Draw alpha bar: checked background
            if (state != GuiState.STATE_DISABLED)
            {
                int checksX = (int)bounds.width / RAYGUI_COLORBARALPHA_CHECKED_SIZE;
                int checksY = (int)bounds.height / RAYGUI_COLORBARALPHA_CHECKED_SIZE;

                for (int x = 0 ; x < checksX ; x++)
                {
                    for (int y = 0 ; y < checksY ; y++)
                    {
                        Rectangle check = new(bounds.x + x * RAYGUI_COLORBARALPHA_CHECKED_SIZE ,
                                               bounds.y + y * RAYGUI_COLORBARALPHA_CHECKED_SIZE ,
                                               RAYGUI_COLORBARALPHA_CHECKED_SIZE ,
                                               RAYGUI_COLORBARALPHA_CHECKED_SIZE);
                        GuiDrawRectangle(check , 0 , Color.BLANK , ((x + y) % 2 != 0) ? Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER_COLOR_DISABLED)) , 0.4f) , guiAlpha) : Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BASE_COLOR_DISABLED)) , 0.4f) , guiAlpha));
                    }
                }

                Raylib.DrawRectangleGradientEx(bounds ,
                                                new Color(255 , 255 , 255 , 0) ,
                                                new Color(255 , 255 , 255 , 0) ,
                                                Fade(new Color(0 , 0 , 0 , 255) , guiAlpha) ,
                                                Fade(new Color(0 , 0 , 0 , 255) , guiAlpha));
            }
            else Raylib.DrawRectangleGradientEx(bounds , Fade(GetColor(GuiGetStyle(COLORPICKER , BASE_COLOR_DISABLED)) , 0.1f) , Fade(GetColor(GuiGetStyle(COLORPICKER , BASE_COLOR_DISABLED)) , 0.1f) , Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER_COLOR_DISABLED)) , guiAlpha) , Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER_COLOR_DISABLED)) , guiAlpha));

            GuiDrawRectangle(bounds , (int)GuiGetStyle(COLORPICKER , BORDER_WIDTH) , Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER + (int)state * 3)) , guiAlpha) , Color.BLANK);

            // Draw alpha bar: selector
            GuiDrawRectangle(selector , 0 , Color.BLANK , Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER + (int)state * 3)) , guiAlpha));
            //--------------------------------------------------------------------

            return alpha;
        }

        // Color Bar Hue control
        // Returns hue value normalized [0..1]
        // NOTE: Other similar bars (for reference):
        //      Color GuiColorBarSat() [WHITE->color]
        //      Color GuiColorBarValue() [BLACK->color], HSV/HSL
        //      float GuiColorBarLuminance() [BLACK->WHITE]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiColorBarHue(Rectangle bounds , ReadonlyString text , ref float hue)
        {

            int result = 0;
            GuiState state = guiState;
            Rectangle selector = new(bounds.x - GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_OVERFLOW) ,
                                      (float)bounds.y + hue / 360.0f * bounds.height - GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_HEIGHT) / 2 ,
                                      (float)bounds.width + GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_OVERFLOW) * 2 ,
                                      (float)GuiGetStyle(COLORPICKER , HUEBAR_SELECTOR_HEIGHT));

            // Update control
            //--------------------------------------------------------------------
            if ((state != GuiState.STATE_DISABLED) && !guiLocked)
            {
                Vector2 mousePoint = Raylib.GetMousePosition();

                if (guiSliderDragging) // Keep dragging outside of bounds
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        if (CHECK_BOUNDS_ID(bounds , guiSliderActive))
                        {
                            state = GuiState.STATE_PRESSED;

                            hue = (mousePoint.Y - bounds.y) * 360 / bounds.height;
                            if (hue <= 0.0f) hue = 0.0f;
                            if (hue >= 359.0f) hue = 359.0f;
                        }
                    }
                    else
                    {
                        guiSliderDragging = false;
                        guiSliderActive = default;
                    }
                }
                else if (CheckCollisionPointRec(mousePoint , bounds) || CheckCollisionPointRec(mousePoint , selector))
                {
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        state = GuiState.STATE_PRESSED;
                        guiSliderDragging = true;
                        guiSliderActive = bounds; // Store bounds as an identifier when dragging starts

                        hue = (mousePoint.Y - bounds.y) * 360 / bounds.height;
                        if (hue <= 0.0f) hue = 0.0f;
                        if (hue >= 359.0f) hue = 359.0f;

                    }
                    else state = GuiState.STATE_FOCUSED;

                    /*if (IsKeyDown(KEY_UP))
                    {
                        hue -= 2.0f;
                        if (hue <= 0.0f) hue = 0.0f;
                    }
                    else if (IsKeyDown(KEY_DOWN))
                    {
                        hue += 2.0f;
                        if (hue >= 360.0f) hue = 360.0f;
                    }*/
                }
            }
            //--------------------------------------------------------------------

            // Draw control
            //--------------------------------------------------------------------
            if (state != GuiState.STATE_DISABLED)
            {
                // Draw hue bar:color bars
                Raylib.DrawRectangleGradientV((int)bounds.x , (int)(bounds.y) , (int)bounds.width , (int)MathF.Ceiling(bounds.height / 6) , Fade(new(255 , 0 , 0 , 255) , guiAlpha) , Fade(new(255 , 255 , 0 , 255) , guiAlpha));
                Raylib.DrawRectangleGradientV((int)bounds.x , (int)(bounds.y + bounds.height / 6) , (int)bounds.width , (int)MathF.Ceiling(bounds.height / 6) , Fade(new(255 , 255 , 0 , 255) , guiAlpha) , Fade(new(0 , 255 , 0 , 255) , guiAlpha));
                Raylib.DrawRectangleGradientV((int)bounds.x , (int)(bounds.y + 2 * (bounds.height / 6)) , (int)bounds.width , (int)MathF.Ceiling(bounds.height / 6) , Fade(new(0 , 255 , 0 , 255) , guiAlpha) , Fade(new(0 , 255 , 255 , 255) , guiAlpha));
                Raylib.DrawRectangleGradientV((int)bounds.x , (int)(bounds.y + 3 * (bounds.height / 6)) , (int)bounds.width , (int)MathF.Ceiling(bounds.height / 6) , Fade(new(0 , 255 , 255 , 255) , guiAlpha) , Fade(new(0 , 0 , 255 , 255) , guiAlpha));
                Raylib.DrawRectangleGradientV((int)bounds.x , (int)(bounds.y + 4 * (bounds.height / 6)) , (int)bounds.width , (int)MathF.Ceiling(bounds.height / 6) , Fade(new(0 , 0 , 255 , 255) , guiAlpha) , Fade(new(255 , 0 , 255 , 255) , guiAlpha));
                Raylib.DrawRectangleGradientV((int)bounds.x , (int)(bounds.y + 5 * (bounds.height / 6)) , (int)bounds.width , (int)(bounds.height / 6) , Fade(new(255 , 0 , 255 , 255) , guiAlpha) , Fade(new(255 , 0 , 0 , 255) , guiAlpha));
            }
            else Raylib.DrawRectangleGradientV((int)bounds.x , (int)bounds.y , (int)bounds.width , (int)bounds.height , Fade(Fade(GetColor(GuiGetStyle(COLORPICKER , BASE_COLOR_DISABLED)) , 0.1f) , guiAlpha) , Fade(GetColor(GuiGetStyle(COLORPICKER , BORDER_COLOR_DISABLED)) , guiAlpha));

            GuiDrawRectangle(bounds , (int)GuiGetStyle(COLORPICKER , BORDER_WIDTH) , GetColor(GuiGetStyle(COLORPICKER , BORDER + (int)state * 3)) , Color.BLANK);

            // Draw hue bar: selector
            GuiDrawRectangle(selector , 0 , Color.BLANK , GetColor(GuiGetStyle(COLORPICKER , BORDER + (int)state * 3)));
            //--------------------------------------------------------------------

            return result;
        }

        // Color Picker control
        // NOTE: It's divided in multiple controls:
        //      Color GuiColorPanel(Rectangle bounds, Color color)
        //      float GuiColorBarAlpha(Rectangle bounds, float alpha)
        //      float GuiColorBarHue(Rectangle bounds, float value)
        // NOTE: bounds define GuiColorPanel() size
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color GuiColorPicker(Rectangle bounds , ReadonlyString text , Color color)
        {
            color = GuiColorPanel(bounds , ReadonlyString.NULL , color);

            Rectangle boundsHue = new(bounds.x + bounds.width + GuiGetStyle(COLORPICKER , HUEBAR_PADDING) , bounds.y , (float)GuiGetStyle(COLORPICKER , HUEBAR_WIDTH) , bounds.height);
            //Rectangle boundsAlpha = { bounds.x, bounds.y + bounds.height + GuiGetStyle(COLORPICKER, BARS_PADDING), bounds.width, GuiGetStyle(COLORPICKER, BARS_THICK) };

            Vector3 hsv = ConvertRGBtoHSV(new(color.r / 255.0f , color.g / 255.0f , color.b / 255.0f));
            hsv.X = GuiColorBarHue(boundsHue , ReadonlyString.NULL , ref hsv.X);
            //color.a = (byte)(GuiColorBarAlpha(boundsAlpha, (float)color.a/255.0f)*255.0f);
            Vector3 rgb = ConvertHSVtoRGB(hsv);
            color = new((byte)MathF.Round(rgb.X * 255.0f) , (byte)MathF.Round(rgb.Y * 255.0f) , (byte)MathF.Round(rgb.Z * 255.0f) , color.a);

            return color;
        }

        //----------------------------------------------------------------------------------
        // Gui Setup Functions Definition
        //----------------------------------------------------------------------------------
        // Enable gui global state
        // NOTE: We check for STATE_DISABLED to avoid messing custom global state setups
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiEnable() { if (guiState == GuiState.STATE_DISABLED) guiState = STATE_NORMAL; }

        // Disable gui global state
        // NOTE: We check for STATE_NORMAL to avoid messing custom global state setups
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiDisable() { if (guiState == STATE_NORMAL) guiState = GuiState.STATE_DISABLED; }

        // Lock gui global state
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiLock() { guiLocked = true; }

        // Unlock gui global state
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiUnlock() { guiLocked = false; }

        // Check if gui is locked (global state)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GuiIsLocked() { return guiLocked; }
        // Set gui state (global state)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiSetState(int state) { guiState = (GuiState)state; }

        // Get gui state (global state)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GuiGetState() { return (int)guiState; }


        //----------------------------------------------------------------------------------
        // Tooltip management functions
        // NOTE: Tooltips requires some global variables: tooltipPtr
        //----------------------------------------------------------------------------------
        // Enable gui tooltips (global state)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiEnableTooltip()
        { guiTooltip = true; }

        // Disable gui tooltips (global state)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiDisableTooltip()
        { guiTooltip = false; }

        // Set tooltip string
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiSetTooltip(string tooltip)
        { guiTooltipPtr = tooltip; }
        public static void GuiLoadStyle(string fileName)
        {

            bool tryBinary = false;
            if (File.Exists(fileName))
            {
                {

                    using var rstream = File.OpenRead(fileName);
                    using var SR = new StreamReader(rstream);
                    string line = null;
                    int I = 0;
                    bool WillTryBinaryLoad = false;
                    while ((line = SR.ReadLine()) != null)
                    {
                        if (line.Length > 0)
                        {
                            var header = line [ 0 ];
                            switch (header)
                            {
                                case '#':

                                    break;
                                case 'p':
                                    {
                                        var items = line.Split(' ' , StringSplitOptions.TrimEntries);

                                        int controlId = 0;
                                        int propertyId = 0;
                                        uint propertyValue = 0;
                                        controlId = int.Parse(items [ 1 ]);
                                        propertyId = int.Parse(items [ 2 ]);
                                        propertyValue = uint.Parse(items [ 3 ]);
                                        GuiSetStyle(controlId , propertyId , propertyValue);
                                    }
                                    break;
                                case 'f':
                                    {
                                        var items = line.Split(' ' , StringSplitOptions.TrimEntries);
                                        var fontsize = int.Parse(items [ 1 ]);
                                        var char_file = items [ 2 ];
                                        var font_file = items [ 3 ];
                                        if (char_file [ 0 ] != '0')
                                        {
                                            Font font = default;
                                            var Chars = File.ReadAllText(char_file);
                                            unsafe
                                            {
                                                int* values = (int*)Raylib.MemAlloc((Chars.Length + 1) * sizeof(int));
                                                int CharIndex = 0;
                                                for (int i = 0 ; i < Chars.Length ; i++)
                                                {
                                                    if (Chars [ i ] != '\n' && Chars [ i ] != '\r')
                                                    {
                                                        values [ CharIndex ] = Chars [ i ];
                                                        CharIndex++;
                                                    }
                                                }
                                                values [ CharIndex ] = 0;
                                                {
                                                    if (font.texture.id != Raylib.GetFontDefault().texture.id) Raylib.UnloadTexture(font.texture);
                                                    var b0 = Utf8StringUtils.ToUTF8Buffer(fileName);
                                                    var p0 = b0.AsPointer();
                                                    var b1 = Utf8StringUtils.ToUTF8Buffer(TextFormat("{0}/{1}" , Utf8StringUtils.GetUTF8String(Raylib.GetDirectoryPath(p0)) , font_file));
                                                    var p1 = b1.AsPointer();
                                                    font = Raylib.LoadFontEx(p1 , fontsize , values , CharIndex);
                                                    b0.Dispose();
                                                    b1.Dispose();
                                                    Raylib.MemFree(values);
                                                }
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    {
                                        if (I == 0)
                                        {
                                            //Binary File.
                                            WillTryBinaryLoad = true;
                                            goto BREAK;

                                        }
                                    }
                                    break;
                            }
                        }
                        I++;
                    }
                BREAK:
                    ;
                }
                {
                    if (tryBinary)
                    {
                        using var rstream = File.OpenRead(fileName);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static void GuiLoadStyleFromMemory(Stream stream)
        {
            {
                var sign = new byte [ 4 ];
                Span<byte> buffer2 = new byte [ 2 ];
                Span<byte> buffer4 = new byte [ 4 ];
                stream.Read(sign , 0 , 4);
                short version = 0;
                short reserved = 0;
                int propertyCount = 0;
                stream.Read(buffer2);
                version = BitConverter.ToInt16(buffer2);
                stream.Read(buffer2);
                reserved = BitConverter.ToInt16(buffer2);
                stream.Read(buffer4);
                propertyCount = BitConverter.ToInt32(buffer4);
                if (sign [ 0 ] == 'r' && sign [ 1 ] == 'G' && sign [ 2 ] == 'S' && sign [ 3 ] == ' ')
                {
                    for (int _i = 0 ; _i < propertyCount ; _i++)
                    {
                        var cID = stream.ReadInt16(buffer4);
                        var pID = stream.ReadInt16(buffer4);
                        var pV = stream.ReadUInt32(buffer4);

                        if (cID == 0) // DEFAULT control
                        {
                            // If a DEFAULT property is loaded, it is propagated to all controls
                            // NOTE: All DEFAULT properties should be defined first in the file
                            GuiSetStyle(0 , (int)pID , pV);

                            if (pID < RAYGUI_MAX_PROPS_BASE) for (int i = 1 ; i < RAYGUI_MAX_CONTROLS ; i++) GuiSetStyle(i , (int)pID , pV);
                        }
                        else GuiSetStyle((int)cID , (int)pID , pV);
                    }
                    int FontDataSize = stream.ReadInt32(buffer4);
                    if (FontDataSize > 0)
                    {
                        Font font = default;
                        int fontType = 0;
                        Rectangle whiteRec = default;
                        font.baseSize = stream.ReadInt32(buffer4);
                        font.glyphCount = stream.ReadInt32(buffer4);
                        fontType = stream.ReadInt32(buffer4);
                        Rectangle rectangle = stream.ReadStruct<Rectangle>();

                        int fontImageUncompSize = stream.ReadInt32(buffer4);
                        int fontImageCompSize = stream.ReadInt32(buffer4);
                        Raylib_cs.Image imFont = default;
                        imFont.mipmaps = 1;
                        imFont.width = stream.ReadInt32(buffer4);
                        imFont.height = stream.ReadInt32(buffer4);
                        imFont.format = (PixelFormat)stream.ReadInt32(buffer4);
                        if (fontImageCompSize < fontImageUncompSize)
                        {
                            unsafe
                            {
                                // WARNING: May have memory leak or won't work at all!
                                int dataUncompSize = 0;
                                IntPtr p = Marshal.AllocHGlobal(fontImageCompSize);
                                byte [ ] compData = new byte [ fontImageCompSize ];
                                stream.Read(compData , 0 , fontImageCompSize);
                                Marshal.Copy(compData , 0 , p , fontImageCompSize);
                                var bp = (byte*)p.ToPointer();
                                imFont.data = Raylib.DecompressData(bp , fontImageCompSize , &dataUncompSize);
                                Marshal.FreeHGlobal(p);
                                if (dataUncompSize != fontImageUncompSize) Console.WriteLine("WARNING: Uncompressed font atlas image data could be corrupted");

                            }

                        }
                        else
                        {
                            unsafe
                            {
                                imFont.data = Raylib.MemAlloc(fontImageUncompSize);
                                byte [ ] buffer = new byte [ fontImageUncompSize ];
                                stream.Read(buffer);
                                Marshal.Copy(buffer , 0 , new IntPtr(imFont.data) , fontImageUncompSize);
                            }
                        }
                        if (font.texture.id != Raylib.GetFontDefault().texture.id) Raylib.UnloadTexture(font.texture);
                        font.texture = Raylib.LoadTextureFromImage(imFont);
                        if (font.texture.id == 0) font = Raylib.GetFontDefault();
                        unsafe
                        {
                            Raylib.MemFree(imFont.data);

                        }

                        // Load font recs data
                        unsafe
                        {
                            Rectangle* recs = (Rectangle*)Raylib.MemAlloc(font.glyphCount * sizeof(Rectangle));
                            for (int i = 0 ; i < font.glyphCount ; i++)
                            {
                                recs [ i ] = stream.ReadStruct<Rectangle>();
                            }
                            font.recs = recs;
                            for (int i = 0 ; i < font.glyphCount ; i++)
                            {
                                font.glyphs [ i ].value = stream.ReadInt32(buffer4);
                                font.glyphs [ i ].offsetX = stream.ReadInt32(buffer4);
                                font.glyphs [ i ].offsetY = stream.ReadInt32(buffer4);
                                font.glyphs [ i ].advanceX = stream.ReadInt32(buffer4);
                            }
                        }
                        GuiSetFont(font);

                        // Set font texture source rectangle to be used as white texture to draw shapes
                        // NOTE: This way, all gui can be draw using a single draw call
                        if ((whiteRec.width != 0) && (whiteRec.height != 0)) Raylib.SetShapesTexture(font.texture , whiteRec);
                    }
                }
            }
        }
        // Set custom gui font
        // NOTE: Font loading/unloading is external to raygui
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GuiSetFont(Font font)
        {
            if (font.texture.id > 0)
            {
                // NOTE: If we try to setup a font but default style has not been
                // lazily loaded before, it will be overwritten, so we need to force
                // default style loading first
                if (!guiStyleLoaded) GuiLoadStyleDefault();

                guiFont = font;
                GuiSetStyle(DEFAULT , TEXT_SIZE , (uint)font.baseSize);
            }
        }
        // Load raygui icons file (.rgi)
        // NOTE: In case nameIds are required, they can be requested with loadIconsName,
        // they are returned as a guiIconsName[iconCount][RAYGUI_ICON_MAX_NAME_LENGTH],
        // WARNING: guiIconsName[]][] memory should be manually freed!
        /// <summary>
        /// GuiLoadIcons.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="loadIconsName"></param>
        /// <returns>Null is loadIconsName is not specified.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string [ ] GuiLoadIcons(string fileName , bool loadIconsName)
        {
            // Style File Structure (.rgi)
            // ------------------------------------------------------
            // Offset  | Size    | Type       | Description
            // ------------------------------------------------------
            // 0       | 4       | char       | Signature: "rGI "
            // 4       | 2       | short      | Version: 100
            // 6       | 2       | short      | reserved

            // 8       | 2       | short      | Num icons (N)
            // 10      | 2       | short      | Icons size (Options: 16, 32, 64) (S)

            // Icons name id (32 bytes per name id)
            // foreach (icon)
            // {
            //   12+32*i  | 32   | char       | Icon NameId
            // }

            // Icons data: One bit per pixel, stored as unsigned int array (depends on icon size)
            // S*S pixels/32bit per unsigned int = K unsigned int per icon
            // foreach (icon)
            // {
            //   ...   | K       | unsigned int | Icon Data
            // }

            if (File.Exists(fileName))
            {
                using (var stream = File.OpenRead(fileName))
                {
                    byte [ ] buffer4 = new byte [ 4 ];
                    byte [ ] buffer2 = new byte [ 4 ];
                    stream.Read(buffer4 , 0 , 4);
                    short version = stream.ReadInt16(buffer2);
                    short reserved = stream.ReadInt16(buffer2);
                    short iconCount = stream.ReadInt16(buffer2);
                    short iconSize = stream.ReadInt16(buffer2);
                    if (buffer4 [ 0 ] == 'r' && buffer4 [ 1 ] == 'G' && buffer4 [ 2 ] == 'I' && buffer4 [ 3 ] == ' ')
                    {
                        if (loadIconsName)
                        {
                            byte [ ] buffer32 = new byte [ 32 ];
                            var guiIconsName = new string [ iconCount ];
                            //guiIconsName = (char**)RAYGUI_MALLOC(iconCount * sizeof(char**));
                            for (int i = 0 ; i < iconCount ; i++)
                            {
                                var l = stream.Read(buffer32 , 0 , RAYGUI_ICON_MAX_NAME_LENGTH);
                                guiIconsName [ i ] = Encoding.UTF8.GetString(buffer32 , 0 , RAYGUI_ICON_MAX_NAME_LENGTH);
                            }
                        }
                        else stream.Position += iconCount * RAYGUI_ICON_MAX_NAME_LENGTH;
                        if (guiIconsPtr.Length != iconCount * (iconSize * iconSize / 32))
                        {
                            guiIconsPtr = new uint [ iconCount * (iconSize * iconSize / 32) ];
                        }
                        for (int i = 0 ; i < guiIconsPtr.Length * sizeof(uint) ; i++)
                        {
                            guiIconsPtr [ i ] = stream.ReadUInt32(buffer4);
                        }
                    }
                }
            }
            return null;
        }

    }

}


